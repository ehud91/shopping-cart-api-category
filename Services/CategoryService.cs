using System.Collections;
using MongoDB.Driver;
using ShoppingCartApi.Data;
using ShoppingCartApi.Dto;
using ShoppingCartApi.Models;

namespace ShoppingCartApi.Services
{
    public class CategoryService : ICategoryService
    {
        public List<CategoryDto> categories = new List<CategoryDto>();

        private readonly MongoDbContext _context;

        public CategoryService(MongoDbContext context) 
        {
            _context = context;
        }

        public async Task<List<CategoryDto>> GetCategoriesAsync()
        {
            try {

                var categories = new List<CategoryDto>();
                /* Not In Use */
                // this.categories = this.generateCategories();
                var result = await _context.Categories.Find(cat => true).ToListAsync();                

                if (result == null || result.Count() <= 0)
                    return categories;

                foreach (var res in result) 
                {
                    var newCategoryDto = new CategoryDto(res.CatId, res.Title, res.Description);
                    categories.Add(newCategoryDto);
                }

                return categories;                
            }
            catch (Exception ex) 
            {
                throw new Exception("Couldn't get results from Db", ex);
            }
        }

        public async Task<CategoryDto> GetCategoryAsync(string id)
        {
            try
            {
                /* Not In Use */
                //var categories = await this.GetCategoriesAsync();
                //var categoryFiltered = categories.Where(cat => cat.id == id);

                var result = await _context.Categories.Find(cat => cat.CatId == id).FirstOrDefaultAsync();               
                CategoryDto categoryDto = null;
                if (result == null)
                {
                    return categoryDto;
                }
                else
                {
                    categoryDto = new CategoryDto(result.CatId, result.Title, result.Description);
                }

           
                return categoryDto;

                //throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw new Exception("Couldn't get results from Db", ex);
            }            
        }

        public async Task<bool> AddCategory(CategoryDto category)
        {
            try
            {
                //this.categories.Add(category);                
                await _context.Categories.InsertOneAsync(fillCategoryDto(category));
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception("Could not insert new category", ex);
            }
        }


        private Category fillCategoryDto(CategoryDto category) 
        {
            var newCateory = new Category();
            newCateory.CatId = category.CatId;
            newCateory.Title = category.Title;
            newCateory.Description = category.Description;
            return newCateory;
        }


        /*
        // Not In Use //
        private List<CategoryDto> generateCategories()
        {          
            CategoryDto category1 = new CategoryDto(1, "בשר", "בשר");
            CategoryDto category2 = new CategoryDto(2, "חלב וגבינות", "חלב וגבינות");
            CategoryDto category3 = new CategoryDto(3, "ירקות ופירות", "ירקות ופירות");
            this.categories.Add(category1);
            this.categories.Add(category2);
            this.categories.Add(category3);
            return this.categories;
        }
        */
    }
}
