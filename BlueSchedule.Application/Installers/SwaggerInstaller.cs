using Microsoft.Extensions.DependencyInjection;

namespace BlueSchedule.Application.Installers
{
    public static class SwaggerInstaller
    {
        public static IServiceCollection AddSwaggerServices(this IServiceCollection services)
        {
            services.AddSwaggerGen();

            return services;
        }
    }
}