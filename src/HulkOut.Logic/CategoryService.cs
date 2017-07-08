using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HulkOut.Shared.Interfaces.Categories;
using HulkOut.Shared.Models.Data;

namespace HulkOut.Logic
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HulkOut.Shared.Interfaces.Categories.ICategoryService" />
	public class CategoryService : ICategoryService
	{
		/// <summary>
		/// Gets the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public Category Get(Guid id)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Gets all.
		/// </summary>
		/// <param name="filter">The filter.</param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException">filter</exception>
		/// <exception cref="NotImplementedException"></exception>
		public IEnumerable<Category> GetAll(Expression<Func<Category, bool>> filter)
		{
			if (filter == null)
				throw new ArgumentNullException(nameof(filter));

			throw new NotImplementedException();
		}

		/// <summary>
		/// Inserts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public Category Insert(Category model)
		{
			if (model == null)
				throw new ArgumentNullException(nameof(model));

			throw new NotImplementedException();
		}

		/// <summary>
		/// Updates the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public Category Update(Category model)
		{
			if (model == null)
				throw new ArgumentNullException(nameof(model));

			throw new NotImplementedException();
		}

		/// <summary>
		/// Deletes the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public bool Delete(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}
