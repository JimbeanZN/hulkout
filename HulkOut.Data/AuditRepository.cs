using HulkOut.Interfaces.DataAccess.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HulkOut.Models.Data;
using System.Linq.Expressions;
using static HulkOut.Models.Enums.AuditEnums;

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