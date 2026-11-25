//PUT and DELETE requests

//While GET retrieves data and POST creates new resources, PUT and DELETE complete the CRUD operations by updating and removing resources.

//CRUD (Create, Read, Update, Delete): the four basic things you can do with stored data. It's the thing most APIs are built around.

//Common status codes:
//      STATUS CODE	MEANING	    TYPICAL USE
//      200 	    OK	        Successful update/delete
//      204	        No Content	Successful delete (no body)
//      404	        Not Found	Resource doesn't exist
//      400	        Bad Request	Invalid data sent


//PUT requests: updating resources
using System.Text;

using var client = new HttpClient();        //PutAsync sends data to update an existing resource at a specific URL.
var content = new StringContent(
    "{\"name\":\"Updated Name\"}",
    Encoding.UTF8,
    "application/json"
);
var response = await client.PutAsync("https://api.example.com/users/1", content);


//DELETE requests: removing resources
using var client = new HttpClient();        //DeleteAsync removes a resource at the specified URL. No request body is needed.
var response = await client.DeleteAsync("https://api.example.com/users/1");


//Checking the method type
if (method.ToUpper() == "PUT")      //You can use string comparison to determine which HTTP method to execute
{
    //Execute PUT request
}
else if (method.ToUpper() == "DELETE")
{
    //Execute DELETE request
}



//Test: implement a method that:
//          - Takes a URL, HTTP method ("PUT" or "DELETE"), and optional JSON content.
//          - Executes the appropriate HTTP request based on the method parameter.
//          - For PUT requests, send the jsonContent as the request body.
//          - For DELETE requests, no body is needed.
//          - Returns the HTTP status code as an integer.
public class Solution
{
    public static async Task<int> ExecuteRequest(string url, string method, string jsonContent = null)
    {
        using var client = new HttpClient();

        switch (method.ToUpper())
        {
            case "PUT":
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                var responsePut = await client.PutAsync(url, content);

                return (int)responsePut.StatusCode;

            case "DELETE":
                var responseDelete = await client.DeleteAsync(url);

                return (int)responseDelete.StatusCode;

            default:
                throw new ArgumentException($"Unsupported method: {method}");
        }
    }
}