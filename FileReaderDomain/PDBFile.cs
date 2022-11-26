using FileReaderDomain.Strategy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
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
}
