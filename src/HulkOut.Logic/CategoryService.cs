using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
		private readonly ICategoryRepository _categoryRepository;

		public CategoryService(ICategoryRepository categoryRepository)
		{
			_categoryRepository = categoryRepository;
		}

		/// <summary>
		/// Gets the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		public async Task<Category> Get(Guid id)
		{
			var result = await GetAll(model => model.Id == id);	
			return result.FirstOrDefault();
		}

		/// <summary>
		/// Gets all.
		/// </summary>
		/// <param name="filter">The filter.</param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException">filter</exception>
		public async Task<IEnumerable<Category>> GetAll(Expression<Func<Category, bool>> filter)
		{
			if (filter == null)
				throw new ArgumentNullException(nameof(filter));

			return await _categoryRepository.Get(filter);
		}

		/// <summary>
		/// Inserts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException">model</exception>
		public async Task<Category> Insert(Category model)
		{
			if (model == null)
				throw new ArgumentNullException(nameof(model));

			return await _categoryRepository.Insert(model);
		}

		/// <summary>
		/// Updates the specified model.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException">model</exception>
		public async Task<Category> Update(Guid id, Category model)
		{
			if (model == null)
				throw new ArgumentNullException(nameof(model));

			return await _categoryRepository.Update(id, model);
		}

		/// <summary>
		/// Deletes the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		public async Task<bool> Delete(Guid id)
		{
			return await _categoryRepository.Delete(id);
		}
	}
}
