//Writing text files

//The File.WriteAllText method is the simplest way to write text to a file in C#.
//It creates a new file, writes the specified string, and closes the file in one operation.
//Programs often need to give the user feedback about what happened, so this lesson pairs file writing with console output.

//How it works:
//When you call File.WriteAllText, the runtime opens (or creates) the file,
//writes the entire string, and closes the handle automatically.
//It does not report progress on its own, so it is common to follow the write with Console.WriteLine calls that confirm what was written.

//Key behaviours of File.WriteAllText:
//      - Creates the file if it doesn't exist.
//      - Overwrites the file if it already exists (no warning).
//      - Closes the file automatically after writing.

//File class methods:
//      METHOD                          DESCRIPTION
//      File.WriteAllText(path, text)	Writes string to file
//      File.WriteAllLines(path, lines)	Writes string array, one per line
//      File.AppendAllText(path, text)	Adds text to end of file


//Basic usage
File.WriteAllText("output.txt", "Hello, World!");           //Write a simple string to a file

File.WriteAllText("notes.txt", "Line 1\nLine 2\nLine 3");   //Write multiple lines (use \n inside the string)

File.WriteAllText("data.txt", "New content replaces old");  //Overwrite existing content


//Printing Confirmation Messages
string fileName = "report.csv";                 //You can embed variable values directly.
int line = 42;
string content = $"New content replaces old on line {line}";

File.WriteAllText(fileName, content);
Console.WriteLine($"Saved report in: {fileName}. Content: \"{content}\"");



//Test: write a method that does three things, in order:
//          Uses File.WriteAllText to write the provided content to the given file path.
//          Prints a confirmation line in the exact form: Successfully wrote to {filePath}.
//          Prints the content on the next line in the exact form: Content: { content}.
public class Solution
{
    public static void WriteToFile(string filePath, string content)
    {
        File.WriteAllText(filePath, content);

        Console.WriteLine($"Successfully wrote to {filePath}");

        Console.WriteLine($"Content: {content}");
    }
}