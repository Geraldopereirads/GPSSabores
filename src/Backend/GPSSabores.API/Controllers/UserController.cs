using GPSSabores.Communication.Requests;
using GPSSabores.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GPSSabores.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterdUserJson), StatusCodes.Status201Created)]
        public IActionResult Register(RequestRegisterUserJson request)
        {
            return Created();
        }
    }
}
