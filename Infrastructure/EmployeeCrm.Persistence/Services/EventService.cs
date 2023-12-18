using System;
using System.Linq;
using AutoMapper;
using EmployeeCrm.Application.Abstraction;
using EmployeeCrm.Application.DTOs.EventDTOs;
using EmployeeCrm.Application.Exceptions.EventException;
using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Application.Responses;
using EmployeeCrm.Domain.Entities;
using FluentValidation;

namespace EmployeeCrm.Persistence.Services
{
    public class EventService : IEventService
    {
        private readonly IEventReadRepository _readRepository;
        private readonly IEventWriteRepository _eventWrite;
        private readonly IMapper _mapper;
        private readonly IValidator<EventCreateDTO> _eventValidator;
        public EventService(IEventReadRepository readRepository, IEventWriteRepository eventWrite, IMapper mapper, IValidator<EventCreateDTO> eventValidator)
        {
            _readRepository = readRepository;
            _eventWrite = eventWrite;
            _mapper = mapper;
            _eventValidator = eventValidator;
        }


        public async Task<Result> CreateEvent(EventCreateDTO eventCreate)
        {
            var newEvent = _mapper.Map<Event>(eventCreate);

            var validation = _eventValidator.Validate(eventCreate);

            if (!validation.IsValid)
            {
                return new Result(false, validation.Errors.Select(x=>x.ErrorMessage).ToList());
            }
        
            await _eventWrite.AddAsync(newEvent);

            var res = await _eventWrite.SaveAsync();
            return new Result(true,"Elave oludu");
        }

        public List<EventDTO> GetEvents()
        {
            var events = _readRepository.GetAll();
            if (!events.Any()) throw new EventNotFoundException();
            var map = _mapper.Map<List<EventDTO>>(events);
            return map;
        }

        
    }
}

