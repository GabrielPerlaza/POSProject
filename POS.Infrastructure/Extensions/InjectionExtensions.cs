﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using POS.Domain.Entities;
using POS.Infrastructure.Persistences.Interfaces;
using POS.Infrastructure.Persistences.Repositories;

namespace POS.Infrastructure.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(PosContext).Assembly.FullName;

            services.AddDbContext<PosContext>(
                options => options.UseSqlServer(
                    configuration.GetConnectionString("POSConnection"), b => b.MigrationsAssembly(assembly)), ServiceLifetime.Transient
                );
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;

        }
    }
}
