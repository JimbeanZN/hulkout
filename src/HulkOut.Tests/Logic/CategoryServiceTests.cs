using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
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

		private HulkService CategoryService()
		{
			var categoryService = new HulkService(_categoryRepository);
			return categoryService;
		}

		#region Get

		[TestMethod]
		public void Get_GivenAGuid_ExpectAnObjectOfTypeCategory()
		{
			//arrange
			var categoryService = CategoryService();

			var guid1 = new Guid();

			_categoryRepository.Get(Arg.Any<Expression<Func<Category, bool>>>())
				.Returns(new List<Category> {new Category {Id = guid1}, new Category {Id = new Guid()}});

			//act
			var result = categoryService.Get(Arg.Any<Guid>()).Result;

			//assert
			Assert.IsNotNull(result);
			Assert.IsInstanceOfType(result, typeof(Category));
			Assert.AreEqual(guid1, result.Id);
		}

		#endregion

		#region GetAll

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public async Task GetAll_GivenNullFilter_ThrowsError()
		{
			//arrange
			var categoryService = CategoryService();

			//act assert
			await categoryService.GetAll(null);
		}

		[TestMethod]
		public void GetAll_GivenAFilter_ReturnsAList()
		{
			//arrange
			var categoryService = CategoryService();

			_categoryRepository.Get(Arg.Any<Expression<Func<Category, bool>>>())
				.Returns(new List<Category> {new Category(), new Category()});

			//act
			var result = categoryService.GetAll(model => true).Result;

			//assert
			Assert.IsNotNull(result);
			Assert.IsInstanceOfType(result, typeof(IEnumerable<Category>));
			Assert.AreEqual(2, result.Count());
			_categoryRepository.Received().Get(Arg.Any<Expression<Func<Category, bool>>>());
		}

		#endregion

		#region Insert

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public async Task Insert_GivenNullModel_ThrowsError()
		{
			//arrange
			var categoryService = CategoryService();

			//act assert
			await categoryService.Insert(null);
		}

		[TestMethod]
		public void Insert_GivenAModel_ReturnsAModelWithAnId()
		{
			//arrange
			var categoryService = CategoryService();

			var passedModel = new Category
			{
				Title = "Test Category",
				Description = "Test Category Description"
			};
			var expectedModel = passedModel;
			expectedModel.Id = new Guid();

			_categoryRepository.Insert(passedModel).Returns(expectedModel);

			//act
			var result = categoryService.Insert(passedModel).Result;

			//assert
			Assert.IsNotNull(result);
			Assert.IsInstanceOfType(result, typeof(Category));
			Assert.AreEqual(expectedModel.Id, result.Id);
			Assert.AreEqual(expectedModel.Title, result.Title);
			Assert.AreEqual(expectedModel.Description, result.Description);
		}

		#endregion

		#region Update

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public async Task Update_GivenNullModel_ThrowsError()
		{
			//arrange
			var categoryService = CategoryService();

			//act assert
			await categoryService.Update(new Guid(), null);
		}

		[TestMethod]
		public void Update_GivenAModel_ReturnsAnUpdatedModelWithUserAndDateTime()
		{
			//arrange
			var categoryService = CategoryService();

			var passedGuid = new Guid();
			var passedModel = new Category
			{
				Id = passedGuid,
				Title = "Test Category",
				Description = "Test Category Description",
				LastUpdatedByUserId = new Guid(),
				LastUpdatedDate = DateTime.Now.AddDays(-1)
			};
			var expectedModel = passedModel;
			expectedModel.LastUpdatedByUserId = new Guid();
			expectedModel.LastUpdatedDate = expectedModel.LastUpdatedDate.AddDays(1);

			_categoryRepository.Update(passedGuid, passedModel).Returns(expectedModel);

			//act
			var result = categoryService.Update(passedGuid, passedModel).Result;

			//assert
			Assert.IsNotNull(result);
			Assert.IsInstanceOfType(result, typeof(Category));
			Assert.AreEqual(expectedModel.Id, result.Id);
			Assert.AreEqual(expectedModel.LastUpdatedDate, result.LastUpdatedDate);
			Assert.AreEqual(expectedModel.LastUpdatedByUserId, result.LastUpdatedByUserId);
		}

		#endregion

		#region Delete

		[TestMethod]
		public void Delete_GivenAGuid_ReturnsTrueIfSuccessful()
		{
			//arrange
			var categoryService = CategoryService();

			_categoryRepository.Delete(Arg.Any<Guid>()).Returns(true);

			//act
			var result = categoryService.Delete(Arg.Any<Guid>()).Result;

			//assert
			Assert.IsNotNull(result);
			Assert.IsInstanceOfType(result, typeof(bool));
			Assert.IsTrue(result);
		}

		#endregion
	}
}