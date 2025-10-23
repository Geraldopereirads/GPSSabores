using AutoMapper;
using GPSSabores.Application.Services.Cryptography;
using GPSSabores.Communication.Requests;
using GPSSabores.Communication.Responses;
using GPSSabores.Domain.Repositories;
using GPSSabores.Domain.Repositories.User;
using GPSSabores.Exceptions;
using GPSSabores.Exceptions.ExceptionsBase;

namespace GPSSabores.Application.UseCases.User.Register;

public class RegisterUserCase : IRegisterUserCase
{

    private readonly IUserWriteOnlyRepository _userWriteOnlyRepository;
    private readonly IUserReadOnlyRepository _userReadOnlyRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly PasswordEncripter _passwordEncripter;
    private IUserWriteOnlyRepository writeRepository;
    private IUserReadOnlyRepository readRepository;
    private IUnitOfWork unitOfWork;
    private PasswordEncripter passwordEncripter;
    private IMapper mapper;

    public RegisterUserCase(
        IUserWriteOnlyRepository userWriteOnlyRepository,
        IUserReadOnlyRepository userReadOnlyRepository,
        PasswordEncripter passwordEncripter,
        IMapper mapper,
        IUnitOfWork unitOfWork

        )
    {
        _userWriteOnlyRepository = userWriteOnlyRepository;
        _userReadOnlyRepository = userReadOnlyRepository;
        _mapper = mapper;
        _passwordEncripter = passwordEncripter;
        _unitOfWork = unitOfWork;
    }



    async public Task<ResponseRegisterdUserJson> Execute(RequestRegisterUserJson request)
    {




        await Validate(request);

        var user = _mapper.Map<Domain.Entities.User>(request);

        user.Password = _passwordEncripter.Encrypt(request.Password); 


        await _userWriteOnlyRepository.Add(user);

        await _unitOfWork.Commit();

        return new ResponseRegisterdUserJson
        {
            Name = request.Name,
        };
    }

    private async Task Validate(RequestRegisterUserJson request)
    {
        var validator = new RegisterUserValidator();
        var result = validator.Validate(request);

        var emailExist = await _userReadOnlyRepository.ExistActiveUserWithEmail(request.Email);

        if (emailExist)
        {
            result.Errors.Add(new FluentValidation.Results.ValidationFailure(string.Empty, ResourceMessagesException.EMAIL_ALREADY_REGISTERED));
        }

        if (result.IsValid == false)
        {
            var errorMessagens = result.Errors.Select(e => e.ErrorMessage).ToList();

            throw new ErrorOnValidationException(errorMessagens);
        }
    }
}



