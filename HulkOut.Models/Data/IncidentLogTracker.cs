using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HulkOut.Models.Data
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HulkOut.Models.BaseModel" />
	public class IncidentLogTracker : BaseModel
	{
		/// <summary>
		/// Gets or sets the incident log identifier.
		/// </summary>
		/// <value>
		/// The incident log identifier.
		/// </value>
		[ForeignKey("IncidentLog")]
		[Required]
		public Guid IncidentLogId { get; set; }

		/// <summary>
		/// Gets or sets the incident log.
		/// </summary>
		/// <value>
		/// The incident log.
		/// </value>
		public IncidentLog IncidentLog { get; set; }
	}
}
