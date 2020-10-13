using System;
using AndcultureCode.CSharp.Core.Interfaces;
using Core.Interfaces.Conductors;
using Core.Interfaces.Data;
using Core.Interfaces.Repositories;
using Infrastructure.Conductors;
using Infrastructure.PostgreSQL;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Presentation.Api.Extensions
{
    public static class IServiceCollecitonExtensions
    {
        public static IServiceCollection RegisterContexts(
            this IServiceCollection services, IConfigurationRoot configuration
        )
        {
            var connectionString = configuration["ConnectionStrings:ViniloContext"];

            services.AddDbContext<ViniloContext>(options => options.UseNpgsql(connectionString));
            services.AddScoped<IViniloContext, ViniloContext>();
            services.AddScoped<IContext, ViniloContext>();
            services.AddScoped<DbContext, ViniloContext>();

            return services;
        }

        public static IServiceCollection RegisterConductors(this IServiceCollection services)
        {
            services.AddScoped(typeof(IReadConductor<>), typeof(ReadConductor<>));
            services.AddScoped(typeof(ICreateConductor<>), typeof(CreateConductor<>));
            services.AddScoped(typeof(IFilterConductor<>), typeof(FilterConductor<>));

            return services;
        }

        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IReadRepository<>),   typeof(ReadRepository<>));
            services.AddScoped(typeof(ICreateRepository<>), typeof(CreateRepository<>));

            return services;
        }
    }
}
