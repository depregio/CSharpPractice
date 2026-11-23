//Checking status codes

//HTTP status codes are three-digit numbers that indicate the result of an HTTP request.
//They help you understand whether a request succeeded, failed, or requires further action.

//.NET provides the HttpStatusCode enum for type: safe status code comparisons.

//Common status code categories:
//      RANGE   CATEGORY	    MEANING
//      2xx	    Success	        Request was successful
//      3xx	    Redirection	    Further action needed
//      4xx	    Client Error	Problem with the request
//      5xx	    Server Error	Server failed to fulfill request


//Common status codes
using System.Net;

HttpStatusCode.OK                   //200: Success
HttpStatusCode.Created              //201: Resource created
HttpStatusCode.BadRequest           //400: Invalid request
HttpStatusCode.NotFound             //404: Resource not found
HttpStatusCode.InternalServerError  //500: Server error


//Checking status codes
var response = await client.GetAsync(url);

if (response.StatusCode == HttpStatusCode.OK)   //Using the enum (preferred)
{
    Console.WriteLine("Success!");
}

if ((int)response.StatusCode == 200)            //Using the integer value
{
    Console.WriteLine("Success!");
}

if (response.IsSuccessStatusCode)               //Using IsSuccessStatusCode for any 2xx response
{
    Console.WriteLine("Some kind of success!");
}



//Test: write a method that makes a GET request and returns a string based on the status code:
//          Return "OK" if the status code is 200
//          Return "Not Found" if the status code is 404
//          Return "Error" for any other status code
public class Solution
{
    public static async Task<string> CheckStatusCode(string url)
    {
        var client = new HttpClient();

        HttpResponseMessage response = await client.GetAsync(url);

        if (response.StatusCode == HttpStatusCode.OK)
            return "OK";
        else if (response.StatusCode == HttpStatusCode.NotFound)
            return "Not Found";
        else
            return "Error";
    }
}