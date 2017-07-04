using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HulkOut.Shared.Models.Data
{
	/// <summary>
	/// </summary>
	/// <seealso cref="BaseModel" />
	public class ImpactLog : BaseModel
	{
		/// <summary>
		///   Gets or sets the incident identifier.
		/// </summary>
		/// <value>
		///   The incident identifier.
		/// </value>
		[ForeignKey("Incident")]
		[Required]
		public Guid IncidentId { get; set; }

		/// <summary>
		///   Gets or sets the incident.
		/// </summary>
		/// <value>
		///   The incident.
		/// </value>
		public Incident Incident { get; set; }
	}
}