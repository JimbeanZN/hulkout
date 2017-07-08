using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HulkOut.Shared.Interfaces.Hulk;
using HulkOut.Shared.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace HulkOut.Api.Controllers
{
	[Produces("application/json")]
	[Route("api/[controller]")]
	public class HulksController : Controller
	{
		private readonly IHulkService _hulkService;

		public HulksController(IHulkService hulkService)
		{
			_hulkService = hulkService;
		}

		// GET api/hulks
		[HttpGet]
		public async Task<IEnumerable<Hulk>> Get()
		{
			return await _hulkService.GetAll(null);
		}

		// GET api/hulks/63AAB81D-3EB5-4564-849A-28260B523FE4
		[HttpGet("{id}")]
		public async Task<Hulk> Get(Guid id)
		{
			return await _hulkService.Get(id);
		}

		// POST api/hulks
		[HttpPost]
		public async void Post([FromBody] Hulk model)
		{
			await _hulkService.Insert(model);
		}

		// PUT api/hulks/63AAB81D-3EB5-4564-849A-28260B523FE4
		[HttpPut("{id}")]
		public async void Put(Guid id, [FromBody] Hulk model)
		{
			await _hulkService.Update(id, model);
		}

		// DELETE api/hulks/63AAB81D-3EB5-4564-849A-28260B523FE4
		[HttpDelete("{id}")]
		public async void Delete(Guid id)
		{
			await _hulkService.Delete(id);
		}
	}
}