using FileReaderDomain.Strategy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderDomain.Strategy;

public class HexadecimalConverterStrategy : IConverterStraregy
{
    public async Task<string> ConvertFromBinaryAsync(byte[] data)
    {
        return await Task.Run(() =>
        {
            StringBuilder hex = new StringBuilder(data.Length * 2);

            foreach (byte b in data)
            {
                hex.AppendFormat("{0:x2}", b);
                hex.Append(' ');
            }

            return hex.ToString();
        });
    }
}