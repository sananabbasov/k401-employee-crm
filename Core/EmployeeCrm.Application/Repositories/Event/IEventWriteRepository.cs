using System;
using EmployeeCrm.Domain.Entities;

namespace EmployeeCrm.Application.Repositories
{
	public interface IEventWriteRepository : IWriteRepository<Event>
	{
	}
}

