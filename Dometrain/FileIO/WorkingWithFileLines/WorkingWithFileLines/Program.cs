//Working with file lines

//While File.ReadAllText reads an entire file as one string,
//File.ReadAllLines reads a file and returns each line as a separate element in a string array.
//This is ideal when you need to process files line by line.

//Common use cases:
//      METHOD          USE WHEN
//      ReadAllLines	Processing CSV files, log files, configuration files
//      WriteAllLines	Saving lists, exporting data, creating reports


//ReadAllLines vs ReadAllText
string content = File.ReadAllText("data.txt");  //ReadAllText: returns one string with newlines //content = "Apple\nBanana\nCherry"

string[] lines = File.ReadAllLines("data.txt"); //ReadAllLines - returns array of strings       //lines[0] = "Apple"
                                                                                                //lines[1] = "Banana"
                                                                                                //lines[2] = "Cherry"


//WriteAllLines: the counterpart
string[] fruits = { "Apple", "Banana", "Cherry" };  //Writes an array of strings as separate lines
File.WriteAllLines("output.txt", fruits);           //Creates file with each fruit on its own line



//Test: implement a method that reads a text file and returns its contents as an array of strings,
//      where each element represents one line from the file.
public class Solution
{
    public static string[] ReadFileLines(string filePath)
    {
        return File.ReadAllLines(filePath);
    }
}