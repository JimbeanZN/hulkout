using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace HulkOut.Logic.Tests
{
	[TestFixture]
	public class AuditServiceTests
	{
		private static AuditService AuditService()
		{
			var auditService = new AuditService();
			return auditService;
		}

		[Test]
		public void GetAll_GivenNullFilter_ThrowsError()
		{
			//arrange
			var auditService = AuditService();

			//act
			var result = Assert.Throws<ArgumentNullException>(() =>
			{
				auditService.GetAll(null);
			});

			//assert
			Assert.NotNull(result);
			Assert.AreEqual("filter", result.ParamName);
		}
	}
}
