using CoderSquare.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoderSquare.DataAccess.DIContainer;

public static class DataBaseContainer
{
    public static IServiceCollection AddDatabase(this IServiceCollection service,
        IConfiguration configuration)
    {
        service.AddDbContext<AppDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("Def"));
        });

        return service;
    }
}