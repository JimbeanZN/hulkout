using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using HulkOut.Logic;
using HulkOut.Shared.Interfaces.Categories;
using HulkOut.Shared.Models.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace HulkOut.Tests.Logic
{
	[TestClass]
	public class CategoryServiceTests
	{
		private readonly ICategoryRepository _categoryRepository = Substitute.For<ICategoryRepository>();

		private CategoryService CategoryService()
		{
			var categoryService = new CategoryService(_categoryRepository);
			return categoryService;
		}

		[TestMethod]
		public void Get_GivenAGuid_ExpectAnObjectOfTypeCategory()
		{
			//arrange
			var categoryService = CategoryService();

			var guid1 = new Guid();

			_categoryRepository.Get(Arg.Any<Expression<Func<Category, bool>>>())
				.Returns(new List<Category> {new Category {Id = guid1}, new Category {Id = new Guid()}});

			//act
			var result = categoryService.Get(Arg.Any<Guid>());

			//assert
			Assert.IsNotNull(result);
			Assert.IsInstanceOfType(result, typeof(Category));
			Assert.AreEqual(guid1, result.Id);
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
		public void GetAll_GivenAFilter_ReturnsAList()
		{
			//arrange
			var categoryService = CategoryService();

			_categoryRepository.Get(Arg.Any<Expression<Func<Category, bool>>>())
				.Returns(new List<Category> { new Category(), new Category() });

			//act
			var result = categoryService.GetAll(model => true);

			//assert
			Assert.IsNotNull(result);
			Assert.IsInstanceOfType(result, typeof(IEnumerable<Category>));
			Assert.AreEqual(2, result.Count());
			_categoryRepository.Received().Get(Arg.Any<Expression<Func<Category, bool>>>());
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