namespace UnitConversionApi.Converters
{
    public interface IConverter
    {
        string Category { get; }
        double Convert(string fromUnit, string toUnit, double value);
    }
}
