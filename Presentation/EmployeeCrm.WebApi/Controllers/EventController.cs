using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeCrm.Application.Abstraction;
using EmployeeCrm.Application.DTOs.EventDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeCrm.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {

        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateEvent([FromBody] EventCreateDTO eventCreate)
        {
            var res = await _eventService.CreateEvent(eventCreate);
            return Ok(res);
        }

        [HttpGet("events")]
        [Authorize]
        public async Task<IActionResult> GetAllEvents()
        {
            var result =  _eventService.GetEvents();
            return Ok(result);
        }
    }
}

