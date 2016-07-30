using System;
using System.ComponentModel.DataAnnotations;

namespace HulkOut.Core.Models
{
	/// <summary>
	/// </summary>
	public abstract class BaseModel
	{
		/// <summary>
		///   Gets or sets the identifier.
		/// </summary>
		/// <value>
		///   The identifier.
		/// </value>
		[Key]
		public Guid Id { get; set; }

		/// <summary>
		///   Gets or sets the created date.
		/// </summary>
		/// <value>
		///   The created date.
		/// </value>
		[Required]
		public DateTime CreatedDate { get; set; }

		/// <summary>
		///   Gets or sets the created by user identifier.
		/// </summary>
		/// <value>
		///   The created by user identifier.
		/// </value>
		[Required]
		public Guid CreatedByUserId { get; set; }

		/// <summary>
		///   Gets or sets the last updated date.
		/// </summary>
		/// <value>
		///   The last updated date.
		/// </value>
		[Required]
		public DateTime LastUpdatedDate { get; set; }

		/// <summary>
		///   Gets or sets the last updated by user identifier.
		/// </summary>
		/// <value>
		///   The last updated by user identifier.
		/// </value>
		[Required]
		public Guid LastUpdatedByUserId { get; set; }

		/// <summary>
		///   Gets or sets a value indicating whether this instance is deleted.
		/// </summary>
		/// <value>
		///   <c>true</c> if this instance is deleted; otherwise, <c>false</c>.
		/// </value>
		[Required]
		public bool IsDeleted { get; set; }
	}
}