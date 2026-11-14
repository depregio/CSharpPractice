//DateTime Basics

//The DateTime struct in C# represents dates and times.
//It's the foundation for working with temporal data in .NET applications.

//Every DateTime value has properties to access its parts.


//Getting current date and time
DateTime now = DateTime.Now;    //Gets current date AND time    //2024-03-15 14:30:45

DateTime today = DateTime.Today;    //Gets today's date (time is 00:00:00)  //2024-03-15 00:00:00


//Accessing individual component
DateTime now2 = DateTime.Now;

int year = now2.Year;      //024
int month = now2.Month;    //1-12
int day = now2.Day;        //1-31
int hour = now2.Hour;      //0-23
int minute = now2.Minute;  //0-59
int second = now2.Second;  //0-59


//Building output with concatenation
Console.WriteLine(year + "-" + month + "-" + day);  //Combine values using string concatenation //2024-3-15


//Test: write a method that prints:
//          Today's date in the format:     Year-Month-Day
//          The current time in the format: Hour-Minute-Second
//      Each value should be printed on its own line.
public class Solution
{
    public static void PrintDateAndTime()
    {
        DateTime now = DateTime.Now;

        Console.WriteLine(now.Year + "-" + now.Month + "-" + now.Day);
        Console.WriteLine(now.Hour + ":" + now.Minute + ":" + now.Second);
    }
}