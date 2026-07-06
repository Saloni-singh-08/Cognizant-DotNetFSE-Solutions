using System;

public class LinearSearch
{
    public static Product Search(Product[] products, string productName)
    {
        foreach (Product product in products)
        {
            if (product.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase))
            {
                return product;
            }
        }

        return null;
    }
}