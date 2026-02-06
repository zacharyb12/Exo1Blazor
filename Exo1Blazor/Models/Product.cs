using System.ComponentModel.DataAnnotations;

namespace Exo1Blazor.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Le nom est requis")]
        public string Name { get; set; }

        [Required(ErrorMessage ="La description est requise")]
        public string Description  { get; set; }

        [Required(ErrorMessage = "Le prix est requis")]
        public double Price { get; set; }

        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Le stock est requis")]
        public int stock { get; set; }
    }
}
