using System.Collections.Generic;
using System.Threading;

namespace HulkOut.Interfaces
{
	/// <summary>
	/// An interface that can be used to baseline CRUD repositories.
	/// </summary>
	/// <typeparam name="T">The type of the model.</typeparam>
	/// <typeparam name="TId">The type of the Id identifier.</typeparam>
	public interface IBaseCrudRepository<T, in TId>
	{
		/// <summary>
		/// Get all instances.
		/// </summary>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		IEnumerable<T> Get(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Gets the specified instance.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		T Get(TId id, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Posts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		T Post(T model, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Updates the specified model.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <param name="model">The model.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		void Put(TId id, T model, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Deletes the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		void Delete(TId model, CancellationToken cancellationToken = default(CancellationToken));
	}
}
