using GPSSabores.Communication.Requests;
using GPSSabores.Communication.Responses;

namespace GPSSabores.Application.UseCases.User.Register;
public interface IRegisterUserCase
{
    public Task<ResponseRegisterdUserJson> Execute(RequestRegisterUserJson request);
}
