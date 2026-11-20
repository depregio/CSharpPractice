//Path manipulation

//The Path class provides methods for working with file and directory paths safely across different operating systems.

//Never concatenate paths with string concatenation (+). Use Path.Combine instead.

//Useful path methods:
//      METHOD                      DESCRIPTION	                    EXAMPLE
//      Path.Combine(a,b)	        Safely joins paths	            Path.Combine("dir", "file.txt") → "dir\\file.txt"
//      Path.GetFileName(p)	        Gets file name with extension	Path.GetFileName("dir\\file.txt") → "file.txt"
//      Path.GetExtension(p)	    Gets extension with dot	        Path.GetExtension("file.txt") → ".txt"
//      Path.GetDirectoryName(p)	Gets directory portion	        Path.GetDirectoryName("dir\\file.txt") → "dir"


//Path.Combine: Safe Path Building
string bad = directory + "\\" + fileName;           //Wrong. Breaks on different OS or edge cases

string good = Path.Combine(directory, fileName);    //Correct. Handles separators automatically
string multi = Path.Combine("C:\\", "Users", "Documents", "file.txt");

                                                            //Path.Combine handles trailing/leading slashes,
                                                            //so these all produce the same result:
string multi2 = Path.Combine("C:\\folder", "file.txt");     //C:\folder\file.txt
string multi3 = Path.Combine("C:\\folder\\", "file.txt");   //C:\folder\file.txt
string multi4 = Path.Combine("C:\\folder", "\\file.txt");   //C:\folder\file.txt


//Extracting path components
string fullPath = "C:\\Documents\\report.pdf";

string fileName = Path.GetFileName(fullPath);                   //"report.pdf"
string fileExtension = Path.GetExtension(fullPath);             //".pdf"
string fileTitle = Path.GetFileNameWithoutExtension(fullPath);  //"report"
string fileDirectory = Path.GetDirectoryName(fullPath);         //"C:\\Documents"



//Test: implement three methods:
//          BuildFilePath       - Combine a directory and filename safely using Path.Combine
//          GetFileNameFromPath - Extract just the filename from a full path
//          GetFileExtension    - Extract the file extension (including the dot)
public class Solution
{
    public static string BuildFilePath(string directory, string fileName)
    {
        return Path.Combine(directory, fileName);
    }

    public static string GetFileNameFromPath(string filePath)
    {
        return Path.GetFileName(filePath);
    }

    public static string GetFileExtension(string filePath)
    {
        return Path.GetExtension(filePath);
    }
}