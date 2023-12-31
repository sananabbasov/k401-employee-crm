﻿using System;
using EmployeeCrm.Application.Abstraction;
using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Persistence.Contexts;
using EmployeeCrm.Persistence.Repositories;
using EmployeeCrm.Persistence.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeCrm.Persistence
{
	public static class ServiceRegistration
    {
		public static void AddPersistenceServices(this IServiceCollection services)
        {

            services.AddDbContext<AppDbContext>(option => option.UseNpgsql(Configuration.ConnectionString));


            services.AddScoped<IEventReadRepository, EventReadRepository>();
            services.AddScoped<IEventWriteRepository, EventWriteRepository>();

            services.AddScoped<IEventService, EventService>();

        }
    }
}

