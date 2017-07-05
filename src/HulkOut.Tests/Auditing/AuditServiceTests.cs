using System;
using HulkOut.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HulkOut.Tests.Auditing
{
	[TestClass]
	public class AuditServiceTests
	{
		private static AuditService AuditService()
		{
			var auditService = new AuditService();
			return auditService;
		}

		[TestMethod]
		public void GetAll_GivenNullFilter_ThrowsError()
		{
			//arrange
			var auditService = AuditService();

			//act
			var result = Assert.ThrowsException<ArgumentNullException>(() => { auditService.GetAll(null); });

			//assert
			Assert.IsNotNull(result);
			Assert.AreEqual("filter", result.ParamName);
		}
	}
}