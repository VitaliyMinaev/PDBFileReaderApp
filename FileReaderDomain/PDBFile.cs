using FileReaderDomain.Strategy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

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
        // Validation ...
        _pathToPdbFile = pathToPdbFile;
        _converterStraregy = converterStraregy;  
    }

    public void SetPathToPdbFile(string path)
    {
        // Validation ...
        _pathToPdbFile = path;
    }

    public string GetDataFromPdbFile()
    {
        byte[] data = System.IO.File.ReadAllBytes(_pathToPdbFile);
        return _converterStraregy.ConvertFromBinary(data);
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
    public string GetFileType()
    {
        using var streamReader = new StreamReader(_pathToPdbFile);

        char[] chars = new char[24];
        var count = streamReader.Read(chars, 0, chars.Length);
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
}
