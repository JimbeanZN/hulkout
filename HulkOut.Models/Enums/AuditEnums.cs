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
			Get = 0,
			Insert = 1,
			Update = 2,
			Delete = 3
		}
	}
}
