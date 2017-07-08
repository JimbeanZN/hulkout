using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HulkOut.Shared.Interfaces.Hulk;
using HulkOut.Shared.Interfaces.ImpactLogs;
using HulkOut.Shared.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace HulkOut.Api.Controllers
{
	[Produces("application/json")]
	[Route("api/[controller]")]
	public class ImpactLogsController : Controller
	{
		private readonly IImpactLogService _impactLogService;

		public ImpactLogsController(IImpactLogService impactLogService)
		{
			_impactLogService = impactLogService;
		}

		// GET api/impactlogs
		[HttpGet]
		public async Task<IEnumerable<ImpactLog>> Get()
		{
			return await _impactLogService.GetAll(null);
		}

		// GET api/impactlogs/63AAB81D-3EB5-4564-849A-28260B523FE4
		[HttpGet("{id}")]
		public async Task<ImpactLog> Get(Guid id)
		{
			return await _impactLogService.Get(id);
		}

		// POST api/impactlogs
		[HttpPost]
		public async void Post([FromBody] ImpactLog model)
		{
			await _impactLogService.Insert(model);
		}

		// PUT api/impactlogs/63AAB81D-3EB5-4564-849A-28260B523FE4
		[HttpPut("{id}")]
		public async void Put(Guid id, [FromBody] ImpactLog model)
		{
			await _impactLogService.Update(id, model);
		}

		// DELETE api/impactlogs/63AAB81D-3EB5-4564-849A-28260B523FE4
		[HttpDelete("{id}")]
		public async void Delete(Guid id)
		{
			await _impactLogService.Delete(id);
		}
	}
}