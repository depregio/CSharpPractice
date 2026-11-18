//Required properties

//The required modifier (C# 11+) marks properties that must be set during object initialization.
//The compiler enforces this, preventing objects from being created with missing mandatory data.

//Compared to init properties, this is not immutable after creation.


//Basic syntax
using System.Xml.Linq;

public class User
{
    public required string Username { get; set; }
    public required string Email { get; set; }
    public string? Bio { get; set; }    //Optional: no required modifier
}

var user = new User     //Must provide Username and Email
{
    Username = "john_doe",
    Email = "john@example.com"
    //Bio is optional, can be omitted
};


//Compiler enforcement
var user = new User     //This will not compile: missing required property
{
    Username = "john_doe"       //Error: Required member 'User.Email' must be set
};


//Combining required and init for immutable mandatory properties
public class Order
{
    public required string OrderId { get; init; }   //Must set, cannot change
    public required decimal Total { get; init; }
}



//Test: create a Product class with three required properties:
//          Name(string)
//          Price(decimal)
//          Category(string)
//      Then implement CreateProduct to create a Product instance and return its description.
public class Solution
{
    public static string CreateProduct(string name, decimal price, string category)
    {
        Product product = new Product
        {
            Name = name,
            Price = price,
            Category = category
        };

        return $"Product: {product.Name}, Price: ${product.Price}, Category: {product.Category}";
    }
}

public class Product
{
    public required string Name { get; set; }
    public required decimal Price { get; set; }
    public required string Category { get; set; }
}