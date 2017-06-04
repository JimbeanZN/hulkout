namespace HulkOut.Shared.Models.Data
{
	/// <summary>
	/// </summary>
	/// <seealso cref="BaseModel" />
	public class User : BaseModel
	{
		/// <summary>
		///   Gets or sets the first name.
		/// </summary>
		/// <value>
		///   The first name.
		/// </value>
		public string FirstName { get; set; }

		/// <summary>
		///   Gets or sets the surname.
		/// </summary>
		/// <value>
		///   The surname.
		/// </value>
		public string Surname { get; set; }

		/// <summary>
		///   Gets or sets the email address.
		/// </summary>
		/// <value>
		///   The email address.
		/// </value>
		public string EmailAddress { get; set; }

		/// <summary>
		///   Gets or sets the username.
		/// </summary>
		/// <value>
		///   The username.
		/// </value>
		public string Username { get; set; }
	}
}