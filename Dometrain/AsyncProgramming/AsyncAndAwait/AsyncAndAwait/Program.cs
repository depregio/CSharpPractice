//Async and await

//The async and await keywords allow you to write asynchronous code that looks and behaves like synchronous code,
//making it easier to read and maintain while keeping your application responsive.

//Why Use async/await?
//Without async programming, when your code waits for a slow operation
//(like reading a file, calling an API, or waiting for a timer), the entire thread is blocked.

//This means:
//      In a UI application, the interface freezes
//      In a web server, fewer requests can be handled
//      Resources are wasted while doing nothing
//      Async/await solves this by allowing the thread to do other work while waiting:

Thread.Sleep(2000);             //Synchronous, thread is blocked for 2 seconds
Console.WriteLine("Done");

await Task.Delay(2000);         //Asynchronous, thread is free to do other work
Console.WriteLine("Done");


//The async keyword
static async Task DoWorkAsync()     //Mark a method with async to enable the use of await inside it.
{                                   //A method with a Task return type returns nothing. If you need to return something use Task<T>.
    await Task.Delay(1000);         
    Console.WriteLine("Work complete!");
}


//The await keyword
await Task.Delay(500);              //Use await before any Task to pause execution until that task completes.
string data = await FetchDataAsync();   //Wait for data

static async Task<string> FetchDataAsync()
{
    await Task.Delay(1000);         //You can only await something that returns an awaitable (Task, Task<T>, ValueTask<T>, etc.).
    return "Hello from the server";
}


//Common async operations
await Task.Delay(1000);                         //Delay without blocking

static async Task<string> GetMessageAsync()     //Returns a value from async method
{
    await Task.Delay(3000);
    return "Hello!";
}



//Test: create an async method from scratch that:
//          Is named DelayedGreetingAsync
//          Accepts a name (string) and delayMs (int) as parameters
//          Returns Task<string>
//          Awaits a Task.Delay for the specified number of milliseconds
//          Returns a greeting in the format: "Hello, {name}!"
public class Solution
{
    public static async Task<string> DelayedGreetingAsync(string name, int delayMs)
    {
        await Task.Delay(delayMs);
        return $"Hello, {name}!";
    }
}