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

		[HttpGet]
		public IEnumerable<Incident> Get()
		{
			return _incidentService.GetAll(a => true);
		}

		[HttpGet]
		public Incident Get(Guid id)
		{
			return _incidentService.Get(id);
		}

		[HttpPost]
		public void Post([FromBody] Incident value)
		{
		}

		[HttpPut]
		public void Put(Guid id, [FromBody] Incident value)
		{
		}

		[HttpDelete]
		public void Delete(Guid id)
		{
		}
	}
}