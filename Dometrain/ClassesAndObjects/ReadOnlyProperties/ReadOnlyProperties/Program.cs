//Read-only properties

//Read-only properties use { get; } without a setter, meaning they can only be assigned a value in the constructor and never changed afterward.


//Declaration syntax
public class Product
{
    public string ProductId { get; }
    public decimal Price { get; }

    public Product(string id, decimal price)
    {
        ProductId = id;  // ✓ Valid - setting in constructor
        Price = price;   // ✓ Valid - setting in constructor
    }

    public void UpdatePrice(decimal newPrice)
    {
        // Price = newPrice;  // ✗ Error! Cannot assign after construction
    }
}