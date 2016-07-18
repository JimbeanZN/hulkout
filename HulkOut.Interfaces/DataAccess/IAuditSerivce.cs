using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HulkOut.Interfaces.DataAccess
{
	public interface IAuditSerivce
	{
		void WriteAudit(Models.Enums.AuditEnums.AuditAction auditAction, Guid actionBy, object actionedData);
	}
}
