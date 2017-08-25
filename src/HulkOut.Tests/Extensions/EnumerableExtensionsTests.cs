using System.Collections.Generic;
using HulkOut.Extensions;
using NUnit.Framework;

namespace HulkOut.Tests.Extensions
{
	[TestFixture]
	public class EnumerableExtensionsTests
	{
		[Test]
		public void IsNullOrEmpty_GivenEmptyEnumerable_ReturnsTrue()
		{
			//arrange
			var list = new List<string>();

			//act
			var result = list.IsNullOrEmpty();

			//assert
			Assert.IsTrue(result);
		}

		[Test]
		public void IsNullOrEmpty_GivenNullEnumerable_ReturnsTrue()
		{
			//arrange
			IEnumerable<string> list = null;

			//act
			var result = list.IsNullOrEmpty();

			//assert
			Assert.IsTrue(result);
		}

		[Test]
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