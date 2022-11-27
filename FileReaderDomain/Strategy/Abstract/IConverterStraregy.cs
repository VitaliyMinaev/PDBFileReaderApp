namespace FileReaderDomain.Strategy.Abstract;

public interface IConverterStraregy
{
    public Task<string> ConvertFromBinaryAsync(byte[] data);
}
