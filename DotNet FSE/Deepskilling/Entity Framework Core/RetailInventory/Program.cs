using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

using var context = new AppDbContext();

try
{
    var product = await context.Products.FirstOrDefaultAsync();

    if (product != null)
    {
        product.Price += 1000;

        await context.SaveChangesAsync();

        Console.WriteLine("Changes saved successfully.");
    }
    else
    {
        Console.WriteLine("No product found.");
    }
}
catch (DbUpdateConcurrencyException)
{
    Console.WriteLine("Concurrency conflict detected.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}