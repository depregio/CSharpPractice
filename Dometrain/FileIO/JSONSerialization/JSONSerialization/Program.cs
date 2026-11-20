//JSON serialization

//JSON (JavaScript Object Notation) is a lightweight data format used for storing and exchanging data.
//JsonSerializer.Serialize converts C# objects into JSON strings.

//Why serialize to JSON?
//      USE CASE	        DESCRIPTION
//      Save to file	    Store object data in a readable format
//      Send over network	APIs commonly use JSON for data exchange
//      Configuration	    Store app settings in JSON files
//      Logging	            Log structured data for analysis

//By default, JsonSerializer uses the exact property names from your class.


//Basic syntax
using System.Text.Json;     //Required

Person person = new Person { Name = "Alice", Age = 30 };    
string json = JsonSerializer.Serialize(person);             //Serializes an object to a JSON string
                                                            //Result: {"Name":"Alice","Age":30}


//Property naming
public class Item { public string ItemName { get; set; } }  //Serializes to: {"ItemName":"Widget"}



//Test: create a Product object using the provided parameters and serialize it to a JSON string using JsonSerializer.Serialize.
//      The Product class is defined in Product.cs with properties: Name, Price, and Quantity.
public class Solution
{
    public static string SerializeProduct(string name, decimal price, int quantity)
    {
        Product product = new Product { Name = name, Price = price, Quantity = quantity };
        return JsonSerializer.Serialize(product);
    }
}

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}