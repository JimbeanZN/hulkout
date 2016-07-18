using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HulkOut.Models.Data
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HulkOut.Models.BaseModel" />
	public class Timer : BaseModel
	{
		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>
		/// The title.
		/// </value>
		public string Title { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>
		/// The description.
		/// </value>
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the owner user identifier.
		/// </summary>
		/// <value>
		/// The owner user identifier.
		/// </value>
		[ForeignKey("OwnerUserEntity")]
		public Guid OwnerUserId { get; set; }

		/// <summary>
		/// Gets or sets the owner user entity.
		/// </summary>
		/// <value>
		/// The owner user entity.
		/// </value>
		public User OwnerUserEntity { get; set; }

		/// <summary>
		/// Gets or sets the category identifier.
		/// </summary>
		/// <value>
		/// The category identifier.
		/// </value>
		[ForeignKey("Category")]
		public Guid CategoryId { get; set; }

		/// <summary>
		/// Gets or sets the category entity.
		/// </summary>
		/// <value>
		/// The category entity.
		/// </value>
		public Category CategoryEntity { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance can cooldown automatically.
		/// </summary>
		/// <value>
		/// <c>true</c> if this instance can cooldown automatically; otherwise, <c>false</c>.
		/// </value>
		public bool CanCooldownAutomatically { get; set; }

		/// <summary>
		/// Gets or sets the automatic cooldown period.
		/// </summary>
		/// <value>
		/// The automatic cooldown period.
		/// </value>
		public TimeSpan? AutomaticCooldownPeriod { get; set; }
	}
}
