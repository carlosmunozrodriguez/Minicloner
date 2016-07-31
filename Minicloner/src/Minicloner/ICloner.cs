namespace Minicloner
{
    public interface ICloner
    {
        T Clone<T>(T source);
    }
}