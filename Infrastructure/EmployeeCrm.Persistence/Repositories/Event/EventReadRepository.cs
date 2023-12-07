using System;
using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Domain.Entities;
using EmployeeCrm.Persistence.Contexts;

namespace EmployeeCrm.Persistence.Repositories
{
    public class EventReadRepository : ReadRepository<Event>, IEventReadRepository
    {
        public EventReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}

