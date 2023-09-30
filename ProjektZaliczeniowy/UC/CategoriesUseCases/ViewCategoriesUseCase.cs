using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace UC
{
    public class ViewCategoriesUseCase : IViewCategoriesUseCase
    {
        private readonly ICategoryRepo categoryRepo;
        public ViewCategoriesUseCase(ICategoryRepo categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }
        public IEnumerable<Category> Execute()
        {
            return categoryRepo.GetCategories();
        }
    }
}
