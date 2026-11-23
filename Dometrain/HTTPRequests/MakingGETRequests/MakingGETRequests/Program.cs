//Making GET requests

//The most common HTTP operation is the GET request, used to retrieve data from a server.
//HttpClient provides several methods to make GET requests simple and efficient.

//Why Use GetStringAsync?
//GetStringAsync is the simplest way to fetch text content from a URL. It:
//      Sends a GET request to the specified URL
//      Waits for the response
//      Returns the response body as a string
//      Throws an exception if the request fails


//GetStringAsync method
using var client = new HttpClient();

string content = await client.GetStringAsync("https://api.example.com/data");   //Fetches the response body as a string


//The using statement
using var clien2 = new HttpClient();                    //Ensures HttpClient is properly disposed after use

using (var client3 = new HttpClient())                  //Or with explicit scope
{
    string result = await client.GetStringAsync(url);
}


//Async/Await pattern
public static async Task<string> FetchData(string url)  //Method must be marked async to use await
{
    using var client = new HttpClient();                //HTTP requests are asynchronous operations.
    return await client.GetStringAsync(url);            //The await keyword pauses execution until the request completes.
}



//Test: create a method that fetches text content from a given URL using GetStringAsync and returns it as a string.
public class Solution
{
    public static async Task<string> FetchContent(string url)
    {
        using var client = new HttpClient();
        return await client.GetStringAsync(url);
    }
}