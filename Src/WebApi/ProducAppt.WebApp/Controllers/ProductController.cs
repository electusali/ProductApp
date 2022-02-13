using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductApp.Application;
using ProductApp.Application.Interfaces.Repository;

namespace ProducAppt.WebApp.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductRepository _productRepository;

		public ProductController(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		[HttpGet]
		public async Task<IActionResult> GetProduct()
		{
			var allist = await _productRepository.GetAllAsync();
			var result = allist.Select(x => new ProductViewDto()
			{
				Id = x.Id,
				Name = x.Name
			}).ToList();
			return Ok(result);
		}
	}
}
