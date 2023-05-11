using hello_Webapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace hello_Webapi.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController :ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessage()
        {
            var result=  new ResponseModel()
            { HttpStatus = 200 , Message="Hello ASP.Net Core Web API" };
            return Ok(result);
        }
    }
}
