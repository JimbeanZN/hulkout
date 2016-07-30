using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using HulkOut.Core.Models;

namespace HulkOut.Core.Interfaces
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IBaseRepository<T> where T : BaseModel
	{
		/// <summary>
		/// Gets the specified filter.
		/// </summary>
		/// <param name="filter">The filter.</param>
		/// <returns></returns>
		IEnumerable<T> Get(Expression<Func<T, bool>> filter);

		/// <summary>
		/// Inserts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		T Insert(T model);

		/// <summary>
		/// Updates the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		T Update(T model);

		/// <summary>
		/// Deletes the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		bool Delete(Guid id);
	}
}
