using System.Threading;
using Microsoft.AspNetCore.Mvc;

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
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		IActionResult Get(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Gets the specified instance.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		IActionResult Get(TId id, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Posts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		IActionResult Post(TModel model, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Updates the specified model.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <param name="model">The model.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		IActionResult Put(TId id, TModel model, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Deletes the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		IActionResult Delete(TId model, CancellationToken cancellationToken = default(CancellationToken));
	}
}
