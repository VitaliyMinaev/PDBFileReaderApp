using FileReaderDomain.Strategy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderDomain.Strategy;

public class HexadecimalConverterStrategy : IConverterStraregy
{
    public string ConvertFromBinary(byte[] data)
    {
        StringBuilder hex = new StringBuilder(data.Length * 2);

        foreach (byte b in data)
        {
            hex.AppendFormat("{0:x2}", b);
            hex.Append(' ');
        }
        return hex.ToString();
    }
}