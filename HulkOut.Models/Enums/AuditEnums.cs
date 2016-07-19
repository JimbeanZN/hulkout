using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HulkOut.Models.Enums
{
	public static class AuditEnums
	{
		public enum AuditAction
		{
			Get = 1,
			Insert = 2,
			Update = 3,
			Delete = 4,
			Log = 5
		}
	}
}
