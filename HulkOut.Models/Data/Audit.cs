using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HulkOut.Models.Enums.AuditEnums;

namespace HulkOut.Models.Data
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HulkOut.Models.BaseModel" />
	[Table("Log", Schema = "Audit")]
	public class Audit : BaseModel
	{
		/// <summary>
		/// Gets or sets the entity.
		/// </summary>
		/// <value>
		/// The entity.
		/// </value>
		[Required]
		public string Entity { get; set; }

		/// <summary>
		/// Gets or sets the entity identifier.
		/// </summary>
		/// <value>
		/// The entity identifier.
		/// </value>
		[Required]
		public Guid EntityId { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>
		/// The description.
		/// </value>
		[Required]
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the audit action.
		/// </summary>
		/// <value>
		/// The audit action.
		/// </value>
		[Required]
		public int AuditAction { get; set; }

		/// <summary>
		/// Gets the audit description.
		/// </summary>
		/// <value>
		/// The audit description.
		/// </value>
		[NotMapped]
		public string AuditDescription
		{
			get
			{
				return ((AuditAction)AuditAction).ToString();
			}
		}

		/// <summary>
		/// Gets or sets the original json.
		/// </summary>
		/// <value>
		/// The original json.
		/// </value>
		public string OriginalJson { get; set; }

		/// <summary>
		/// Gets or sets the new json.
		/// </summary>
		/// <value>
		/// The new json.
		/// </value>
		public string NewJson { get; set; }
	}
}
