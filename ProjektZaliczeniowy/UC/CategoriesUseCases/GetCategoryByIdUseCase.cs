using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace UC
{
    public class GetCategoryByIdUseCase : IGetCategoryByIdUseCase
    {
        private readonly ICategoryRepo categoryRepo;
        public GetCategoryByIdUseCase(ICategoryRepo categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }

        public Category Execute(string categoryId)
        {
            return categoryRepo.GetCategoryById(categoryId);
        }
    }
}
