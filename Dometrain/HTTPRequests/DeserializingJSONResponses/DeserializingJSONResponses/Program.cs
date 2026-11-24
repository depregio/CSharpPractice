//Deserializing JSON responses

//When APIs return JSON data, you need to convert that JSON string into C# objects you can work with.
//This process is called deserialization.


//Using JsonSerializer.Deserialize
using System.Text.Json;

public class Product        //Define a class matching the JSON structure
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

string json = "{\"Name\":\"Widget\",\"Price\":29.99}";      //Deserialize JSON string to object
Product product = JsonSerializer.Deserialize<Product>(json);
Console.WriteLine(product.Name);


//Combining HttpClient with deserialization
using var client = new HttpClient();
string json = await client.GetStringAsync("https://api.example.com/product");
Product product = JsonSerializer.Deserialize<Product>(json);


//Handling case differences
var options = new JsonSerializerOptions                     //JSON from APIs often uses camelCase (name)       
              {                                             //while C# uses PascalCase (Name).
                  PropertyNameCaseInsensitive = true        //Use JsonSerializerOptions to handle this.
              };
var product = JsonSerializer.Deserialize<Product>(json, options);



//Test: implement two methods that fetch JSON from a URL and return specific properties          
//          GetUserName - Returns the user's Name property
//          GetUserAge - Returns the user's Age property
//      The User class is already defined with Name, Age, and Email properties.
public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}

public class Solution
{
    public static async Task<string> GetUserName(string url)
    {
        using var client = new HttpClient();
        string json = await client.GetStringAsync(url);

        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        User user = JsonSerializer.Deserialize<User>(json, options);

        return user.Name;
    }

    public static async Task<int> GetUserAge(string url)
    {
        using var client = new HttpClient();
        string json = await client.GetStringAsync(url);

        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        User user = JsonSerializer.Deserialize<User>(json, options);

        return user.Age;
    }
}