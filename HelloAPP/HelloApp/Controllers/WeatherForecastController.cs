using Microsoft.AspNetCore.Mvc;
using BussinessLayer.Service;
using ModelLayer.DTO;

namespace HelloApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloAppController : ControllerBase
    {
        RegisterHelloBL _registerHelloBL;
        ResponseModel<String> response;
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
        [HttpPost]
        public IActionResult PostData(LoginDTO login) {
            try
            {
                bool result = _registerHelloBL.loginUser(login);
                response = new ResponseModel<String>();
                if (result)
                {
                    response.Success = true;
                    response.Message = "Login Sucessfully.";
                    response.Data = login.username;
                    return Ok(response);
                }
                response.Success = false;
                response.Message = "Login Failed.";
                response.Data = "";
                return NotFound(response);
            }
            catch 
            { 
                response.Success = false;
                response.Message = "";
                response.Data = response.Message;
                return BadRequest(response);
            }
        }
    }
}
