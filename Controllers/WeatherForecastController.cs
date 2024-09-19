using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet("DevolverAlumno")]
        public string DevolverAlumno()
        {
            string mensaje = string.Empty;
            Alumno Alumno1 = new Alumno();
            Alumno Alumno2 = new Alumno("Juan", "Perez", "4370258");
            return Alumno1.DevolverNombreCopleto();
        }

   
        [HttpGet("DevolverDocumento")]
        public string DevolverDocumento()
        {
            string mensaje = string.Empty;
            Alumno Alumno1 = new Alumno();
            Alumno Alumno2 = new Alumno("Juan", "Perez", "4370258");
            return Alumno2.DevolverDocumento();
        }

        
        [HttpGet("DevolverEdad")]
        public int DevolverEdad()
        {
            string mensaje = string.Empty;
            Alumno Alumno3 = new Alumno("Juan", "Perez", "4370258", new DateTime(2005, 1, 14));
            return Alumno3.DevolverEdad();
        }
    }

}
