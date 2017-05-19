namespace HulkOut.Interfaces
{
	/// <summary>
	/// </summary>
	public interface ICacheService
	{
		/// <summary>
		///   Gets the specified key.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="key">The key.</param>
		/// <returns></returns>
		T Get<T>(string key);

		/// <summary>
		///   Sets the specified key.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="key">The key.</param>
		/// <param name="value">The value.</param>
		/// <returns></returns>
		T Set<T>(string key, T value);

		/// <summary>
		///   Deletes the specified key.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <returns></returns>
		bool Delete(string key);

		/// <summary>
		///   Checks the existance of the specified key.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <returns></returns>
		bool Exists(string key);
	}
}