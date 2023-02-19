using ConvertProject.API.Model;
using Microsoft.AspNetCore.Mvc;

namespace ConvertProject.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        

        [HttpGet]
        [Route("/Test")]
        public string ReturnResponse()
        {
            return "Hello World!";
        }
    }
}