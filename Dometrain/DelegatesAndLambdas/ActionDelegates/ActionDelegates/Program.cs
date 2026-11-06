//Action delegates

//Action is a built-in delegate type for methods that return void.
//Instead of defining your own delegate, you can use Action directly.


//Action vs custom delegates
using System.Threading.Channels;

public delegate void PrintMessage(string msg);  //Custom delegate (what we did before)
PrintMessage print1 = PrintMessage;
print1("Hello");

Action<string> print2 = PrintMessage;           //Built-in Action (same thing, no definition needed)
print2("Hello");

static void PrintMessage(string msg) { Console.WriteLine(msg); }


//Action Variations
Action doSomething = () => Console.WriteLine("Done");               //No parameters

Action<string> greet = name => Console.WriteLine($"Hello, {name}"); //One parameter //Action<string> greet = (name) ... is also valid

Action<string, int> repeat = (msg, times) => {                      //Multiple parameters (up to 16)
    for (int i = 0; i < times; i++)
        Console.WriteLine(msg);
};


//Using action as a parameter
static void ProcessItems(string[] items, Action<string> processor)
{
    foreach (var item in items)
    {
        processor(item);    //Call the Action
    }
}

//Usage
ProcessItems(names, name => Console.WriteLine(name.ToUpper()));



//Test: implement ExecuteActions that takes an array of messages and an Action<string, List<string>> delegate.
//      For each message, invoke the action to log it. Return all logged messages joined by newlines.
//      The starter code includes helper methods LogMessage and LogWithTimestamp that match the Action<string, List<string>> signature.
public class Solution
{
    public static string ExecuteActions(string[] messages, Action<string, List<string>> logger)
    {
        List<string> messageLog = new List<string>();

        foreach (var message in messages)
        {
            logger(message, messageLog); //The list acts as the “out channel” the logger writes into.
        }

        return string.Join("\n", messageLog);
    }

    public static void LogMessage(string message, List<string> output)
    {
        output.Add($"[LOG] {message}");
    }

    public static void LogWithTimestamp(string message, List<string> output)
    {
        output.Add($"[2024-01-01] {message}");
    }
}