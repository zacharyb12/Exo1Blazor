using System.ComponentModel.DataAnnotations;

namespace Exo1Blazor.Models
{
    public class AddProduct
    {
        [Required(ErrorMessage = "Le nom est requis")] // <-- Il faut les remettre ici !
        public string Name { get; set; }

        [Required(ErrorMessage = "La description est requise")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Le prix est requis")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Le prix doit être supérieur à 0")]
        public double Price { get; set; }

        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Le stock est requis")]
        public int stock { get; set; }
    }
}
