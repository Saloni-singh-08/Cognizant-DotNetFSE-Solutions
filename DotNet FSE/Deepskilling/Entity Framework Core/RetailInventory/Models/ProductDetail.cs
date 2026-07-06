namespace RetailInventory.Models
{
    public class ProductDetail
    {
        public int ProductDetailId { get; set; }

        public string WarrantyInfo { get; set; }

        // Foreign Key
        public int ProductId { get; set; }

        // Navigation Property
        public Product Product { get; set; }
    }
}