//Making POST requests

//While GET requests retrieve data, POST requests send data to a server.
//This is commonly used for submitting forms, creating resources, or sending data to an API.

//GET vs POST
//      ASPECT          GET	            POST
//      Purpose	        Retrieve data	Send data
//      Request body	None	        Contains data
//      Method          GetAsync(url)	PostAsync(url, content)


//PostAsync method
using System.Text;      //Needed for Encoding.UTF8

var response = await client.PostAsync(url, content);    //PostAsync sends data to a URL and returns HttpResponseMessage


//StringContent for request body
var content = new StringContent("Hello", Encoding.UTF8, "text/plain");  //To send text data, wrap it in a StringContent object
                                                                        //Create content with text, encoding, and media type
var jsonContent = new StringContent("{\"name\":\"John\"}", Encoding.UTF8, "application/json");  //For JSON data


//Complete POST example
using var client = new HttpClient();
var content = new StringContent("my data", Encoding.UTF8, "text/plain");
var response = await client.PostAsync("https://api.example.com/submit", content);
int statusCode = (int)response.StatusCode;



//Test: create a method that sends a POST request with string data and returns the HTTP status code.
public class Solution
{
    public static async Task<int> PostData(string url, string data)
    {
        using var client = new HttpClient();

        var content = new StringContent(data, Encoding.UTF8, "text/plain");

        var postResponse = await client.PostAsync(url, content);

        return (int)postResponse.StatusCode;
    }
}