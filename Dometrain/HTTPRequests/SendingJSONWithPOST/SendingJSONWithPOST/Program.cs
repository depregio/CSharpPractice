//Sending JSON with POST

//When working with modern APIs, you'll often need to send JSON data in your POST requests.
//.NET provides two approaches: manual serialization with StringContent and the convenient PostAsJsonAsync extension method.


//Required namespaces
using System.Net.Http.Json;     //Needed for PostAsJsonAsync
using System.Text;              //Needed for Encoding.UTF8
using System.Text.Json;         //Needed for JsonSerializer


//Using StringContent with JSON
var data = new { Name = "Alice", Score = 100 };     //The manual approach gives you full control over the serialization process
string json = JsonSerializer.Serialize(data);

var content = new StringContent(json, Encoding.UTF8, "application/json");
var response = await client.PostAsync(url, content);


//Using PostAsJsonAsync
var data = new { Name = "Alice", Score = 100 };     //The PostAsJsonAsync extension method handles serialization automatically
var response = await client.PostAsJsonAsync(url, data);



//Test: implement two methods that POST a Person object as JSON:
//          PostJsonContent - Use JsonSerializer.Serialize and StringContent with the content type "application/json"
//          PostWithJsonExtension - Use PostAsJsonAsync for a cleaner approach
//          Both methods should return the HTTP status code as an integer.
public class Solution
{
    public static async Task<int> PostJsonContent(string url, string name, int age)
    {
        Person person = new Person { Name = name, Age = age };
        string jsonPerson = JsonSerializer.Serialize(person);
        var content = new StringContent(jsonPerson, Encoding.UTF8, "application/json");

        using var client = new HttpClient();
        var response = await client.PostAsync(url, content);

        return (int)response.StatusCode;
    }

    public static async Task<int> PostWithJsonExtension(string url, string name, int age)
    {
        Person person = new Person { Name = name, Age = age };

        using var client = new HttpClient();
        var response = await client.PostAsJsonAsync(url, person);

        return (int)response.StatusCode;
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}