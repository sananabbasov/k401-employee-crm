﻿using System;
using System.Linq.Expressions;
using EmployeeCrm.Domain.Entities.Common;

namespace EmployeeCrm.Application.Repositories
{
	public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
	{
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetByIdAsync(int id, bool tracking = true);
    }
}

