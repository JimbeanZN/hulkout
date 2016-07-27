using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HulkOut.Models.Data
{
	/// <summary>
	/// </summary>
	/// <seealso cref="HulkOut.Models.BaseModel" />
	public class Incident : BaseModel
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

		/// <summary>
		///   Gets or sets the owner user identifier.
		/// </summary>
		/// <value>
		///   The owner user identifier.
		/// </value>
		[ForeignKey("OwnerUserEntity")]
		[Required]
		public Guid OwnerUserId { get; set; }

		/// <summary>
		///   Gets or sets the owner user entity.
		/// </summary>
		/// <value>
		///   The owner user entity.
		/// </value>
		public User OwnerUserEntity { get; set; }

		/// <summary>
		///   Gets or sets the incident category identifier.
		/// </summary>
		/// <value>
		///   The incident category identifier.
		/// </value>
		[ForeignKey("IncidentCategory")]
		[Required]
		public Guid IncidentCategoryId { get; set; }

		/// <summary>
		///   Gets or sets the incident category.
		/// </summary>
		/// <value>
		///   The incident category.
		/// </value>
		public IncidentCategory IncidentCategory { get; set; }

		/// <summary>
		///   Gets or sets a value indicating whether this instance can cooldown automatically.
		/// </summary>
		/// <value>
		///   <c>true</c> if this instance can cooldown automatically; otherwise, <c>false</c>.
		/// </value>
		[Required]
		public bool CanCooldownAutomatically { get; set; }

		/// <summary>
		///   Gets or sets the automatic cooldown period.
		/// </summary>
		/// <value>
		///   The automatic cooldown period.
		/// </value>
		public TimeSpan? AutomaticCooldownPeriod { get; set; }

		/// <summary>
		///   Gets or sets the logs.
		/// </summary>
		/// <value>
		///   The logs.
		/// </value>
		public virtual IEnumerable<IncidentTracker> Logs { get; set; }
	}
}