using System.ComponentModel.DataAnnotations;

namespace Exo1Blazor.Models
{
    public class AddProduct
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string ImageUrl { get; set; }

        public int stock { get; set; }
    }
}
