namespace FileReaderDomain.Strategy.Abstract;

public interface IConverterStraregy
{
    public string ConvertFromBinary(byte[] data);
}
