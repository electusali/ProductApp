using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Entities;

namespace ProductApp.Persistence.Context
{
	public class ApplicationDbContext :DbContext
	{
		public DbSet<Product> Products { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
				new Product() {Id = Guid.NewGuid(),Name = "Pen",Value = 10, Type = 100},
				new Product() { Id = Guid.NewGuid(), Name = "Paper A4", Value = 20, Type = 200 },
				new Product() { Id = Guid.NewGuid(), Name = "Bok", Value = 30, Type = 500 }
			);
			base.OnModelCreating(modelBuilder);
		}
	}
}
