//HTTP request headers

//HTTP headers provide additional information with requests and responses.
//They're used for authentication, content negotiation, caching, and more.

//The Authorization header sends credentials to authenticate with an API. Bearer-tokens are the most common format.
//The Accept header tells the server what content types your client can handle.

//Common Headers
//      HEADER          PURPOSE	                    EXAMPLE
//      Authorization	Authentication credentials	Bearer abc123
//      Accept	        Preferred response format	application/json
//      Content-Type	Format of request body	    application/json
//      User-Agent	    Client identification	    MyApp/1.0


//DefaultRequestHeaders
var client = new HttpClient();  //HttpClient.DefaultRequestHeaders is a collection that applies headers to every request made by that client instance.

client.DefaultRequestHeaders.Add("X-Custom-Header", "value");               //Add a single header example

var response = await client.GetStringAsync("https://api.example.com/data"); //Headers are sent with every request from this client


//Authorization Header
client.DefaultRequestHeaders.Add("Authorization", "Bearer my-token-here");  //Bearer token authentication

string token = "abc123";
client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");       //Or using string interpolation


//Accept Header
client.DefaultRequestHeaders.Add("Accept", "application/json");     //Request JSON responses

client.DefaultRequestHeaders.Add("Accept", "application/xml");      //Request XML responses

client.DefaultRequestHeaders.Add("Accept", "text/plain");           //Request plain text



//Test: create a method that:
//          Creates an HttpClient
//          Adds an Authorization header with format Bearer {authToken}
//          Adds an Accept header with the provided acceptType
//          Makes a GET request to the URL and returns the response content
public class Solution
{
    public static async Task<string> FetchWithHeaders(string url, string authToken, string acceptType)
    {
        using var client = new HttpClient();

        client.DefaultRequestHeaders.Add("Authorization", authToken);
        client.DefaultRequestHeaders.Add("Accept", acceptType);

        return await client.GetStringAsync(url);
    }
}