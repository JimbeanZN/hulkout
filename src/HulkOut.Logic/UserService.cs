using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HulkOut.Shared.Interfaces.Users;
using HulkOut.Shared.Models.Data;

namespace HulkOut.Logic
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="IUserService" />
	public class UserService : IUserService
	{
		private readonly IUserRepository _userRepository;

		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		/// <summary>
		/// Gets the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		public async Task<User> Get(Guid id)
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
		public async Task<IEnumerable<User>> GetAll(Expression<Func<User, bool>> filter)
		{
			if (filter == null)
				throw new ArgumentNullException(nameof(filter));

			return await _userRepository.Get(filter);
		}

		/// <summary>
		/// Inserts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException">model</exception>
		public async Task<User> Insert(User model)
		{
			if (model == null)
				throw new ArgumentNullException(nameof(model));

			return await _userRepository.Insert(model);
		}

		/// <summary>
		/// Updates the specified model.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException">model</exception>
		public async Task<User> Update(Guid id, User model)
		{
			if (model == null)
				throw new ArgumentNullException(nameof(model));

			return await _userRepository.Update(id, model);
		}

		/// <summary>
		/// Deletes the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		public async Task<bool> Delete(Guid id)
		{
			return await _userRepository.Delete(id);
		}
	}
}
