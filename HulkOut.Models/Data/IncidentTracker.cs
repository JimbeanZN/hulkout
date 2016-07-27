using HulkOut.Core.Extensions;
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
	public class IncidentTracker : BaseModel
	{
		/// <summary>
		/// Gets or sets the incident identifier.
		/// </summary>
		/// <value>
		/// The incident identifier.
		/// </value>
		[ForeignKey("Incident")]
		[Required]
		public Guid IncidentId { get; set; }

		/// <summary>
		/// Gets or sets the incident.
		/// </summary>
		/// <value>
		/// The incident.
		/// </value>
		[NotMapped]
		public Incident Incident { get; set; }

		/// <summary>
		/// Gets or sets the logged by user identifier.
		/// </summary>
		/// <value>
		/// The logged by user identifier.
		/// </value>
		[ForeignKey("LoggedByUser")]
		[Required]
		public Guid LoggedByUserId { get; set; }

		/// <summary>
		/// Gets or sets the logged by user.
		/// </summary>
		/// <value>
		/// The logged by user.
		/// </value>
		public User LoggedByUser { get; set; }

		/// <summary>
		/// Gets or sets the tracker logs.
		/// </summary>
		/// <value>
		/// The tracker logs.
		/// </value>
		public virtual IEnumerable<IncidentTrackerLog> TrackerLogs { get; set; }

		/// <summary>
		/// Gets the impact count.
		/// </summary>
		/// <value>
		/// The impact count.
		/// </value>
		public int ImpactCount
		{
			get
			{
				if (TrackerLogs.IsNotNullAndEmpty())
				{
					return TrackerLogs.Count();
				}

				return 0;
			}
		}


	}
}
