using FileReaderDomain.Strategy.Abstract;
using System.Text;

namespace FileReaderDomain.Strategy;

public class BytesConverterStratagy : IConverterStraregy
{
    public async Task<string> ConvertFromBinaryAsync(byte[] data)
    {
        return await Task.Run(() =>
        {
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; ++i)
            {
                stringBuilder.Append(data[i]);
                stringBuilder.Append(' ');
            }

            return stringBuilder.ToString();
        });
    }
}
