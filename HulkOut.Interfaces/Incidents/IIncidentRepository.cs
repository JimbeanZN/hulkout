﻿using HulkOut.Core.Interfaces;
using HulkOut.Models.Data;

namespace HulkOut.Interfaces.Incidents
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HulkOut.Core.Interfaces.IBaseRepository{HulkOut.Models.Data.Incident}" />
	public interface IIncidentRepository : IBaseRepository<Incident>
	{ 
	}
}