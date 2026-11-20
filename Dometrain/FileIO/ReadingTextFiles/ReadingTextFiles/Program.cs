//Reading text files

//File.ReadAllText is the simplest way to read an entire text file into a string in C#.
//It opens the file, reads all content, closes it, and returns the text into a string.

//File.ReadAllLines does the same but returns every line as a string array.


//Basic usage
string content = File.ReadAllText("myfile.txt");                //Reads entire file into a string

string content2 = File.ReadAllText("myfile.txt", Encoding.UTF8); //Reads with a specific encoding    //Requires using System.Text;


//Check if file exists before reading
if (File.Exists(filePath))                      //An exception could be thrown without this check
{
    string text = File.ReadAllText(filePath);   //ReadAllText handles opening and closing the file automatically
}



//Test: write a method that reads the contents of a text file and prints them to the console.
//      The file path is provided as a parameter.
public class Solution
{
    public static void ReadAndPrintFile(string filePath)
    {
        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine(fileContent);
    }
}