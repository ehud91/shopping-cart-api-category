using ShoppingCartApi.Dto;

namespace ShoppingCartApi.Services
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetCategoriesAsync();

        Task<CategoryDto> GetCategoryAsync(string id);

        Task<bool> AddCategory(CategoryDto category);
    }
}
