using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {

        [HttpGet]
        public string Message()
        {
            return "Hello, World!";
        }


    }
}
