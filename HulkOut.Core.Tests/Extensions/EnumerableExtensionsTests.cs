using System.Collections.Generic;
using HulkOut.Core.Extensions;
using NUnit.Framework;

namespace HulkOut.Core.Tests.Extensions
{
	[TestFixture]
	public class EnumerableExtensionsTests
	{
		[Test]
		public void IsNotNullAndEmpty_GivenEmptyEnumerable_ReturnsFalse()
		{
			//arrange
			var list = new List<string>();

			//act
			var result = list.IsNotNullAndEmpty();

			//assert
			Assert.IsFalse(result);
		}

		[Test]
		public void IsNotNullAndEmpty_GivenEnumerableItems_ReturnsTrue()
		{
			//arrange
			var list = new List<string> {"Item 1"};

			//act
			var result = list.IsNotNullAndEmpty();

			//assert
			Assert.IsTrue(result);
		}

		[Test]
		public void IsNotNullAndEmpty_GivenNullEnumerable_ReturnsFalse()
		{
			//arrange
			IEnumerable<string> list = null;

			//act
			var result = list.IsNotNullAndEmpty();

			//assert
			Assert.IsFalse(result);
		}
	}
}