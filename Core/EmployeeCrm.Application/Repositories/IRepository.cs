using System;
using EmployeeCrm.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCrm.Application.Repositories
{
	public interface IRepository<T> where T : BaseEntity
	{
		DbSet<T> Table { get; }
    }
}

