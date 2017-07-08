using System.Collections.Generic;
using HulkOut.Utils.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HulkOut.Utils.Tests.Extensions
{
	[TestClass]
	public class EnumerableExtensionsTests
	{
		[TestMethod]
		public void IsNullOrEmpty_GivenEmptyEnumerable_ReturnsTrue()
		{
			//arrange
			var list = new List<string>();

			//act
			var result = list.IsNullOrEmpty();

			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void IsNullOrEmpty_GivenNullEnumerable_ReturnsTrue()
		{
			//arrange
			IEnumerable<string> list = null;

			//act
			var result = list.IsNullOrEmpty();

			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void IsNullOrEmpty_GivenEnumerableItems_ReturnsFalse()
		{
			//arrange
			var list = new List<string> {"Item 1"};

			//act
			var result = list.IsNullOrEmpty();

			//assert
			Assert.IsFalse(result);
		}
	}
}