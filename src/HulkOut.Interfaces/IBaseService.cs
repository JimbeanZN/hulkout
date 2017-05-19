using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using HulkOut.Models;

namespace HulkOut.Interfaces
{
	/// <summary>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IBaseService<T> where T : BaseModel
	{
		/// <summary>
		///   Gets the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		T Get(Guid id);

		/// <summary>
		///   Get all by the specified filter.
		/// </summary>
		/// <param name="filter">The filter.</param>
		/// <returns></returns>
		IEnumerable<T> GetAll(Expression<Func<T, bool>> filter);

		/// <summary>
		///   Inserts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		T Insert(T model);

		/// <summary>
		///   Updates the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		T Update(T model);

		/// <summary>
		///   Deletes the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		bool Delete(Guid id);
	}
}