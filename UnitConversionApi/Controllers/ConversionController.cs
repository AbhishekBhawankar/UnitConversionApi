using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitConversionApi.Models;
using UnitConversionApi.Services;

namespace UnitConversionApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConversionController : ControllerBase
    {
        private readonly IConversionService _service;

        public ConversionController(IConversionService service)
        {
            _service = service;
        }

        [HttpPost("convert")]
        public IActionResult Convert([FromBody] ConversionRequest request)
        {
            if (request.Value < 0)
                return BadRequest("Value cannot be negative.");

            var result = _service.Convert(
                request.Category,
                request.FromUnit,
                request.ToUnit,
                request.Value);

            return Ok(new ConversionResponse
            {
                OriginalValue = request.Value,
                FromUnit = request.FromUnit,
                ToUnit = request.ToUnit,
                ConvertedValue = result
            });
        }
    }
}
