using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;

namespace HulkOut.Interfaces
{
	/// <summary>
	/// An interface that can be used to baseline API CRUD repositories.
	/// </summary>
	/// <typeparam name="T">The type of the model.</typeparam>
	/// <typeparam name="TId">The type of the Id identifier.</typeparam>
	public interface IBaseApiCrudRepository<T, in TId>
	{
		/// <summary>
		/// Get all instances.
		/// </summary>
		/// <returns></returns>
		IEnumerable<T> Get();

		/// <summary>
		/// Gets the specified instance.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		T Get(TId id);

		/// <summary>
		/// Posts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		T Post(T model);

		/// <summary>
		/// Updates the specified model.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		void Put(TId id, T model);

		/// <summary>
		/// Deletes the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		void Delete(TId model);
	}
}
