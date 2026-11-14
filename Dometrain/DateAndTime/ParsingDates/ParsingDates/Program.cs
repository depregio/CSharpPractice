//Parsing Date strings

//DateTime.Parse and DateTime.TryParse convert text into DateTime values.
//Use Parse when you're confident the input is valid, and TryParse for safe parsing without exceptions.

//DateTime.Parse converts a string to DateTime, throwing FormatException if the string is invalid.

//DateTime.TryParse returns true if parsing succeeds, false otherwise. Never throws an exception for invalid input.

//Recognized Formats
//      FORMAT      EXAMPLE
//      ISO 8601	"2024-03-15"
//      Long date	"March 15, 2024"
//      Short date	"3/15/2024"
//      With time	"2024-03-15 14:30:00"


//DateTime.Parse
DateTime date1 = DateTime.Parse("2024-03-15");
DateTime date2 = DateTime.Parse("March 15, 2024");
DateTime date3 = DateTime.Parse("15/03/2024 14:30");


//DateTime.TryParse
bool success = DateTime.TryParse("2024-03-15", out DateTime result);    //success = true, result = March 15, 2024
bool failed = DateTime.TryParse("not a date", out DateTime invalid);    //failed = false, invalid = DateTime.MinValue


//Discarding the out parameter
if (DateTime.TryParse(userInput, out _))    //When you only need to check validity, use the discard pattern out _
{
    Console.WriteLine("Valid date!");
}



//Test: implement three methods:
//          IsValidDate(string dateString)                      - Return true if the string is a valid date, false otherwise
//          ParseDate(string dateString)                        - Parse and return the DateTime (input is guaranteed valid)
//          ParseAndFormat(string dateString, string format)    - Parse the date and return it formatted, or return "Invalid" if parsing fails
public class Solution
{
    public static bool IsValidDate(string dateString)
    {
        return DateTime.TryParse(dateString, out _);
    }

    public static DateTime ParseDate(string dateString)
    {
        return DateTime.Parse(dateString);
    }

    public static string ParseAndFormat(string dateString, string format)
    {
        if (DateTime.TryParse(dateString, out DateTime parsedDate))
            return parsedDate.ToString(format);
        else
            return "Invalid";
    }
}