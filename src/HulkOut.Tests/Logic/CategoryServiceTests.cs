using System;
using HulkOut.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HulkOut.Tests.Logic
{
	[TestClass]
	public class CategoryServiceTests
	{
		private static CategoryService CategoryService()
		{
			var categoryService = new CategoryService();
			return categoryService;
		}

		[TestMethod]
		public void GetAll_GivenNullFilter_ThrowsError()
		{
			//arrange
			var categoryService = CategoryService();

			//act
			var result = Assert.ThrowsException<ArgumentNullException>(() => { categoryService.GetAll(null); });

			//assert
			Assert.IsNotNull(result);
			Assert.AreEqual("filter", result.ParamName);
		}

		[TestMethod]
		public void Insert_GivenNullModel_ThrowsError()
		{
			//arrange
			var categoryService = CategoryService();

			//act
			var result = Assert.ThrowsException<ArgumentNullException>(() => { categoryService.Insert(null); });

			//assert
			Assert.IsNotNull(result);
			Assert.AreEqual("model", result.ParamName);
		}

		[TestMethod]
		public void Update_GivenNullModel_ThrowsError()
		{
			//arrange
			var categoryService = CategoryService();

			//act
			var result = Assert.ThrowsException<ArgumentNullException>(() => { categoryService.Update(null); });

			//assert
			Assert.IsNotNull(result);
			Assert.AreEqual("model", result.ParamName);
		}
	}
}