using GPSSabores.Application.Services.AutoMapper;
using GPSSabores.Application.Services.Cryptography;
using GPSSabores.Application.UseCases.User.Register;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GPSSabores.Application;
public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
    {

        AddPasswordEncrypter(services, configuration);
        AddAutoMapper(services);
        AddUseCases(services);

    }

    private static void AddAutoMapper(IServiceCollection services)
    {
        var autoMapper = new AutoMapper.MapperConfiguration(options =>
        {
            options.AddProfile(new AutoMapping());
        }).CreateMapper();
        services.AddScoped(option => autoMapper);
    }

    private static void AddUseCases(IServiceCollection services)
    {
        services.AddScoped<IRegisterUserCase, RegisterUserCase>();
    }

    private static void AddPasswordEncrypter(IServiceCollection services, IConfiguration configuration)
    {
        var additionalKey = configuration.GetValue<String>("Settings:Password:AdditionalKey");
        services.AddScoped(option => new PasswordEncripter(additionalKey!));
    }
}
