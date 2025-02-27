using Microsoft.AspNetCore.Mvc;
using BussinessLayer.Service;

namespace HelloApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloAppController : ControllerBase
    {
        RegisterHelloBL _registerHelloBL;
        public HelloAppController(RegisterHelloBL registerHelloBL) 
        {
            _registerHelloBL = registerHelloBL;
        }

        [HttpGet]
        public string Get()
        {
            return  _registerHelloBL.registration("Value from Controller");
        }

        [HttpGet]
        [Route("second")]
        public string Get1()
        {
            return "Second Get Method";
        }
    }
}
