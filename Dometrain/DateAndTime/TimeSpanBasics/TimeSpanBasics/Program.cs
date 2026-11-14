//TimeSpan basics

//TimeSpan represents a duration of time, the difference between two points in time or a fixed time interval.

//TimeSpan has two sets of properties—component values and total values:
//      PROPERTY        DESCRIPTION	                    EXAMPLE (1 day, 6 hours)
//      Days	        Whole days component	        1
//      Hours	        Hours component (0-23)	        6
//      TotalDays	    Total as fractional days	    1.25
//      TotalHours	    Total as fractional hours	    30.0
//      TotalMinutes	Total as fractional minutes     1800.0


//Creating TimeSpan values
TimeSpan ts1 = new TimeSpan(1, 30, 0);      //1 hour, 30 minutes, 0 seconds     //Using constructors  
TimeSpan ts2 = new TimeSpan(2, 12, 30, 45); //2 days, 12 hours, 30 min, 45 sec

TimeSpan oneDay = TimeSpan.FromDays(1);     //Using static factory methods (preferred)        
TimeSpan twoHours = TimeSpan.FromHours(2);
TimeSpan thirtyMinutes = TimeSpan.FromMinutes(30);
TimeSpan tenSeconds = TimeSpan.FromSeconds(10);


//Getting TimeSpan from date subtraction
DateTime start = new DateTime(2024, 1, 1);
DateTime end = new DateTime(2024, 1, 15);

TimeSpan difference = end - start;          //14 days


//Total vs component properties
TimeSpan span = new TimeSpan(1, 6, 30, 0);  //1 day, 6 hours, 30 minutes

int days = span.Days;                       //1 (component)
int hours = span.Hours;                     //6 (component)
double totalDays = span.TotalDays;          //1.270833...
double totalHours = span.TotalHours;        //30.5



//Test: write a method that calculates the number of whole days between two dates.
//      The result should always be positive, regardless of which date comes first.
public class Solution
{
    public static int GetDaysBetween(DateTime startDate, DateTime endDate)
    {
        TimeSpan difference = startDate - endDate;
        return Math.Abs(difference.Days);
    }
}