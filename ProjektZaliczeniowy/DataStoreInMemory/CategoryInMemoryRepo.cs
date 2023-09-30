using Core;
using System;
using System.Collections.Generic;
using UC.DataStoreInterfaces;

namespace DataStoreInMemory
{
    public class CategoryInMemoryRepo : ICategoryRepo
    {
        private List<Category> categories;

        public CategoryInMemoryRepo()
        {
            categories = new List<Category>();
        }

        public void AddCategory(Category category)
        {
            Guid guid = Guid.NewGuid();
            category.CategoryId = guid.ToString();

            categories.Add(category);
        }

        public void EditCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.CategoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate = category;
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(string categoryId)
        {
            return categories?.Find(cat => cat.CategoryId == categoryId);
        }

        public void DeleteCategory(string categoryId)
        {
            categories?.Remove(GetCategoryById(categoryId));
        }
    }
}
