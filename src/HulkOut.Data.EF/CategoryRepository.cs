using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using HulkOut.Shared.Interfaces.Categories;
using HulkOut.Shared.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace HulkOut.Data.EF
{
	/// <summary>
	/// </summary>
	/// <seealso cref="ICategoryRepository" />
	public class CategoryRepository : ICategoryRepository
	{
		/// <summary>
		///   Gets the specified filter.
		/// </summary>
		/// <param name="filter">The filter.</param>
		/// <returns></returns>
		public IEnumerable<Category> Get(Expression<Func<Category, bool>> filter)
		{
			using (var db = new HulkOutDbContext())
			{
				return db.Categories.Where(a => !a.IsDeleted).Where(filter).ToList();
			}
		}

		/// <summary>
		///   Inserts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		public Category Insert(Category model)
		{
			using (var db = new HulkOutDbContext())
			{
				db.Categories.Add(model);
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
		public Category Update(Category model)
		{
			using (var db = new HulkOutDbContext())
			{
				db.Categories.Add(model);
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
				var model = db.Categories.FirstOrDefault(a => a.Id == id);
				if (model == null) return false;

				model.IsDeleted = true;
				db.Entry(model).State = EntityState.Modified;
				db.SaveChanges();
				return true;
			}
		}
	}
}