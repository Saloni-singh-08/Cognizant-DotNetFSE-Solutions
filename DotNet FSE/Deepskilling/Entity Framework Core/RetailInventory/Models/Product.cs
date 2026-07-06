using System.ComponentModel.DataAnnotations;

namespace RetailInventory.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public int CategoryId { get; set; }

        // Navigation Property
        public Category Category { get; set; }

        // One-to-One Navigation Property
        public ProductDetail ProductDetail { get; set; }

        // Concurrency Token
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}