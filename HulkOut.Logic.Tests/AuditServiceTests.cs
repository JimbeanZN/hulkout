using System;
using NUnit.Framework;

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
			var result = Assert.Throws<ArgumentNullException>(() => { auditService.GetAll(null); });

			//assert
			Assert.NotNull(result);
			Assert.AreEqual("filter", result.ParamName);
		}
	}
}