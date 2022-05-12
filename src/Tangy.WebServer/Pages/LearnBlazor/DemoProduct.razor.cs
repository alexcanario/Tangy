using Tangy.Domain.Models;

namespace Tangy.WebServer.Pages.LearnBlazor
{
    public partial class DemoProduct
    {
        private List<Product> _products = new();
        private int SelectedFavoriteCount { get; set; } = 0;
        private string LastProductSelected { get; set; } = string.Empty;

        protected override void OnInitialized()
        {
            _products.Add(new Product
            {
                Id = 1,
                Name = "Midnight Blaze",
                Price = 1.4M,
                IsActive = true,
                ProductProperties = new()
                {
                    new ProductProperties { Id = 1, Key = "Flavor", Value = "Rose" },
                    new ProductProperties { Id = 2, Key = "Size", Value = "20oz" },
                    new ProductProperties { Id = 3, Key = "Color", Value = "Purple" },
                }
            });

            _products.Add(new Product
            {
                Id = 2,
                Name = "Robocop toy",
                Price = 2.1M,
                IsActive = true,
                ProductProperties = new()
                {
                    new ProductProperties { Id = 1, Key = "Flavor", Value = "Lily" },
                    new ProductProperties { Id = 1, Key = "Size", Value = "18oz" },
                    new ProductProperties { Id = 1, Key = "Color", Value = "White" },
                }
            });
        }

        protected void ProductSelectedChange(string productName)
        {
            LastProductSelected = productName;
        }
    }
}