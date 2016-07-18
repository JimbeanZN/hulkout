﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HulkOut.Models
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class BaseModel
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>
		/// The identifier.
		/// </value>
		[Key]
		Guid Id { get; set; }

		/// <summary>
		/// Gets or sets the created date.
		/// </summary>
		/// <value>
		/// The created date.
		/// </value>
		DateTime CreatedDate { get; set; }

		/// <summary>
		/// Gets or sets the created by user identifier.
		/// </summary>
		/// <value>
		/// The created by user identifier.
		/// </value>
		Guid CreatedByUserId { get; set; }

		/// <summary>
		/// Gets or sets the last updated date.
		/// </summary>
		/// <value>
		/// The last updated date.
		/// </value>
		DateTime LastUpdatedDate { get; set; }

		/// <summary>
		/// Gets or sets the last updated by user identifier.
		/// </summary>
		/// <value>
		/// The last updated by user identifier.
		/// </value>
		Guid LastUpdatedByUserId { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance is deleted.
		/// </summary>
		/// <value>
		/// <c>true</c> if this instance is deleted; otherwise, <c>false</c>.
		/// </value>
		bool IsDeleted { get; set; }
	}
}