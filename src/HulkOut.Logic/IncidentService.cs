using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HulkOut.Shared.Interfaces.Incidents;
using HulkOut.Shared.Models.Data;

namespace HulkOut.Logic
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="IIncidentService" />
	public class IncidentService : IIncidentService
	{
		private readonly IIncidentRepository _incidentRepository;

		public IncidentService(IIncidentRepository incidentRepository)
		{
			_incidentRepository = incidentRepository;
		}

		/// <summary>
		/// Gets the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		public async Task<Incident> Get(Guid id)
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
		public async Task<IEnumerable<Incident>> GetAll(Expression<Func<Incident, bool>> filter)
		{
			if (filter == null)
				throw new ArgumentNullException(nameof(filter));

			return await _incidentRepository.Get(filter);
		}

		/// <summary>
		/// Inserts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException">model</exception>
		public async Task<Incident> Insert(Incident model)
		{
			if (model == null)
				throw new ArgumentNullException(nameof(model));

			return await _incidentRepository.Insert(model);
		}

		/// <summary>
		/// Updates the specified model.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException">model</exception>
		public async Task<Incident> Update(Guid id, Incident model)
		{
			if (model == null)
				throw new ArgumentNullException(nameof(model));

			return await _incidentRepository.Update(id, model);
		}

		/// <summary>
		/// Deletes the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		public async Task<bool> Delete(Guid id)
		{
			return await _incidentRepository.Delete(id);
		}
	}
}
