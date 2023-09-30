using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace UC
{
    public class DeleteCategoryUseCase : IDeleteCategoryUseCase
    {
        private readonly ICategoryRepo categoryRepo;
        public DeleteCategoryUseCase(ICategoryRepo categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }
        public void DeleteCategory(string categoryId)
        {
            categoryRepo.DeleteCategory(categoryId);
        }
    }
}
