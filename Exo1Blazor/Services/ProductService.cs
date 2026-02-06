using Exo1Blazor.Models;

namespace Exo1Blazor.Services
{
    public class ProductService
    {
        public static List<Product> products = new List<Product>()
        {
            new Product {
                Id = 1,
                Name = "Iphone 17",
                Price = 1700.99,
                Description = "The latest iPhone with advanced features.",
                stock = 50,
                ImageUrl = "/images/iphone.jpg"
            },
            new Product {
                Id = 2,
                Name = "Samsung Galaxy S26",
                Price = 1999.99,
                Description = "The newest Galaxy phone with cutting-edge technology.",
                stock = 30,
                ImageUrl = "/images/samsung.jpg"
            },
            new Product {
                Id = 3,
                Name = "Google Pixel 6",
                Price = 999.99,
                Description = "Google's flagship phone with excellent camera quality.",
                stock = 20,
                ImageUrl = "/images/googlePixel.jpg"
            },
            new Product
            {
                Id = 4,
                Name = "OnePlus 9 Pro",
                Price = 899.99,
                Description = "A high-performance phone with a sleek design.",
                stock = 15,
                ImageUrl = "/images/googlePixel.jpg"
            }
        };

        public List<Product> GetProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public void AddProduct(AddProduct newProduct)
        {
            Product newProductToAdd = new Product
            {
                Name = newProduct.Name,
                Description = newProduct.Description,
                Price = newProduct.Price,
                ImageUrl = newProduct.ImageUrl,
                stock = newProduct.stock
            };
            newProductToAdd.Id = products.Max(p => p.Id) + 1;
            products.Add(newProductToAdd);
        }

        public void UpdateProduct(Product updatedProduct)
        {
            Product existingProduct = GetProductById(updatedProduct.Id);
            if (existingProduct != null)
            { 
                products.Remove(existingProduct);

                updatedProduct.Id = existingProduct.Id;
                products.Add(updatedProduct);
            }
        }

        public void DeleteProduct(int id)
        {
            Product productToDelete = GetProductById(id);
            if (productToDelete != null)
            {
                products.Remove(productToDelete);
            }
        }
    }
}
