using Tangy.Domain.Models;

namespace Tangy.WebServer.Pages.LearnBlazor
{
    public partial class BindProp
    {
        public Product product;
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
        }
    }
}