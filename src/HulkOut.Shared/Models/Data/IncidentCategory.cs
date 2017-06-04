using System.ComponentModel.DataAnnotations;

namespace HulkOut.Shared.Models.Data
{
	/// <summary>
	/// </summary>
	/// <seealso cref="BaseModel" />
	public class IncidentCategory : BaseModel
	{
		/// <summary>
		///   Gets or sets the title.
		/// </summary>
		/// <value>
		///   The title.
		/// </value>
		[Required]
		public string Title { get; set; }

		/// <summary>
		///   Gets or sets the description.
		/// </summary>
		/// <value>
		///   The description.
		/// </value>
		public string Description { get; set; }
	}
}