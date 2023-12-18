using System;
using AutoMapper;
using EmployeeCrm.Application.AutoMapper;
using EmployeeCrm.Application.DTOs.EventDTOs;
using EmployeeCrm.Application.Validations.EventValidation;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeCrm.Application.DependencyResolver
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);


            services.AddScoped<IValidator<EventCreateDTO>, RegisterEventValidation>();
        }
    }
}

