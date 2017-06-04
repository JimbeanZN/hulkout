using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HulkOut.Shared.Models.Enums;

namespace HulkOut.Shared.Models.Data
{
	/// <summary>
	/// </summary>
	/// <seealso cref="BaseModel" />
	public class Audit : BaseModel
	{
		/// <summary>
		///   Gets or sets the entity.
		/// </summary>
		/// <value>
		///   The entity.
		/// </value>
		[Required]
		public string Entity { get; set; }

		/// <summary>
		///   Gets or sets the entity identifier.
		/// </summary>
		/// <value>
		///   The entity identifier.
		/// </value>
		[Required]
		public Guid EntityId { get; set; }

		/// <summary>
		///   Gets or sets the description.
		/// </summary>
		/// <value>
		///   The description.
		/// </value>
		[Required]
		public string Description { get; set; }

		/// <summary>
		///   Gets or sets the audit action.
		/// </summary>
		/// <value>
		///   The audit action.
		/// </value>
		[Required]
		public int AuditAction { get; set; }

		/// <summary>
		///   Gets the audit description.
		/// </summary>
		/// <value>
		///   The audit description.
		/// </value>
		[NotMapped]
		public string AuditDescription => ((AuditEnums.AuditAction) AuditAction).ToString();

		/// <summary>
		///   Gets or sets the original json.
		/// </summary>
		/// <value>
		///   The original json.
		/// </value>
		public string OriginalJson { get; set; }

		/// <summary>
		///   Gets or sets the new json.
		/// </summary>
		/// <value>
		///   The new json.
		/// </value>
		public string NewJson { get; set; }
	}
}