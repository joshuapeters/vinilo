using Core.Interfaces.Data;
using Infrastructure.PostgreSQL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Presentation.Api.Extensions
{
    public static class IServiceCollecitonExtensions
    {
        public static IServiceCollection RegisterContexts(
            this IServiceCollection services, IConfigurationRoot configuration, string environmentName = "Development"
        )
        {
            var connectionString = configuration["ConnectionStrings:ViniloContext"];

            services.AddEntityFrameworkNpgsql().AddScoped<IViniloContext>((sp) => new ViniloContext(connectionString));

            return services;
        }
    }
}
