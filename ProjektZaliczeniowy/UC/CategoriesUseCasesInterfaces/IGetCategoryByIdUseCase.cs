using Core;

namespace UC
{
    public interface IGetCategoryByIdUseCase
    {
        Category Execute(string categoryId);
    }
}