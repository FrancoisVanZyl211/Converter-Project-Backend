using ConvertProject.Logic;
using Microsoft.AspNetCore.Mvc;

namespace ConvertProject.API.Controllers
{
    [ApiController]
    [Route("")]     
    public class ConversionController : ControllerBase 
    {
        [HttpGet]
        [Route("/conversion/ConvertCToF/{Celcius}")]
        public string ReturnCtoF(double Celcius)
        {
            return ConversionLogic.ConvertCtoF(Celcius).ToString();
        }

        [HttpGet]
        [Route("/conversion/ConvertFToC/{Fahrenheit}")]
        public string ReturnFtoC(double Fahrenheit)
        {
            return ConversionLogic.ConvertFtoC(Fahrenheit).ToString();
        }
    }
}
