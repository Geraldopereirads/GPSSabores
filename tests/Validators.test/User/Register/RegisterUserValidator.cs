using CommonTestUtilities.Requests;
using GPSSabores.Application.UseCases.User.Register;
using GPSSabores.Exceptions;

namespace Validators.test.User.Register;
public class RegisterUserValidatorTest
{
    [Fact]
    public void Sucess()
    {
        var validator = new RegisterUserValidator();

        var request = RequestRegisterUserJsonBuilder.Build();

        var result = validator.Validate(request);


        Assert.True(result.IsValid);
    }

    [Fact]
    public void Error_Name_Empty()
    {
        var validator = new RegisterUserValidator();

        var request = RequestRegisterUserJsonBuilder.Build();
        request.Name = string.Empty;

        var result = validator.Validate(request);


        Assert.False(result.IsValid);
        var error = Assert.Single(result.Errors);
        Assert.Equal(ResourceMessagesException.NAME_EMPTY, error.ErrorMessage);
    }


    [Fact]
    public void Error_Email_Empty()
    {
        var validator = new RegisterUserValidator();

        var request = RequestRegisterUserJsonBuilder.Build();
        request.Email = string.Empty;

        var result = validator.Validate(request);


        Assert.False(result.IsValid);
        var error = Assert.Single(result.Errors);
        Assert.Equal(ResourceMessagesException.EMAIL_EMPTY, error.ErrorMessage);
    }

    [Fact]
    public void Error_Email_Invalid()
    {
        var validator = new RegisterUserValidator();

        var request = RequestRegisterUserJsonBuilder.Build();
        request.Email = "email.com";

        var result = validator.Validate(request);


        Assert.False(result.IsValid);
        var error = Assert.Single(result.Errors);
        Assert.Equal(ResourceMessagesException.EMAIL_INVALID, error.ErrorMessage);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    public void Error_Password_Invalid(int passwordLength)
    {
        var validator = new RegisterUserValidator();

        var request = RequestRegisterUserJsonBuilder.Build(passwordLength);

        var result = validator.Validate(request);


        Assert.False(result.IsValid);
        var error = Assert.Single(result.Errors);
        Assert.Equal(ResourceMessagesException.PASSWORD_TOO_SHORT, error.ErrorMessage);
    }

}
