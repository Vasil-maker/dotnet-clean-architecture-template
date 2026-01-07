using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection; 
 
 
namespace Capi.API;
 
public static class DependencyInjection
{
    // Два метода расширения 1-ый метод для регистрации сервисов 2-ой для конвигурации приложения

    public static IServiceCollection AddApiServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }
        
    public static WebApplication UseApiServices(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();
          
        app.MapGet("/", () => "Hello World!");

        return app;
    }

      
}