using BlazorApp.Models;

namespace BlazorApp.Repository
{
    public class CategoryService
    {
        List<Category> Categories = new List<Category>();
        public CategoryService()
        {
            Categories.Add(new Category { Id = 1, Name = "Electronics" });
            Categories.Add(new Category { Id = 2, Name = "Clothing" });
            Categories.Add(new Category { Id = 3, Name = "Books" });
            Categories.Add(new Category { Id = 4, Name = "Home & Kitchen" });
        }

        public List<Category> GetAllCategories()
        {
            return Categories;
        }

        public Category? GetCategoryById(int id)
        {
            return Categories.FirstOrDefault(c => c.Id == id);
        }
    }
}
