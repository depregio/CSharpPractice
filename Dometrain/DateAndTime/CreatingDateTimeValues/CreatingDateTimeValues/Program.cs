//Creating DateTime values

//The DateTime struct provides several constructors to create specific dates and times.
//You can specify just a date, or include time components for precise moments.

//The Hour parameter uses 24 hour format.


//Date-Only Constructor
DateTime christmas = new DateTime(2024, 12, 25);    //DateTime(year, month, day)    //December 25, 2024 at 12:00:00 AM (midnight)


//Date and Time Constructor
DateTime newYear = new DateTime(2025, 1, 1, 0, 0, 0);   //DateTime(year, month, day, hour, minute, second)  //January 1, 2025 at 12:00:00 AM

DateTime lunch = new DateTime(2024, 6, 15, 12, 30, 0);  //June 15, 2024 at 12:30:00 PM



//Test: create a DateTime representing July 4, 1990 at 2:30:00 PM and print it to the console.
public class Solution
{
    public static void PrintBirthday()
    {
        DateTime birthday = new DateTime(1990,7,4,14,30,0);
        Console.WriteLine(birthday);
    }
}