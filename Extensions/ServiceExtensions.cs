using Contracts;
using LoggerService;

namespace egolfWebApi.Extensions;

public static class ServiceExtensions
{
    //configure CORS policy
    public static void ConfigureCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("_myAllowSpecificOrigins", policy =>
            {
                policy.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });
    }

    //configure IIS integration 
    public static void ConfigureIISIntegration(this IServiceCollection services)
    {
        services.Configure<IISOptions>(options =>
        {
            // options.ForwardClientCertificate = false;
        });
    }


    //configure logger service
    public static void ConfigureLoggerService(this IServiceCollection services)
    {
        services.AddSingleton<ILoggerManager, LoggerManager>();
    }
}