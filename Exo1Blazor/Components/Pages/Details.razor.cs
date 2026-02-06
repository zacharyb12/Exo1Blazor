using Exo1Blazor.Models;
using Microsoft.AspNetCore.Components;

namespace Exo1Blazor.Components.Pages
{
    public partial class Details
    {
        [Parameter]
        public int Id { get; set; }

        public Product product = new Product
        {
            Id = 1,
            Name = "Iphone 17",
            Price = 1700.99,
            Description = "The latest iPhone with advanced features.",
            stock = 50,
            ImageUrl = "/images/iphone.jpg"
        };
    }
}
