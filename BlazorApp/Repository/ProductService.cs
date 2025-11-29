using BlazorApp.Models;

namespace BlazorApp.Repository
{
    public class ProductService
    {
        List<Product> Products = new List<Product>();
        public ProductService()
        {
            Products.Add(new Product { Id = 1, Name = "Laptop", Price = 999.99m, Description = "A high-performance laptop.", CategoryId = 1 });
            Products.Add(new Product { Id = 2, Name = "Smartphone", Price = 699.99m, Description = "A latest model smartphone.", CategoryId = 1 });
            Products.Add(new Product { Id = 3, Name = "Jeans", Price = 49.99m, Description = "Comfortable blue jeans.", CategoryId = 2 });
            Products.Add(new Product { Id = 4, Name = "T-Shirt", Price = 19.99m, Description = "Casual cotton t-shirt.", CategoryId = 2 });
            Products.Add(new Product { Id = 5, Name = "Novel", Price = 14.99m, Description = "A thrilling mystery novel.", CategoryId = 3 });
            Products.Add(new Product { Id = 6, Name = "Cookbook", Price = 29.99m, Description = "Delicious recipes for home cooking.", CategoryId = 3 });
            Products.Add(new Product { Id = 7, Name = "Blender", Price = 89.99m, Description = "A powerful kitchen blender.", CategoryId = 4 });
            Products.Add(new Product { Id = 8, Name = "Vacuum Cleaner", Price = 129.99m, Description = "A high-suction vacuum cleaner.", CategoryId = 4 });
        }

        public List<Product> GetAllProducts()
        {
            return Products;
        }
        public Product? GetProductById(int id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }
        public void UpdateProduct(Product product)
        {
            var existingProduct = GetProductById(product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.Description = product.Description;
                existingProduct.CategoryId = product.CategoryId;
            }
        }
    }
}
