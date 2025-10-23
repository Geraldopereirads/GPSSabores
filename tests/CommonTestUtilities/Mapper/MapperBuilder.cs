using AutoMapper;
using GPSSabores.Application.Services.AutoMapper;
using Microsoft.Extensions.Logging.Abstractions;

namespace CommonTestUtilities.Mapper;

public static class MapperBuilder
{
    public static IMapper Build()
    {
        var configExpression = new MapperConfigurationExpression();
        configExpression.AddProfile(new AutoMapping());

        
        var configuration = new MapperConfiguration(configExpression, new NullLoggerFactory());

        return configuration.CreateMapper();
    }
}
