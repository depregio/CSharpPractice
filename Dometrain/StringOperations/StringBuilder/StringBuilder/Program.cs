//StringBuilder

//StringBuilder is a mutable string class that efficiently builds strings through multiple modifications,
//avoiding the performance cost of creating new string objects with each concatenation.

//Why StringBuilder?
//Strings in C# are immutable, every modification creates a new string object.
//When building strings in loops, this creates many temporary objects.

//Useful methods:
//      METHOD              DESCRIPTION	            EXAMPLE
//      Append(value)	    Adds text to the end	sb.Append("text")
//      AppendLine(value)	Adds text + newline	    sb.AppendLine("line")
//      AppendLine()	    Adds just a newline	    sb.AppendLine()
//      ToString()	        Converts to string	    sb.ToString()
//      Clear()	            Empties the builder	    sb.Clear()

//using System.Text; is needed to use StringBuilder


//Example in difference of usage
using System.Text;

string result = "";
for (int i = 0; i < 1000; i++)  //Inefficient. Creates many string objects.
{
    result += i.ToString();     //New string each iteration.
}

StringBuilder sb = new StringBuilder();
for (int i = 0; i < 1000; i++)  //Efficient. Single StringBuilder object.
{
    sb.Append(i);
}
string result2 = sb.ToString();


//Append vs AppendLine
StringBuilder sb2 = new StringBuilder();

sb2.Append("Hello");        //Adds text, no newline
sb2.Append(" World");       //Result: "Hello World"
sb2.Clear();

sb2.AppendLine("Line 1");   //Adds text + newline
sb2.AppendLine("Line 2");   //Result: "Line 1\nLine 2\n"
sb2.Clear();

sb2.Append("Item: ");
sb2.AppendLine("Apple");    //Result: "Item: Apple\n"
sb2.Clear();



//Test: create a method that builds a formatted report using StringBuilder.
//      The report should have:
//          A title on the first line
//          A line of dashes (same length as title)
//          Numbered items, each on its own line
//      Use Append() for building each numbered line and AppendLine() to add line breaks.
//      Return the final string without trailing newlines.
public class Solution
{
    public static string BuildReport(string title, string[] items)
    {
        StringBuilder report = new StringBuilder();
        
        report.AppendLine(title);

        string dashesLine = new string('-', title.Length);      //Creates a string of same char repeated a specific number of time
        report.AppendLine(dashesLine);

        int itemNumber = 0;
        foreach(string item in items)
        {
            report.AppendLine($"{++itemNumber}. {item}");
        }

        return report.ToString().TrimEnd();     //TrimEnd() removes the trailing newline
    }
}