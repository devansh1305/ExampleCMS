using System;
using ExampleCMS.Models;
using Microsoft.EntityFrameworkCore;

namespace ExampleCMS.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		public DbSet<Category> Categories { get; set; }
	}
}

