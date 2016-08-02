using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using HulkOut.Interfaces.Incidents;
using HulkOut.Models.Data;

namespace HulkOut.Data.EF.Incidents
{
	/// <summary>
	/// </summary>
	/// <seealso cref="HulkOut.Interfaces.Incidents.IIncidentRepository" />
	public class IncidentRepository : IIncidentRepository
	{
		/// <summary>
		///   Gets the specified filter.
		/// </summary>
		/// <param name="filter">The filter.</param>
		/// <returns></returns>
		public IEnumerable<Incident> Get(Expression<Func<Incident, bool>> filter)
		{
			using (var db = new HulkOutDbContext())
			{
				return db.Incidents.Where(a => !a.IsDeleted).Where(filter).ToList();
			}
		}

		/// <summary>
		///   Inserts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		public Incident Insert(Incident model)
		{
			using (var db = new HulkOutDbContext())
			{
				db.Incidents.Add(model);
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
		public Incident Update(Incident model)
		{
			using (var db = new HulkOutDbContext())
			{
				db.Incidents.Add(model);
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
				var model = db.Incidents.FirstOrDefault(a => a.Id == id);
				if (model == null) return false;

				model.IsDeleted = true;
				db.Entry(model).State = EntityState.Modified;
				db.SaveChanges();
				return true;
			}
		}
	}
}