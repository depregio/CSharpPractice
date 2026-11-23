//Using BaseAddress

//BaseAddress is a property on HttpClient that sets a base URL for all requests.
//Instead of repeating the full URL in every request, you set the base once and use relative paths.

//The base URL should end with a trailing slash (/) for relative paths to resolve correctly.

//Setting BaseAddress
using System.Net;
var client = new HttpClient();
client.BaseAddress = new Uri("https://api.example.com/");   //Now you can use relative paths

string result = await client.GetStringAsync("users");       //Calls https://api.example.com/users
string data = await client.GetStringAsync("products");      //Calls https://api.example.com/products


//Without BaseAddress vs with BaseAddress
await client.GetStringAsync("https://api.example.com/users");       //Without BaseAddress: repeating the base URL
await client.GetStringAsync("https://api.example.com/products");
await client.GetStringAsync("https://api.example.com/orders");

client.BaseAddress = new Uri("https://api.example.com/");           //With BaseAddress: cleaner and more maintainable
await client.GetStringAsync("users");       //https://api.example.com/ + users
await client.GetStringAsync("products");    //https://api.example.com/ + products
await client.GetStringAsync("orders");      //https://api.example.com/ + orders


//Important: trailing slash
client.BaseAddress = new Uri("https://api.example.com/");       //Correct. Base ends with /
await client.GetStringAsync("users");                           //https://api.example.com/users

client.BaseAddress = new Uri("https://api.example.com/v2");     //Careful. A base with a path but no trailing slash drops the last segment
await client.GetStringAsync("items");                           //https://api.example.com/items (v2 is lost)



//Test: create a method that:
//          Creates an HttpClient instance
//          Sets the BaseAddress property to the provided base URL
//          Fetches content from the relative path using GetStringAsync on the client
//          Returns the response content
public class Solution
{
    public static async Task<string> FetchWithBaseAddress(string baseUrl, string relativePath)
    {
        var client = new HttpClient();

        client.BaseAddress = new Uri(baseUrl);

        string responseText = await client.GetStringAsync(relativePath);

        return responseText;
    }
}