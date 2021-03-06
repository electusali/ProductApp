using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Persistence.Context;
using ProductApp.Persistence.Repositories;

namespace ProductApp.Persistence
{
	public static class ServiceRegistration
	{
		public static void AddPersistenceSerives(this IServiceCollection serviceCollection)
		{
			serviceCollection.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("memoryDb"));
			serviceCollection.AddTransient<IProductRepository, ProductRepository>();
		}
	}
}
