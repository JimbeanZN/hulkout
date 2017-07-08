using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HulkOut.Shared.Interfaces.Incidents;
using HulkOut.Shared.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace HulkOut.Data.EF
{
	/// <summary>
	/// </summary>
	/// <seealso cref="IIncidentRepository" />
	public class IncidentRepository : IIncidentRepository
	{
		/// <summary>
		///   Gets the specified filter.
		/// </summary>
		/// <param name="filter">The filter.</param>
		/// <returns></returns>
		public async Task<IEnumerable<Incident>> Get(Expression<Func<Incident, bool>> filter)
		{
			using (var db = new HulkOutDbContext())
			{
				return await db.Incidents.Where(a => !a.IsDeleted).Where(filter).ToListAsync();
			}
		}

		/// <summary>
		///   Inserts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		public async Task<Incident> Insert(Incident model)
		{
			using (var db = new HulkOutDbContext())
			{
				db.Incidents.Add(model);
				db.Entry(model).State = EntityState.Added;
				await db.SaveChangesAsync();

				return model;
			}
		}

		/// <summary>
		///   Updates the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		public async Task<Incident> Update(Incident model)
		{
			using (var db = new HulkOutDbContext())
			{
				db.Incidents.Add(model);
				db.Entry(model).State = EntityState.Modified;
				await db.SaveChangesAsync();

				return model;
			}
		}

		/// <summary>
		///   Deletes the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		public async Task<bool> Delete(Guid id)
		{
			using (var db = new HulkOutDbContext())
			{
				var model = await db.Incidents.FirstOrDefaultAsync(a => a.Id == id);
				if (model == null) return false;

				model.IsDeleted = true;
				db.Entry(model).State = EntityState.Modified;
				await db.SaveChangesAsync();
				return true;
			}
		}
	}
}