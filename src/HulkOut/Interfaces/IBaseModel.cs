using System;
using System.ComponentModel.DataAnnotations;

namespace HulkOut.Interfaces
{
	/// <summary>
	/// An interface that can be used to baseline persistable models.
	/// </summary>
	/// <typeparam name="TId">The type of the Id identifier.</typeparam>
	/// <typeparam name="TCreatedBy">The type of the created by identifier.</typeparam>
	/// <typeparam name="TLastUpdatedBy">The type of the last updated by identifier.</typeparam>
	public interface IBaseModel<TId, TCreatedBy, TLastUpdatedBy>
	{
		/// <summary>
		///   Gets or sets the identifier.
		/// </summary>
		/// <value>
		///   The identifier.
		/// </value>
		[Key]
		TId Id { get; set; }

		/// <summary>
		///   Gets or sets the created date.
		/// </summary>
		/// <value>
		///   The created date.
		/// </value>
		[Required]
		DateTime CreatedDate { get; set; }

		/// <summary>
		///   Gets or sets the created by user identifier.
		/// </summary>
		/// <value>
		///   The created by user identifier.
		/// </value>
		[Required]
		TCreatedBy CreatedBy { get; set; }

		/// <summary>
		///   Gets or sets the last updated date.
		/// </summary>
		/// <value>
		///   The last updated date.
		/// </value>
		[Required]
		DateTime LastUpdatedDate { get; set; }

		/// <summary>
		///   Gets or sets the last updated by user identifier.
		/// </summary>
		/// <value>
		///   The last updated by user identifier.
		/// </value>
		[Required]
		TLastUpdatedBy LastUpdatedBy { get; set; }

		/// <summary>
		///   Gets or sets a value indicating whether this instance is deleted.
		/// </summary>
		/// <value>
		///   <c>true</c> if this instance is deleted; otherwise, <c>false</c>.
		/// </value>
		[Required]
		bool IsDeleted { get; set; }
	}
}