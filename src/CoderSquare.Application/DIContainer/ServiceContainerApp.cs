using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoderSquare.Application.DIContainer;

public static class ServiceContainerApp
{
    public static IServiceCollection AddServiceApp(this IServiceCollection service,
        IConfiguration configuration)
    {
        // AddService Container

        return service;
    }

    public static IServiceCollection AddLogException(this IServiceCollection service)
    {
        // Service Container 


        return service;
    }
}