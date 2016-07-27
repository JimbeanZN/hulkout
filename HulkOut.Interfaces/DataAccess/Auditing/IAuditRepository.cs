using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using HulkOut.Models.Data;

namespace HulkOut.Interfaces.DataAccess.Auditing
{
	public interface IAuditRepository
	{
		/// <summary>
		///   Creates the specified audit.
		/// </summary>
		/// <param name="audit">The audit.</param>
		/// <returns></returns>
		Audit Create(Audit audit);

		IEnumerable<Audit> Get(Expression<Func<Audit, bool>> filter);
	}
}