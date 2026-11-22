//Introduction to HttpClient

//HttpClient is the primary class in .NET for sending HTTP requests and receiving HTTP responses from web services and APIs.

//Creating an HttpClient is straightforward, you simply instantiate it using the new keyword.

//HttpClient implements IDisposable,
//which means it holds unmanaged resources (like network connections) that should be released when you're done.

//Creating and disposing HttpClient frequently causes a serious issue called socket exhaustion (or socket starvation).
//When you dispose an HttpClient, the underlying socket enters a TIME_WAIT state
//for up to 240 seconds (because of packets that might still be in flight) before being fully released.
//Under high load, you can exhaust all available sockets.

//Why Use HttpClient?
//HttpClient handles all the complexity of HTTP communication:
//      - Sending GET, POST, PUT, DELETE requests
//      - Managing request headers and content
//      - Handling responses and status codes
//      - Supporting async/await patterns


//Creating an HttpClient
HttpClient client = new HttpClient();   //Basic creation

HttpClient client2 = new();             //Or with target-typed new (C# 9+)


//The using keyword and disposal
using (HttpClient client3 = new HttpClient())   //Option 1: using statement (auto-disposes when scope ends)
{
    //Make requests here                        //client is automatically disposed when this block ends
}

using HttpClient client4 = new HttpClient();    //Option 2: using declaration (C# 8+, disposes at end of method block containing it)
//Make requests here                            //client is disposed when the method returns


//The socket exhaustion problem
for (int i = 0; i < 1000; i++)                                                  //BAD: Creating new HttpClient per request
{
    using HttpClient client5 = new HttpClient();                                //Socket goes into TIME_WAIT state after disposal
    var response = await client5.GetAsync("https://api.example.com/data");      //Sockets pile up faster than they can be recycled
}                                                                               //Result: SocketException, no more sockets available


//Good solution for simple scenarios: reuse the same instance (shared client)
public class ApiService
{
    private static readonly HttpClient _client = new HttpClient();      //Single instance, reused for all requests
                                                                        //Static is just a convenient way to make sure there's only one.
    public async Task<string> GetDataAsync(string url)
    {
        return await _client.GetStringAsync(url);
    }
}

//DNS caching issue:
//DNS is looked up only when a new connection opens. A static client keeps pooled connections open,
//so it keeps using the old IP even if the server's address changes.
private static readonly HttpClient _client = new HttpClient();
//If api.example.com changes from 1.2.3.4 to 5.6.7.8, _client will still try to connect to 1.2.3.4
//For long-running applications (web servers, background services), this is a significant concern. Use IHttpClientFactory instead.

//Going further: IHttpClientFactory (optional)
//In larger applications, such as web apps built with ASP.NET Core, you usually don't create HttpClient yourself.
//Instead you ask the framework for one through IHttpClientFactory,
//which reuses connections and refreshes DNS for you, avoiding both problems above.
//It relies on a technique called dependency injection, which is beyond this course, so you don't need it for this exercise.
//For now, the rule is simple: create an HttpClient once and reuse it.

//Dependency injection = a class receives what it needs through its constructor instead of creating it.
//The framework (ASP.NET Core) supplies them from a container.



//Test: create and return a new HttpClient instance. Since you're returning it to the caller,
//      don't wrap it in a using statement, the caller will be responsible for managing its lifecycle and disposal.
//      Note: In real applications, prefer IHttpClientFactory or a shared static instance to avoid socket exhaustion.
public class Solution
{
    //The caller must manage HttpClient disposal with a using statement
    public static HttpClient CreateHttpClient()
    {
        return new HttpClient();
    }
}