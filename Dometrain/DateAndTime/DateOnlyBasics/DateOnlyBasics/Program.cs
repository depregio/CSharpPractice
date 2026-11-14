//DateOnly basics

//DateOnly represents a date without any time component—perfect for birthdays, holidays, or any scenario where time is irrelevant.


//Creating DateOnly values
DateOnly christmas = new DateOnly(2024, 12, 25);    //Using the constructor

DateTime now = DateTime.Now;                        //From an existing DateTime
DateOnly today = DateOnly.FromDateTime(now);

DateOnly parsed = DateOnly.Parse("2024-07-04");     //Parse from string


//Accessing properties
DateOnly date = new DateOnly(2024, 3, 15);

int year = date.Year;           //2024
int month = date.Month;         //3
int day = date.Day;             //15
DayOfWeek dow = date.DayOfWeek; //Friday


//Converting between types
DateOnly date2 = new DateOnly(2024, 6, 15);              //DateOnly to DateTime (requires time component)
DateTime dateTime = date2.ToDateTime(TimeOnly.MinValue);

DateTime now2 = DateTime.Now;                            //DateTime to DateOnly
DateOnly today2 = DateOnly.FromDateTime(now2);



//Test: create a method that takes year, month, and day as integers, creates a DateOnly from them, and returns the day of the week as a string.
public class Solution
{
    public static string GetDayOfWeek(int year, int month, int day)
    {
        DateOnly formattedDate = new DateOnly(year, month, day);
        return formattedDate.DayOfWeek.ToString();
    }
}