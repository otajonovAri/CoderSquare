using CoderSquare.Application.MappingProfiles;
using CoderSquare.Application.Service.ProblemServices;
using CoderSquare.Application.Service.TypeServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoderSquare.Application.DIContainer;

public static class ServiceContainerApp
{
    public static IServiceCollection AddServiceApp(this IServiceCollection service,
        IConfiguration configuration)
    {
        // AddService Container
        service.AddScoped<IProblemService, ProblemService>();
        service.AddScoped<ITypeService, TypeService>();

        return service;
    }

    // Service Container 
    public static IServiceCollection AddLogException(this IServiceCollection service)
    {


        return service;
    }
}