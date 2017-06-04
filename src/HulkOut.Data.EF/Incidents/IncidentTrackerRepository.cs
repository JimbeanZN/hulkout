using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using HulkOut.Shared.Interfaces.Incidents;
using HulkOut.Shared.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace HulkOut.Data.EF.Incidents
{
	/// <summary>
	/// </summary>
	/// <seealso cref="IIncidentTrackerRepository" />
	public class IncidentTrackerRepository : IIncidentTrackerRepository
	{
		/// <summary>
		///   Gets the specified filter.
		/// </summary>
		/// <param name="filter">The filter.</param>
		/// <returns></returns>
		public IEnumerable<IncidentTracker> Get(Expression<Func<IncidentTracker, bool>> filter)
		{
			using (var db = new HulkOutDbContext())
			{
				return db.IncidentTrackers.Where(a => !a.IsDeleted).Where(filter).ToList();
			}
		}

		/// <summary>
		///   Inserts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		public IncidentTracker Insert(IncidentTracker model)
		{
			using (var db = new HulkOutDbContext())
			{
				db.IncidentTrackers.Add(model);
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
		public IncidentTracker Update(IncidentTracker model)
		{
			using (var db = new HulkOutDbContext())
			{
				db.IncidentTrackers.Add(model);
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
				var model = db.IncidentTrackers.FirstOrDefault(a => a.Id == id);
				if (model == null) return false;

				model.IsDeleted = true;
				db.Entry(model).State = EntityState.Modified;
				db.SaveChanges();
				return true;
			}
		}
	}
}