using System;
using System.Collections.Generic;
using System.Web.Http;
using HulkOut.Interfaces.Incidents;
using HulkOut.Models.Data;

namespace HulkOut.Api.Controllers
{
	public class IncidentController : ApiController
	{
		private readonly IIncidentService _incidentService;

		public IncidentController(IIncidentService incidentService)
		{
			_incidentService = incidentService;
		}

		[Route("incidents/")]
		[HttpGet]
		public IEnumerable<Incident> Get()
		{
			return _incidentService.GetAll(a => true);
		}

		[Route("incidents/{id:guid}")]
		[HttpGet]
		public Incident Get(Guid id)
		{
			return _incidentService.Get(id);
		}

		[Route("incidents")]
		[HttpPost]
		public void Post([FromBody] Incident value)
		{
		}

		[Route("incidents/{id:guid}")]
		[HttpPut]
		public void Put(Guid id, [FromBody] Incident value)
		{
		}

		[Route("incidents/{id:guid}")]
		[HttpDelete]
		public void Delete(Guid id)
		{
		}
	}
}