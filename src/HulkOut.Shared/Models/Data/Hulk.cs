﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HulkOut.Shared.Models.Data
{
	/// <summary>
	/// </summary>
	/// <seealso cref="BaseModel" />
	public class Hulk : BaseModel
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
		///   Gets or sets the category identifier.
		/// </summary>
		/// <value>
		///   The category identifier.
		/// </value>
		[ForeignKey("Category")]
		[Required]
		public Guid CategoryId { get; set; }

		/// <summary>
		///   Gets or sets the category of Hulk this is.
		/// </summary>
		/// <value>
		///   The Hulk category.
		/// </value>
		public Category Category { get; set; }

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
		///   Gets or sets the incidents.
		/// </summary>
		/// <value>
		///   The incidents.
		/// </value>
		public virtual IEnumerable<Incident> Incidents { get; set; }
	}
}