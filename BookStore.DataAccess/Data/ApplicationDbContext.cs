using System;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataAcess
{
	public class ApplicationDbContext :DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}


		public DbSet<Category> Categories { get; set; }
        public DbSet<CoverType> CoverTypes { get; set; }
    }
}

