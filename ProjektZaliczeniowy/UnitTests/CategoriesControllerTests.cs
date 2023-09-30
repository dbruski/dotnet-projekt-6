using Core;
using DataStoreInMemory;
using System.Collections.Generic;
using UC.DataStoreInterfaces;
using Xunit;

namespace UnitTests
{
    public class CategoriesControllerTests
    {
        private readonly ICategoryRepo categoryRepo;

        public CategoriesControllerTests()
        {
            categoryRepo = new CategoryInMemoryRepo();

            categoryRepo.AddCategory(new Category { Name = "Kategoria 1", Description = "Opis kategorii 1" });
        }

        [Fact]
        public void TestAddTwoCategories_AndGetAllCategories()
        {
            categoryRepo.AddCategory(new Category { CategoryId = "2", Name = "Kategoria 2", Description = "Opis kategorii 2" });
            categoryRepo.AddCategory(new Category { CategoryId = "3", Name = "Kategoria 3", Description = "Opis kategorii 3" });

            var result = categoryRepo.GetCategories() as List<Category>;

            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void TestRemoveCategory()
        {
            var categories = categoryRepo.GetCategories() as List<Category>;

            Category recentlyAddedCategory = categories[0];

            string recentlyAddedCategoryId = recentlyAddedCategory.CategoryId;

            categoryRepo.DeleteCategory(recentlyAddedCategoryId);

            var categoriesAfterRemoval = categoryRepo.GetCategories() as List<Category>;

            Assert.Equal(0, categoriesAfterRemoval.Count);
        }

        [Fact]
        public void TestAddCategory_AndGetItById()
        {
            var categories = categoryRepo.GetCategories() as List<Category>;

            string recentlyAddedCategoryId = categories[0].CategoryId;

            Category categoryFromGet = categoryRepo.GetCategoryById(recentlyAddedCategoryId);

            Assert.Equal("Kategoria 1", categoryFromGet.Name);
            Assert.Equal("Opis kategorii 1", categoryFromGet.Description);
        }
    }
}