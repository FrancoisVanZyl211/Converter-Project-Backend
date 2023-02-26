using ConvertProject.API.Model;
using ConvertProject.Logic;
using Microsoft.AspNetCore.Mvc;

namespace ConvertProject.API.Controllers
{
    [ApiController]
    [Route("")]     
    public class ConversionController : ControllerBase 
    {
        

        [HttpGet]
        [Route("/conversion/ConvertCToF/{Unit}")]
        public string ReturnResponse(double Unit)
        {
            return ConversionLogic.ConvertCtoF(Unit).ToString();             
        }
    }
}