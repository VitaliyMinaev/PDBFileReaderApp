using FileReaderDomain.Strategy.Abstract;
using System.Reflection.Metadata;

namespace FileReaderDomain;

public class PDBFile
{
    private string _pathToPdbFile;
    private IConverterStraregy _converterStraregy;

    public string PathToPdbFile
    {
        get => _pathToPdbFile;
    }

    public PDBFile(string pathToPdbFile, IConverterStraregy converterStraregy)
    {
        if (ValidatePathToPdbFile(pathToPdbFile) == false)
            throw new ArgumentException("Inappropriate path to pdb file");

        _pathToPdbFile = pathToPdbFile;
        _converterStraregy = converterStraregy;  
    }

    public void SetPathToPdbFile(string path)
    {
        if (ValidatePathToPdbFile(path) == false)
            throw new ArgumentException("Inappropriate path to pdb file");

        _pathToPdbFile = path;
    }

    public async Task<string> GetDataFromPdbFileAsync()
    {
        byte[] data = await System.IO.File.ReadAllBytesAsync(_pathToPdbFile);
        return await _converterStraregy.ConvertFromBinaryAsync(data);
    }
    public Guid TryReadPdbGuid()
    {
        try
        {
            using (var stream = File.OpenRead(_pathToPdbFile))
            {
                if (stream.Length < 1024)
                {
                    return Guid.Empty;
                }

                if (stream.ReadByte() != 'B' ||
                    stream.ReadByte() != 'S' ||
                    stream.ReadByte() != 'J' ||
                    stream.ReadByte() != 'B')
                {
                    // not a portable Pdb
                    return Guid.Empty;
                }

                stream.Position = 0;

                using (var provider = MetadataReaderProvider.FromPortablePdbStream(stream))
                {
                    var metadataReader = provider.GetMetadataReader();
                    var id = metadataReader.DebugMetadataHeader.Id;
                    var guid = new Guid(id.Take(16).ToArray());
                    var stamp = id.Skip(16).ToArray();
                    return guid;
                }
            }
        }
        catch (Exception)
        {
            return Guid.Empty;
        }
    }
    public async Task<string> GetFileTypeAsync()
    {
        using var streamReader = new StreamReader(_pathToPdbFile);

        char[] chars = new char[24];
        var count = await streamReader.ReadAsync(chars, 0, chars.Length);

        if (count > 4 && new string(chars, 0, 4) == "BSJB")
        {
            return "Portable pdb";
        }

        if (count == 24)
        {
            if (new string(chars) == "Microsoft C/C++ MSF 7.00")
            {
                return "Native pdb: Microsoft C/C++ MSF 7.00";
            }
        }

        return String.Empty;
    }

    protected bool ValidatePathToPdbFile(string filePath)
    {
        if (System.IO.File.Exists(filePath) == false ||
            filePath.EndsWith(".pdb", StringComparison.OrdinalIgnoreCase) == false)
            return false;

        return true;
    }
}