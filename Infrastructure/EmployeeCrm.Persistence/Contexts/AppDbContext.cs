using System;
using EmployeeCrm.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCrm.Persistence.Contexts
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options)
		{
		}


		public DbSet<Event> Events { get; set; }
	}
}

