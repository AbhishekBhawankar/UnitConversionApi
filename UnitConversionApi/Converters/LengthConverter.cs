namespace UnitConversionApi.Converters
{
    public class LengthConverter : IConverter
    {
        public string Category => "Length";

        private readonly Dictionary<string, double> _units = new()
            {
                { "Meter", 1 },
                { "Feet", 3.28084 },
                { "Kilometer", 0.001 }
            };

        public double Convert(string fromUnit, string toUnit, double value)
        {
            if (!_units.ContainsKey(fromUnit) ||
                !_units.ContainsKey(toUnit))
            {
                throw new Exception("Invalid unit.");
            }

            var meterValue = value / _units[fromUnit];
            return meterValue * _units[toUnit];
        }
    }
}