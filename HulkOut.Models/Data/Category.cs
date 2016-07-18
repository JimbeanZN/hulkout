using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HulkOut.Models.Data
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HulkOut.Models.BaseModel" />
	public class Category : BaseModel
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
	}
}
