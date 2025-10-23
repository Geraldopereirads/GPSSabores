using CommonTestUtilities.Cryptography;
using CommonTestUtilities.Mapper;
using CommonTestUtilities.Repositories;
using CommonTestUtilities.Requests;
using FluentAssertions;
using GPSSabores.Application.UseCases.User.Register;

namespace UseCases.Test.User.Register;
public class RegisterUserCaseTest
{
    [Fact]
    public async Task Success()
    {
        var request = RequestRegisterUserJsonBuilder.Build();

        var useCase = CreateUseCase();

        var result = await useCase.Execute(request);

        result.Should().NotBeNull();
        result.Name.Should().Be(request.Name);
    }

    private RegisterUserCase CreateUseCase()
    {
        var mapper = MapperBuilder.Build();
        var PasswordEncripter = PasswordEncrypterBuilder.Build();
        var writeRepository = UserWriteOnlyRepositoryBuilder.Build();
        var unitOfWork = UnitOfWorkBuilder.Build();
        var readRepository = new UserReadOnlyRepositoryBuilder().Build();
        return new RegisterUserCase(writeRepository, readRepository, PasswordEncripter, mapper, unitOfWork);
    }
}
