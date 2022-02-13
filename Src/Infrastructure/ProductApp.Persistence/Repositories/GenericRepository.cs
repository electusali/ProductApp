using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Domain.Common;
using ProductApp.Persistence.Context;

namespace ProductApp.Persistence.Repositories
{
	public class GenericRepository<T> : IGenericRepositoryAsync<T> where  T:BaseEntitiy
	{
		private readonly ApplicationDbContext _dbContext;

		public GenericRepository(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public async Task<T> AddAsync(T entitiy)
		{
			await _dbContext.Set<T>().AddRangeAsync(entitiy);
			await _dbContext.SaveChangesAsync();
			return entitiy;
		}

		public async Task<List<T>> GetAllAsync()
		{
			return await _dbContext.Set<T>().ToListAsync();
		}

		public async Task<T> GetById(Guid id)
		{
			return await _dbContext.Set<T>().FindAsync(id);
		}
	}
}
