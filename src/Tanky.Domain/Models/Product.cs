namespace Tangy.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; } = false;
        public decimal Price { get; set; }
        public List<ProductProperties> ProductProperties { get; set; }
    }
}