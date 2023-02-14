using System;
using Book_store.Models;
using Microsoft.EntityFrameworkCore;
namespace Book_store.Data
{
	public class ApplicationDbContext :DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}


		public DbSet<Category> Categories { get; set; }
	}
}

