﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductApp.Domain.Common;

namespace ProductApp.Application.Interfaces.Repository
{
	public interface IGenericRepositoryAsync<T> where T:BaseEntitiy
	{
		Task<List<T>> GetAllAsync();
		Task<T> GetById(Guid id);
		Task<T> AddAsync(T entitiy);
	}
}
