using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using HulkOut.Interfaces.Incidents;
using HulkOut.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace HulkOut.Data.EF.Incidents
{
	/// <summary>
	///   S
	/// </summary>
	/// <seealso cref="HulkOut.Interfaces.Incidents.IIncidentTrackerLogRepository" />
	public class IncidentTrackerLogRepository : IIncidentTrackerLogRepository
	{
		/// <summary>
		///   Gets the specified filter.
		/// </summary>
		/// <param name="filter">The filter.</param>
		/// <returns></returns>
		public IEnumerable<IncidentTrackerLog> Get(Expression<Func<IncidentTrackerLog, bool>> filter)
		{
			using (var db = new HulkOutDbContext())
			{
				return db.IncidentTrackerLogs.Where(a => !a.IsDeleted).Where(filter).ToList();
			}
		}

		/// <summary>
		///   Inserts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		public IncidentTrackerLog Insert(IncidentTrackerLog model)
		{
			using (var db = new HulkOutDbContext())
			{
				db.IncidentTrackerLogs.Add(model);
				db.Entry(model).State = EntityState.Added;
				db.SaveChanges();

				return model;
			}
		}

		/// <summary>
		///   Updates the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		public IncidentTrackerLog Update(IncidentTrackerLog model)
		{
			using (var db = new HulkOutDbContext())
			{
				db.IncidentTrackerLogs.Add(model);
				db.Entry(model).State = EntityState.Modified;
				db.SaveChanges();

				return model;
			}
		}

		/// <summary>
		///   Deletes the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		public bool Delete(Guid id)
		{
			using (var db = new HulkOutDbContext())
			{
				var model = db.IncidentTrackerLogs.FirstOrDefault(a => a.Id == id);
				if (model == null) return false;

				model.IsDeleted = true;
				db.Entry(model).State = EntityState.Modified;
				db.SaveChanges();
				return true;
			}
		}
	}
}