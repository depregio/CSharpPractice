//Async file I/O with Task<T>

//When reading files asynchronously, use File.ReadAllTextAsync() which returns Task<string>.
//This allows your application to remain responsive while waiting for disk operations.

//File operations involve disk I/O which is slow compared to CPU operations.
//Using async methods prevents your application from freezing while waiting for the task to finish.

//The System.IO.File class provides several async methods for reading files.


//Why async file I/O?
using System.Runtime.CompilerServices;

string content = File.ReadAllText("data.txt");              //Synchronous. Blocks the thread until file is read.

string content2 = await File.ReadAllTextAsync("data.txt");  //Asynchronous. Frees the thread while waiting for I/O.


//Async file reading methods
string text = await File.ReadAllTextAsync("document.txt");  //Reads entire file as a single string.

string[] lines = await File.ReadAllLinesAsync("log.txt");   //Reads file as an array of lines (splits on newlines).

byte[] bytes = await File.ReadAllBytesAsync("image.png");   //Reads file as raw byte arrays (for binary files).


//Choosing the right method
string json = await File.ReadAllTextAsync("config.json");       //Use ReadAllTextAsync for text content you'll process as a whole.

string[] logEntries = await File.ReadAllLinesAsync("app.log");  //Use ReadAllLinesAsync when you need to process line by line.
foreach (string entry in logEntries)
{
    Console.WriteLine(entry);
}

byte[] imageData = await File.ReadAllBytesAsync("photo.jpg");   //Use ReadAllBytesAsync for binary files (images, PDFs, etc.).


//File.ReadAllTextAsync in detail
//public static Task<string> ReadAllTextAsync(string path)  //Signature

static async Task<string> GetFileContentAsync(string path)  //Usage
{
    string text = await File.ReadAllTextAsync(path);        //Await unwraps the Task<string> to get the actual string.
    return text;
}



//Test: create an async method that reads a file and returns its content prefixed with "Content: ".
//      This simulates a real-world scenario where you fetch data from a file asynchronously.
public class Solution
{
    public static async Task<string> ReadFileAsync(string filePath)
    {
        string content = await File.ReadAllTextAsync(filePath);
        return "Content: " + content;
    }
}