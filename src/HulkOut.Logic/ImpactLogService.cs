using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HulkOut.Shared.Interfaces.ImpactLogs;
using HulkOut.Shared.Models.Data;

namespace HulkOut.Logic
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="IImpactLogService" />
	public class ImpactLogService : IImpactLogService
	{
		private readonly IImpactLogRepository _impactLogRepository;

		public ImpactLogService(IImpactLogRepository impactLogRepository)
		{
			_impactLogRepository = impactLogRepository;
		}

		/// <summary>
		/// Gets the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		public async Task<ImpactLog> Get(Guid id)
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
		public async Task<IEnumerable<ImpactLog>> GetAll(Expression<Func<ImpactLog, bool>> filter)
		{
			if (filter == null)
				throw new ArgumentNullException(nameof(filter));

			return await _impactLogRepository.Get(filter);
		}

		/// <summary>
		/// Inserts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException">model</exception>
		public async Task<ImpactLog> Insert(ImpactLog model)
		{
			if (model == null)
				throw new ArgumentNullException(nameof(model));

			return await _impactLogRepository.Insert(model);
		}

		/// <summary>
		/// Updates the specified model.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException">model</exception>
		public async Task<ImpactLog> Update(Guid id, ImpactLog model)
		{
			if (model == null)
				throw new ArgumentNullException(nameof(model));

			return await _impactLogRepository.Update(id, model);
		}

		/// <summary>
		/// Deletes the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		public async Task<bool> Delete(Guid id)
		{
			return await _impactLogRepository.Delete(id);
		}
	}
}
