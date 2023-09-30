using Core;
using System.Collections.Generic;

namespace UC
{
    public interface IViewCategoriesUseCase
    {
        IEnumerable<Category> Execute();
    }
}