using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using HulkOut.Shared.Interfaces.ImpactLogs;
using HulkOut.Shared.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace HulkOut.Data.EF
{
	/// <summary>
	///   S
	/// </summary>
	/// <seealso cref="IImpactLogRepository" />
	public class ImpactLogRepository : IImpactLogRepository
	{
		/// <summary>
		///   Gets the specified filter.
		/// </summary>
		/// <param name="filter">The filter.</param>
		/// <returns></returns>
		public IEnumerable<ImpactLog> Get(Expression<Func<ImpactLog, bool>> filter)
		{
			using (var db = new HulkOutDbContext())
			{
				return db.ImpactLogs.Where(a => !a.IsDeleted).Where(filter).ToList();
			}
		}

		/// <summary>
		///   Inserts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		public ImpactLog Insert(ImpactLog model)
		{
			using (var db = new HulkOutDbContext())
			{
				db.ImpactLogs.Add(model);
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
		public ImpactLog Update(ImpactLog model)
		{
			using (var db = new HulkOutDbContext())
			{
				db.ImpactLogs.Add(model);
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
				var model = db.ImpactLogs.FirstOrDefault(a => a.Id == id);
				if (model == null) return false;

				model.IsDeleted = true;
				db.Entry(model).State = EntityState.Modified;
				db.SaveChanges();
				return true;
			}
		}
	}
}