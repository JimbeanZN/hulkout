using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HulkOut.Core.Models;

namespace HulkOut.Models.Data
{
	/// <summary>
	/// </summary>
	/// <seealso cref="BaseModel" />
	public class IncidentTrackerLog : BaseModel
	{
		/// <summary>
		///   Gets or sets the incident tracker identifier.
		/// </summary>
		/// <value>
		///   The incident tracker identifier.
		/// </value>
		[ForeignKey("IncidentTracker")]
		[Required]
		public Guid IncidentTrackerId { get; set; }

		/// <summary>
		///   Gets or sets the incident tracker.
		/// </summary>
		/// <value>
		///   The incident tracker.
		/// </value>
		public IncidentTracker IncidentTracker { get; set; }
	}
}