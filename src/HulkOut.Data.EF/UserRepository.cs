using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HulkOut.Shared.Interfaces.Users;
using HulkOut.Shared.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace HulkOut.Data.EF
{
	/// <summary>
	/// </summary>
	/// <seealso cref="IUserRepository" />
	public class UserRepository : IUserRepository
	{
		/// <summary>
		///   Gets the specified filter.
		/// </summary>
		/// <param name="filter">The filter.</param>
		/// <returns></returns>
		public async Task<IEnumerable<User>> Get(Expression<Func<User, bool>> filter)
		{
			using (var db = new HulkOutDbContext())
			{
				return await db.Users.Where(a => !a.IsDeleted).Where(filter).ToListAsync();
			}
		}

		/// <summary>
		///   Inserts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		public async Task<User> Insert(User model)
		{
			using (var db = new HulkOutDbContext())
			{
				db.Users.Add(model);
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
		public async Task<User> Update(User model)
		{
			using (var db = new HulkOutDbContext())
			{
				db.Users.Add(model);
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
				var model = await db.Users.FirstOrDefaultAsync(a => a.Id == id);
				if (model == null) return false;

				model.IsDeleted = true;
				db.Entry(model).State = EntityState.Modified;
				await db.SaveChangesAsync();
				return true;
			}
		}
	}
}