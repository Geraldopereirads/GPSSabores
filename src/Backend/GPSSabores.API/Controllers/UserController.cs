using GPSSabores.Application.UseCases.User.Register;
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
        public IActionResult Register(
            [FromServices] IRegisterUserCase useCase,
           [FromBody] RequestRegisterUserJson request)
        {

            var result = useCase.Execute(request);
            return Created(string.Empty, result);
        }
    }
}
