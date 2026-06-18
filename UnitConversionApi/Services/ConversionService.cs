using UnitConversionApi.Converters;

namespace UnitConversionApi.Services
{
    public class ConversionService : IConversionService
    {
        private readonly IEnumerable<IConverter> _converters;

        public ConversionService(IEnumerable<IConverter> converters)
        {
            _converters = converters;
        }

        public double Convert(string category,
                              string fromUnit,
                              string toUnit,
                              double value)
        {
            var converter = _converters.FirstOrDefault(x =>
                x.Category.Equals(category,
                StringComparison.OrdinalIgnoreCase));

            if (converter == null)
                throw new Exception("Unsupported category");

            return converter.Convert(fromUnit, toUnit, value);
        }
    }
}
