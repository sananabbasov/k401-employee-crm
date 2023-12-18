using System;
using EmployeeCrm.Application.DTOs.EventDTOs;
using EmployeeCrm.Application.Responses;

namespace EmployeeCrm.Application.Abstraction
{
	public interface IEventService
	{
		Task<Result> CreateEvent(EventCreateDTO eventCreate);
		List<EventDTO> GetEvents();
	}
}

