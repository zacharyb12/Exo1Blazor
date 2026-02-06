using Exo1Blazor.Models;
using Microsoft.AspNetCore.Components;

namespace Exo1Blazor.Components.Pages
{
    public partial class List
    {
        [Inject]
        public NavigationManager Navigation { get; set; }

        public List<Product> products = new()
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
            }
        };

        public void NavigateToDetails(int id)
        {
            Navigation.NavigateTo($"/details/{id}");
        }
    }
}
