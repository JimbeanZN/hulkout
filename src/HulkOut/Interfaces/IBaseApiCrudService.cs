using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;

namespace HulkOut.Interfaces
{
	/// <summary>
	/// An interface that can be used to baseline API CRUD services.
	/// </summary>
	/// <typeparam name="TId">The type of the Id identifier.</typeparam>
	/// <typeparam name="TModel">The type of the model.</typeparam>
	public interface IBaseApiCrudService<in TId, in TModel>
	{
		/// <summary>
		/// Get all instances.
		/// </summary>
		/// <returns></returns>
		IHttpActionResult Get();

		/// <summary>
		/// Gets the specified instance.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		IHttpActionResult Get(TId id);

		/// <summary>
		/// Posts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		IHttpActionResult Post(TModel model);

		/// <summary>
		/// Updates the specified model.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		IHttpActionResult Put(TId id, TModel model);

		/// <summary>
		/// Deletes the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		IHttpActionResult Delete(TId model);
	}
}
