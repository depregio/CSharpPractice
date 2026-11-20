//Checking file existence

//File.Exists checks whether a file exists at the specified path before you try to read or write to it.
//This prevents runtime exceptions when working with files that may or may not be present.

//Attempting to read a file that doesn't exist throws a FileNotFoundException.
//Checking existence first lets you handle missing files gracefully.


//Example of a simple check
string content = File.ReadAllText("missing.txt");   //Without checking: throws exception if file missing

if (File.Exists("data.txt"))                        //With checking: safe approach      //File.Exists returns a boolean
{
    string content2 = File.ReadAllText("data.txt");
}
else
{
    Console.WriteLine("File not found!");
}


//Common patterns
string GetConfig(string path)                       //Pattern 1: default value if missing
{
    if (File.Exists(path))
        return File.ReadAllText(path);

    return "default settings";
}

if (!File.Exists("log.txt"))                        //Pattern 2: create if missing
{
    File.WriteAllText("log.txt", "Log started");
}



//Test: write a method that safely reads a file.
//      If the file exists, return its contents.
//      If the file doesn't exist, return the string "File not found" instead of throwing an exception.
public class Solution
{
    public static string SafeReadFile(string filePath)
    {
        if (File.Exists(filePath))
            return File.ReadAllText(filePath);
        else
            return "File not found";
    }
}