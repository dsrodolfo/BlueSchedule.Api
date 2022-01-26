using BlueSchedule.Infrastructure.Interfaces;
using BlueSchedule.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BlueSchedule.Application.Installers
{
    public static class RepositoryInstaller
    {
        public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
        {
            services.AddTransient<IItemRepository, ItemRepository>();

            return services;
        }
    }
}