using Exo1Blazor.Services;
using Microsoft.AspNetCore.Components;
using Exo1Blazor.Models;

namespace Exo1Blazor.Components.Pages
{
    public partial class AddProduct
    {
        [Inject]
        private ProductService _productService { get; set; }

        [Inject]
        private NavigationManager Navigation { get; set; }

        [SupplyParameterFromForm]
        public Models.AddProduct newProduct { get; set; } = new();

        private void AddNewProduct()
        {
            // Ajout d'un produit
            _productService.AddProduct(newProduct);
            // Naviguer vers la liste
            Navigation.NavigateTo("List");
        }
    }
}
