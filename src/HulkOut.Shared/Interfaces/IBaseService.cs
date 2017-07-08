using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HulkOut.Shared.Models;

namespace HulkOut.Shared.Interfaces
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
		Task<T> Get(Guid id);

		/// <summary>
		///   Get all by the specified filter.
		/// </summary>
		/// <param name="filter">The filter.</param>
		/// <returns></returns>
		Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter);

		/// <summary>
		///   Inserts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		Task<T> Insert(T model);

		/// <summary>
		///   Updates the specified model.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		Task<T> Update(Guid id, T model);

		/// <summary>
		///   Deletes the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		Task<bool> Delete(Guid id);
	}
}