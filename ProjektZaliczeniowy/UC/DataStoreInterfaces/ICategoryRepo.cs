using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC.DataStoreInterfaces
{
    public interface ICategoryRepo
    {
        public IEnumerable<Category> GetCategories();

        public void AddCategory(Category category);

        public void EditCategory(Category category);

        public Category GetCategoryById(string categoryId);

        public void DeleteCategory(string categoryId);
    }
}
