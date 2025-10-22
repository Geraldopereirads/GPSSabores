using GPSSabores.Application.UseCases.User.Register;
using GPSSabores.Communication.Requests;
using GPSSabores.Communication.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GPSSabores.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterdUserJson), StatusCodes.Status201Created)]
        public async Task<IActionResult> Register(
            [FromServices] IRegisterUserCase useCase,
           [FromBody] RequestRegisterUserJson request)
        {

            var result = await useCase.Execute(request);
            return Created(string.Empty, result);
        }
    }
}
