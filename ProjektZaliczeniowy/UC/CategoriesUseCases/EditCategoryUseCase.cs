using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace UC
{
    public class EditCategoryUseCase : IEditCategoryUseCase
    {
        private readonly ICategoryRepo categoryRepo;

        public EditCategoryUseCase(ICategoryRepo categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }

        public void Execute(Category category)
        {
            categoryRepo.EditCategory(category);
        }
    }
}
