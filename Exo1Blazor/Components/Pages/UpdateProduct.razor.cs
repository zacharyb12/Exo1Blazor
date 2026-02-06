using Exo1Blazor.Models;
using Exo1Blazor.Services;
using Microsoft.AspNetCore.Components;

namespace Exo1Blazor.Components.Pages
{
    public partial class UpdateProduct
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        private ProductService _productService { get; set; }

        [Inject]
        private NavigationManager Navigation { get; set; }

        [SupplyParameterFromForm]
        public Product productUpdated { get; set; } = new();

        protected override void OnInitialized()
        {
            productUpdated = _productService.GetProductById(Id);
        }

        public void UpdateProductAction()
        {
            // faire la mise à jour du produit
            _productService.UpdateProduct(productUpdated);
            // Naviguer vers la liste
            Navigation.NavigateTo("List");
        }

    }
}
