using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using HulkOut.Models.Data;

namespace HulkOut.Interfaces.DataAccess.Auditing
{
	public interface IAuditRepository : IBaseRepository<Audit>
	{
	}
}