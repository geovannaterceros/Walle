using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Wall_E.Helpers;
using Serilog;

namespace Wall_E.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILoggerWalle _logger;

        public WeatherForecastController(ILoggerWalle logger)
        {
            _logger = logger;
        }

       

        [HttpGet]
        public IActionResult ElectricPlants() 
        {
            var numberRandon = new Random();
  
            Log.Debug("Iniciando logger");
            for (var i = 0; i < 20; i++) {
                Int32 numero = numberRandon.Next(1, 100);
                if (numero < 30)
                {
                    Log.Error($"Nivel de energia ha bajado {numero}");
                }
                else
                {
                    Log.Debug($"Nivel de energia esta normal {numero}");
                }
            }
            return Ok("version");
        }
    }
}
