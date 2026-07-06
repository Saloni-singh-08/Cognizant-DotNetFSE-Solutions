using System;

class Program
{
    static void Main(string[] args)
    {
        Product[] products =
        {
            new Product(101, "Keyboard", "Electronics"),
            new Product(102, "Laptop", "Electronics"),
            new Product(103, "Mouse", "Electronics"),
            new Product(104, "Phone", "Electronics")
        };

        Console.WriteLine("----- Linear Search -----");

        Product linearResult = LinearSearch.Search(products, "Mouse");

        if (linearResult != null)
            Console.WriteLine("Product Found: " + linearResult.ProductName);
        else
            Console.WriteLine("Product Not Found");

        Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName));

        Console.WriteLine("\n----- Binary Search -----");

        Product binaryResult = BinarySearch.Search(products, "Mouse");

        if (binaryResult != null)
            Console.WriteLine("Product Found: " + binaryResult.ProductName);
        else
            Console.WriteLine("Product Not Found");
    }
}
