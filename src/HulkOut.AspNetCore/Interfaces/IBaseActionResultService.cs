using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HulkOut.AspNetCore.Interfaces
{
	/// <summary>
	/// An interface that can be used to baseline API CRUD services returning an ActionResult.
	/// </summary>
	/// <typeparam name="TId">The type of the Id identifier.</typeparam>
	/// <typeparam name="TModel">The type of the model.</typeparam>
	public interface IBaseActionResultService<in TId, in TModel>
	{
	  #region Get
	  /// <summary>
	  /// Get all instances.
	  /// </summary>
	  IActionResult Get();
	  /// <summary>
	  /// Get all instances.
	  /// </summary>
	  Task<IActionResult> GetAsync();
	  /// <summary>
	  /// Get all instances.
	  /// <param name="cancellationToken">The cancellation token.</param>
	  /// </summary>
	  Task<IActionResult> GetAsync(CancellationToken cancellationToken);
	  /// <summary>
	  /// Get all instances.
	  /// <param name="progress">The task progress.</param>
	  /// </summary>
	  Task<IActionResult> GetAsync(IProgress<IActionResult> progress);
	  /// <summary>
	  /// Get all instances.
	  /// <param name="cancellationToken">The cancellation token.</param>
	  /// <param name="progress">The task progress.</param>
	  /// </summary>
	  Task<IActionResult> GetAsync(CancellationToken cancellationToken, IProgress<IActionResult> progress);

		/// <summary>
		/// Gets the specified instance.
		/// </summary>
		/// <param name="id">The identifier.</param>
		IActionResult Get(TId id);
	  /// <summary>
	  /// Gets the specified instance.
	  /// </summary>
	  /// <param name="id">The identifier.</param>
	  Task<IActionResult> GetAsync(TId id);
	  /// <summary>
	  /// Gets the specified instance.
	  /// </summary>
	  /// <param name="id">The identifier.</param>
	  /// <param name="cancellationToken">The cancellation token.</param>
	  Task<IActionResult> GetAsync(TId id, CancellationToken cancellationToken);
	  /// <summary>
	  /// Gets the specified instance.
	  /// </summary>
	  /// <param name="id">The identifier.</param>
	  /// <param name="progress">The task progress.</param>
	  Task<IActionResult> GetAsync(TId id, IProgress<IActionResult> progress);
	  /// <summary>
	  /// Gets the specified instance.
	  /// </summary>
	  /// <param name="id">The identifier.</param>
	  /// <param name="cancellationToken">The cancellation token.</param>
	  /// <param name="progress">The task progress.</param>
	  Task<IActionResult> GetAsync(TId id, CancellationToken cancellationToken, IProgress<IActionResult> progress);
	  #endregion

	  #region Post
	  /// <summary>
	  /// Posts the specified model.
	  /// </summary>
	  /// <param name="model">The model.</param>
	  IActionResult Post(TModel model);
	  /// <summary>
	  /// Posts the specified model.
	  /// </summary>
	  /// <param name="model">The model.</param>
	  Task<IActionResult> PostAsync(TModel model);
	  /// <summary>
	  /// Posts the specified model.
	  /// </summary>
	  /// <param name="model">The model.</param>
	  /// <param name="cancellationToken">The cancellation token.</param>
	  Task<IActionResult> PostAsync(TModel model, CancellationToken cancellationToken);
	  /// <summary>
	  /// Posts the specified model.
	  /// </summary>
	  /// <param name="model">The model.</param>
	  /// <param name="progress">The task progress.</param>
	  Task<IActionResult> PostAsync(TModel model, IProgress<IActionResult> progress);
	  /// <summary>
	  /// Posts the specified model.
	  /// </summary>
	  /// <param name="model">The model.</param>
	  /// <param name="cancellationToken">The cancellation token.</param>
	  /// <param name="progress">The task progress.</param>
    Task<IActionResult> PostAsync(TModel model, CancellationToken cancellationToken, IProgress<IActionResult> progress);
	  #endregion

    #region Put
		/// <summary>
		/// Updates the specified model.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <param name="model">The model.</param>
		IActionResult Put(TId id, TModel model);
	  /// <summary>
	  /// Updates the specified model.
	  /// </summary>
	  /// <param name="id">The identifier.</param>
	  /// <param name="model">The model.</param>
	  Task<IActionResult> PutAsync(TId id,TModel model);
	  /// <summary>
	  /// Updates the specified model.
	  /// </summary>
	  /// <param name="id">The identifier.</param>
	  /// <param name="model">The model.</param>
	  /// <param name="cancellationToken">The cancellation token.</param>
	  Task<IActionResult> PutAsync(TId id,TModel model, CancellationToken cancellationToken);
	  /// <summary>
	  /// Updates the specified model.
	  /// </summary>
	  /// <param name="id">The identifier.</param>
	  /// <param name="model">The model.</param>
	  /// <param name="progress">The task progress.</param>
	  Task<IActionResult> PutAsync(TId id,TModel model, IProgress<IActionResult> progress);
	  /// <summary>
	  /// Updates the specified model.
	  /// </summary>
	  /// <param name="id">The identifier.</param>
	  /// <param name="model">The model.</param>
	  /// <param name="cancellationToken">The cancellation token.</param>
	  /// <param name="progress">The task progress.</param>
	  Task<IActionResult> PutAsync(TId id,TModel model, CancellationToken cancellationToken, IProgress<IActionResult> progress);
	  #endregion

    #region Delete
		/// <summary>
		/// Deletes the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		IActionResult Delete(TId model);
	  /// <summary>
	  /// Deletes the specified model.
	  /// </summary>
	  /// <param name="model">The model.</param>
	  Task<IActionResult> DeleteAsync(TModel model);
	  /// <summary>
	  /// Deletes the specified model.
	  /// </summary>
	  /// <param name="model">The model.</param>
	  /// <param name="cancellationToken">The cancellation token.</param>
	  Task<IActionResult> DeleteAsync(TModel model, CancellationToken cancellationToken);
	  /// <summary>
	  /// Deletes the specified model.
	  /// </summary>
	  /// <param name="model">The model.</param>
	  /// <param name="progress">The task progress.</param>
	  Task<IActionResult> DeleteAsync(TModel model, IProgress<IActionResult> progress);
	  /// <summary>
	  /// Deletes the specified model.
	  /// </summary>
	  /// <param name="model">The model.</param>
	  /// <param name="cancellationToken">The cancellation token.</param>
	  /// <param name="progress">The task progress.</param>
	  Task<IActionResult> DeleteAsync(TModel model, CancellationToken cancellationToken, IProgress<IActionResult> progress);
	  #endregion
	}
}
