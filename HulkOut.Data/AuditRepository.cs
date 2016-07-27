using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using HulkOut.Interfaces.DataAccess.Auditing;
using HulkOut.Models.Data;

namespace HulkOut.Data.EF
{
	public class AuditRepository : IAuditRepository
	{
		public Audit Create(Audit audit)
		{
			using (var db = new HulkOutDbContext())
			{
				db.Audits.Add(audit);
				db.SaveChanges();

				return audit;
			}
		}

		public IEnumerable<Audit> Get(Expression<Func<Audit, bool>> filter)
		{
			using (var db = new HulkOutDbContext())
			{
				return db.Audits.Where(filter).ToList();
			}
		}
	}
}