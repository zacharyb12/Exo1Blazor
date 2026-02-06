using Exo1Blazor.Models;
using Exo1Blazor.Services;
using Microsoft.AspNetCore.Components;

namespace Exo1Blazor.Components.Pages
{
    public partial class Details
    {
        [Inject]
        private NavigationManager Navigation { get; set; }

        [Inject]
        public ProductService _productService { get; set; }

        [Parameter]
        public int Id { get; set; }

        public Product product = new Product();

        protected override void OnInitialized()
        {
            product = _productService.GetProductById(Id);
        }

        public void NavigateToUpdate()
        {
            Navigation.NavigateTo($"/updateProduct/{Id}");
        }
    }
}
