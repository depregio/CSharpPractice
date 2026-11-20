//JSON deserialization

//JsonSerializer.Deserialize converts a JSON string back into a C# object.
//This is the reverse of serialization, you take data stored as JSON text
//and reconstruct it as a typed object you can work with in your code.

//By default, JSON property names must match C# property names (case-sensitive).
//The JSON {"Name":"Value"} maps to a C# property named Name.


//Basic usage
using System.Text.Json;

string json = "{\"Name\":\"Apple\",\"Price\":1.50}";            //Requires a json string
Product product = JsonSerializer.Deserialize<Product>(json);    //Deserializes JSON string to an object

Console.WriteLine(product.Name);    //Apple                     //Now you can access properties
Console.WriteLine(product.Price);   //1.50


//Property matching
string json2 = "{\"Name\":\"Laptop\",\"Price\":999.99,\"Quantity\":5}";     //{"Name":"Laptop","Price":999.99,"Quantity":5}
public class ProductExample                                                 //JSON and C# (this class) property names match.
{                                                                           //You can deserialize it.
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}



//Test: parse a JSON string representing a product into a Product object and return it.
//      The Product class is already defined in Product.cs with Name, Price, and Quantity properties.
public class Solution
{
    public static Product DeserializeProduct(string json)
    {
        return JsonSerializer.Deserialize<Product>(json);
    }
}

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}