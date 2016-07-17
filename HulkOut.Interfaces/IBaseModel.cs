using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HulkOut.Interfaces
{
	public interface IBaseModel
	{
		/// <summary>
		/// A unique identifier for this item stored in persistent storage
		/// </summary>
		Guid Id { get; set; }

		/// <summary>
		/// The date and time when this item was initially persisted to data storage
		/// </summary>
		DateTime CreatedDate { get; set; }
		/// <summary>
		/// The identifier of the user who initially persisted this item to data storage
		/// </summary>
		Guid CreatedBy { get; set; }
		/// <summary>
		/// The date and time when this item was last updated and persisted to data storage 
		/// </summary>
		DateTime LastUpdated { get; set; }
		/// <summary>
		/// The identifier of the user who last updated and persisted this item to data storage
		/// </summary>
		Guid LastUpdatedBy { get; set; }

		/// <summary>
		/// A boolean value determining if this item has been deleted
		/// </summary>
		bool IsDeleted { get; set; }
	}
}