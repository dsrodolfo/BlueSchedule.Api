using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BlueSchedule.Application.Installers
{
    public static class MediatRInstaller
    {
        public static IServiceCollection AddMediatRServices(this IServiceCollection services)
        {
            var applicationAssembly = Assembly.Load("BlueSchedule.Application");
            services.AddMediatR(applicationAssembly);

            return services;
        }
    }
}