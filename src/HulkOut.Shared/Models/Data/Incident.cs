using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using HulkOut.Utils.Extensions;

namespace HulkOut.Shared.Models.Data
{
	/// <summary>
	/// </summary>
	/// <seealso cref="BaseModel" />
	public class Incident : BaseModel
	{
		/// <summary>
		///   Gets or sets the Hulk identifier.
		/// </summary>
		/// <value>
		///   The Hulk identifier.
		/// </value>
		[ForeignKey("Hulk")]
		[Required]
		public Guid HulkId { get; set; }

		/// <summary>
		///   Gets or sets the incident.
		/// </summary>
		/// <value>
		///   The incident.
		/// </value>
		[NotMapped]
		public Hulk Hulk { get; set; }

		/// <summary>
		///   Gets or sets the logged by user identifier.
		/// </summary>
		/// <value>
		///   The logged by user identifier.
		/// </value>
		[ForeignKey("LoggedByUser")]
		[Required]
		public Guid LoggedByUserId { get; set; }

		/// <summary>
		///   Gets or sets the logged by user.
		/// </summary>
		/// <value>
		///   The logged by user.
		/// </value>
		public User LoggedByUser { get; set; }

		/// <summary>
		///   Gets or sets the impact logs.
		/// </summary>
		/// <value>
		///   The impact logs.
		/// </value>
		public virtual IEnumerable<ImpactLog> ImpactLogs { get; set; }

		/// <summary>
		///   Gets the impact count.
		/// </summary>
		/// <value>
		///   The impact count.
		/// </value>
		public int ImpactCount => ImpactLogs.IsNullOrEmpty() ? 0 : ImpactLogs.Count();
	}
}