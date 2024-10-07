using Microsoft.AspNetCore.Mvc;
using ShoppingCartApi.Dto;
using ShoppingCartApi.Models;
using ShoppingCartApi.Services;
using System.Collections;

namespace ShoppingCartApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Read(string id)
        {
            CategoryDto category = null;
            try
            {
                var message = "";
                category = await _categoryService.GetCategoryAsync(id);             
                if (category != null)
                {
                    message = Constants.Constants.ONE_CATEGORY_FOUND;
                }
                else
                {
                    message = Constants.Constants.NO_CATEGORY_FOUND;
                }

                return Ok(new ApiResponse<CategoryDto> { Success = true, Data = category, Message = message });
            }
            catch (Exception ex)
            {
                var message = "Couldn't fetch data, Something went wrong...";
                return StatusCode(500, new ApiResponse<CategoryDto> { Success = false, Data = null, Message = message });
            }
             
            
        }

        [HttpGet("")]
        public async Task<IActionResult> Read()
        {
            var categories = await _categoryService.GetCategoriesAsync();
            var message = "";
            if (categories.Count > 0)
            {
                message = Constants.Constants.GET_ALL_CATEGORIES;
            } 
            else 
            {
                message = Constants.Constants.GET_ALL_CATEGORIES_NOT_FOUND;
            }
            

            return Ok(new ApiResponse<List<CategoryDto>> { Success = true, Data = categories, Message = message });
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryAddDto category)

        {
            var newCategory = new CategoryDto(null, category.title, category.description);
            bool isAdded = await _categoryService.AddCategory(newCategory);
            if (isAdded)
            {
                return Ok(new ApiResponse<CategoryDto> { Success = true, Data = newCategory, Message = "New Categroy added"});
            }

            return StatusCode(500, "Something went wrong...");
        }
    }
}
