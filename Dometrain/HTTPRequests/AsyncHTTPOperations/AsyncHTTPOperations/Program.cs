//Async HTTP operations

//HttpClient methods are inherently asynchronous, returning Task objects that represent ongoing operations.
//Using async/await properly ensures your application remains responsive while waiting for HTTP responses.

//Task.WhenAll takes multiple tasks and returns a single task that completes when all input tasks finish.
//It preserves the order of results matching the order of input tasks.

//Key points:
//      CONCEPT         DESCRIPTION
//      async	        Marks a method as asynchronous
//      await	        Pauses execution until the task completes
//      Task<T>	        Represents an async operation returning type T
//      Task.WhenAll	Awaits multiple tasks concurrently


//Sequential vs concurrent requests
var result1 = await client.GetStringAsync(url1);        //Sequential (slower, each request waits for the previous)
var result2 = await client.GetStringAsync(url2);
var result3 = await client.GetStringAsync(url3);

var task1 = client.GetStringAsync(url1);                //Concurrent (faster, all requests run simultaneously)
var task2 = client.GetStringAsync(url2);
var task3 = client.GetStringAsync(url3);
var results = await Task.WhenAll(task1, task2, task3);  //WhenAll here starts nothing. It only waits until all three tasks have finished.


//Task.WhenAll
string[] urls = [ /*Multiple url strings here*/ ];

var tasks = urls.Select(url => client.GetStringAsync(url));     //Using LINQ to create tasks from a collection
string[] results = await Task.WhenAll(tasks);                   //(Select only visits every item and turns each one into something new)



//Test: create a method that fetches content from multiple URLs concurrently using Task.WhenAll.
//      Return an array of string responses in the same order as the input URLs.
public class Solution
{
    public static async Task<string[]> FetchAllConcurrently(string[] urls)
    {
        using var client = new HttpClient();

        var tasks = urls.Select(url => client.GetStringAsync(url));

        string[] results = await Task.WhenAll(tasks);

        return results;
    }
}