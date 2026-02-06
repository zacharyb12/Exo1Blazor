using Exo1Blazor.Models;
using Exo1Blazor.Services;
using Microsoft.AspNetCore.Components;

namespace Exo1Blazor.Components.Pages
{
    public partial class List
    {
        [Inject]
        public NavigationManager Navigation { get; set; }

        [Inject]
        private ProductService _productService { get; set; }



        public List<Product> products = new();

        protected override void OnInitialized()
        {
            products = _productService.GetProducts();
        }

        public void NavigateToDetails(int id)
        {
            Navigation.NavigateTo($"/details/{id}");
        }

        public void NavigateToAdd()
        {
            Navigation.NavigateTo("/addProduct");
        }
    }
}
