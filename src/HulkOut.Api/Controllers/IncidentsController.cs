using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HulkOut.Shared.Interfaces.Incidents;
using HulkOut.Shared.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace HulkOut.Api.Controllers
{
	[Produces("application/json")]
	[Route("api/[controller]")]
	public class IncidentsController : Controller
	{
		private readonly IIncidentService _incidentService;

		public IncidentsController(IIncidentService incidentService)
		{
			_incidentService = incidentService;
		}

		// GET api/incidents
		[HttpGet]
		public async Task<IEnumerable<Incident>> Get()
		{
			return await _incidentService.GetAll(null);
		}

		// GET api/incidents/63AAB81D-3EB5-4564-849A-28260B523FE4
		[HttpGet("{id}")]
		public async Task<Incident> Get(Guid id)
		{
			return await _incidentService.Get(id);
		}

		// POST api/incidents
		[HttpPost]
		public async void Post([FromBody] Incident model)
		{
			await _incidentService.Insert(model);
		}

		// PUT api/incidents/63AAB81D-3EB5-4564-849A-28260B523FE4
		[HttpPut("{id}")]
		public async void Put(Guid id, [FromBody] Incident model)
		{
			await _incidentService.Update(id, model);
		}

		// DELETE api/incidents/63AAB81D-3EB5-4564-849A-28260B523FE4
		[HttpDelete("{id}")]
		public async void Delete(Guid id)
		{
			await _incidentService.Delete(id);
		}
	}
}