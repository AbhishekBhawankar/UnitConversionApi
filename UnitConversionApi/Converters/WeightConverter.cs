namespace UnitConversionApi.Converters
{
    public class WeightConverter : IConverter
    {
        public string Category => "Weight";

        private readonly Dictionary<string, double> _units = new()
    {
        { "Kilogram", 1 },
        { "Pound", 2.20462 }
    };

        public double Convert(string fromUnit, string toUnit, double value)
        {
            var kgValue = value / _units[fromUnit];
            return kgValue * _units[toUnit];
        }
    }
}
