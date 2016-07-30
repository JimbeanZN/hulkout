using HulkOut.Core.Interfaces;
using HulkOut.Models.Data;

namespace HulkOut.Interfaces.Auditing
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HulkOut.Core.Interfaces.IBaseRepository{HulkOut.Models.Data.Audit}" />
	public interface IAuditRepository : IBaseRepository<Audit>
	{
	}
}