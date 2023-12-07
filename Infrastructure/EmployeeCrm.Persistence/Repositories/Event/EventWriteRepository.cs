using System;
using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Domain.Entities;
using EmployeeCrm.Persistence.Contexts;

namespace EmployeeCrm.Persistence.Repositories
{
    public class EventWriteRepository : WriteRepository<Event>, IEventWriteRepository
    {
        public EventWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}

