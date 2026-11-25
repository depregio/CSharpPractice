//Handling HTTP errors

//HTTP requests can fail for many reasons: network issues, server errors, or invalid URLs.
//Proper error handling ensures your application remains stable when things go wrong.


//HttpRequestException
try
{
    var response = await client.GetAsync(url);
}
catch (HttpRequestException ex) //HttpRequestException is thrown when an HTTP request fails at the network level
{                                                                   //(connection refused, DNS failure, timeout).
    Console.WriteLine($"Request failed: {ex.Message}");
}


//Checking status codes
var response = await client.GetAsync(url);  //Not all completed requests are successful. 
                                            //A server might return 404 (Not Found) or 500 (Server Error).
if (response.IsSuccessStatusCode)           //Use IsSuccessStatusCode to check for 2xx responses.
{
    var content = await response.Content.ReadAsStringAsync();   //Status code is 200-299
}
else
{
    Console.WriteLine($"Error: {response.StatusCode}");         //Handle error status codes (4xx, 5xx)
}


//Combining Both Approaches
try
{
    var response = await client.GetAsync(url);

    if (response.IsSuccessStatusCode)
    {
        return await response.Content.ReadAsStringAsync();
    }
    return "Server returned an error";
}
catch (HttpRequestException)
{
    return "Network error occurred";
}



//Test: create a method that safely fetches data from a URL and handles all error scenarios.
public class Solution
{
    public static async Task<string> SafeFetch(string url)
    {
        using var client = new HttpClient();

        try
        {
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
                return "Success";
            else
                return "Failed";

        }
        catch(HttpRequestException)
        {
            return "Failed";
        }
    }
}