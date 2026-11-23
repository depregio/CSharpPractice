//HttpResponseMessage

//When you use GetAsync instead of GetStringAsync, you receive an HttpResponseMessage object
//that provides detailed information about the HTTP response.

//Common HTTP status codes:
//      CODE    MEANING	        IsSuccessStatusCode
//      200	    OK	            True
//      201	    Created	        True
//      204	    No Content	    True
//      400	    Bad Request	    False
//      404	    Not Found	    False
//      500	    Server Error	False


//GetAsync vs GetStringAsync
using System.Net;

string content = await client.GetStringAsync(url);          //GetStringAsync simply returns content directly

HttpResponseMessage response = await client.GetAsync(url);  //GetAsync returns HttpResponseMessage with full details


//Key properties of HttpResponseMessage
HttpResponseMessage response = await client.GetAsync(url);

HttpStatusCode status = response.StatusCode;                //StatusCode: the HTTP status code (200, 404, 500, etc.)
int statusInt = (int)response.StatusCode;                   //Cast to int: 200

bool success = response.IsSuccessStatusCode;                //IsSuccessStatusCode: true if status is 200-299

string body = await response.Content.ReadAsStringAsync();   //Content: access the response body



//Test: implement three methods to work with HttpResponseMessage:
//          GetStatusCode       - Make a GET request and return the status code as an integer
//          IsRequestSuccessful - Make a GET request and return whether the request was successful
//          ReadResponseContent - Make a GET request and return the response body as a string
public class Solution
{
    public static async Task<int> GetStatusCode(string url)
    {
        using var client = new HttpClient();

        HttpResponseMessage response = await client.GetAsync(url);

        return (int)response.StatusCode;
    }

    public static async Task<bool> IsRequestSuccessful(string url)
    {
        using var client = new HttpClient();

        HttpResponseMessage response = await client.GetAsync(url);

        return response.IsSuccessStatusCode;
    }

    public static async Task<string> ReadResponseContent(string url)
    {
        using var client = new HttpClient();

        HttpResponseMessage response = await client.GetAsync(url);

        return await response.Content.ReadAsStringAsync();
    }
}