namespace UnitConversionApi.Converters
{
    public class TemperatureConverter : IConverter
    {
        public string Category => "Temperature";

        public double Convert(string fromUnit, string toUnit, double value)
        {
            if (fromUnit == "Celsius" && toUnit == "Fahrenheit")
                return (value * 9 / 5) + 32;

            if (fromUnit == "Fahrenheit" && toUnit == "Celsius")
                return (value - 32) * 5 / 9;

            return value;
        }
    }
}
