using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HulkOut.Shared.Interfaces.Categories;
using HulkOut.Shared.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace HulkOut.Api.Controllers
{
	[Produces("application/json")]
	[Route("api/[controller]")]
	public class CategoriesController : Controller
	{
		private readonly ICategoryService _hulkService;

		public CategoriesController(ICategoryService hulkService)
		{
			_hulkService = hulkService;
		}

		// GET api/categories
		[HttpGet]
		public async Task<IEnumerable<Category>> Get()
		{
			return await _hulkService.GetAll(null);
		}

		// GET api/categories/63AAB81D-3EB5-4564-849A-28260B523FE4
		[HttpGet("{id}")]
		public async Task<Category> Get(Guid id)
		{
			return await _hulkService.Get(id);
		}

		// POST api/categories
		[HttpPost]
		public async void Post([FromBody] Category model)
		{
			await _hulkService.Insert(model);
		}

		// PUT api/categories/63AAB81D-3EB5-4564-849A-28260B523FE4
		[HttpPut("{id}")]
		public async void Put(Guid id, [FromBody] Category model)
		{
			await _hulkService.Update(id, model);
		}

		// DELETE api/categories/63AAB81D-3EB5-4564-849A-28260B523FE4
		[HttpDelete("{id}")]
		public async void Delete(Guid id)
		{
			await _hulkService.Delete(id);
		}
	}
}