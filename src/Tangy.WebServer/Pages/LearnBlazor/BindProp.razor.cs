using Tangy.Domain.Models;

namespace Tangy.WebServer.Pages.LearnBlazor
{
    public partial class BindProp
    {
        public Product product;
        List<Product> _products = new();
        private string selectedProperty = string.Empty;

        public BindProp()
        {
            product = new()
            {
                Id = 1,
                Name = "Rose Candle",
                IsActive = true,
                Price = 12.99M,
                ProductProperties = new List<ProductProperties>() { 
                    new ProductProperties { Id = 1, Key = "Color", Value = "Black" },
                    new ProductProperties { Id = 2, Key = "Flavor", Value = "Rose Jasmine" },
                    new ProductProperties { Id = 3, Key = "Size", Value = "20oz" },
                }
            };

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

        protected override void OnInitialized()
        {
        }
    }
}