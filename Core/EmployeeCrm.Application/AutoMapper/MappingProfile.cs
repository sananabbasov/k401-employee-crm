using System;
using AutoMapper;
using EmployeeCrm.Application.DTOs.EventDTOs;
using EmployeeCrm.Domain.Entities;

namespace EmployeeCrm.Application.AutoMapper
{
	public class MappingProfile : Profile
	{

		public MappingProfile()
		{
			CreateMap<Event, EventCreateDTO>().ReverseMap();
			CreateMap<Event, EventDTO>().ReverseMap();
        }
	}
}

