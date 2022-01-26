using AutoMapper;
using BlueSchedule.Application.Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace BlueSchedule.Application.Installers
{
    public static class AutoMapperInstaller
    {
        public static IServiceCollection AddAutoMapperServices(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ItemProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}