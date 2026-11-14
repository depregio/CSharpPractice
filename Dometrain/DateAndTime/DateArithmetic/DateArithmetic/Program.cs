//Date arithmetic

//DateTime provides methods to add or subtract time periods, and subtracting two dates gives you a TimeSpan representing the difference.

//Key methods
//      METHOD          DESCRIPTION	            EXAMPLE
//      AddDays(n)	    Add/subtract days	    date.AddDays(30)
//      AddMonths(n)	Add/subtract months	    date.AddMonths(-1)
//      AddYears(n)	    Add/subtract years	    date.AddYears(5)
//      date2 - date1	Get TimeSpan between	end - start


//Adding time to dates
DateTime today = new DateTime(2024, 1, 15);

DateTime nextWeek = today.AddDays(7);           //2024-01-22    //Adds days
DateTime lastWeek = today.AddDays(-7);          //2024-01-08

DateTime nextMonth = today.AddMonths(1);        //2024-02-15    //Adds months
DateTime lastYear = today.AddMonths(-12);       //2023-01-15

DateTime fiveYearsLater = today.AddYears(5);    //2029-01-15    //Adds years


//Subtracting dates (TimeSpan)
DateTime start = new DateTime(2024, 1, 1);
DateTime end = new DateTime(2024, 1, 31);

TimeSpan difference = end - start;          //Subtracting dates returns a TimeSpan

int totalDays = (int)difference.TotalDays;  //30
double totalHours = difference.TotalHours;  //720



//Test: implement four methods:
//          AddDaysToDate   - Add a number of days to a date
//          AddMonthsToDate - Add a number of months to a date
//          AddYearsToDate  - Add a number of years to a date
//          GetDaysBetween  - Calculate days between two dates
public class Solution
{
    public static DateTime AddDaysToDate(DateTime date, int days)
    {
        return date.AddDays(days);
    }

    public static DateTime AddMonthsToDate(DateTime date, int months)
    {
        return date.AddMonths(months);
    }

    public static DateTime AddYearsToDate(DateTime date, int years)
    {
        return date.AddYears(years);
    }

    public static int GetDaysBetween(DateTime start, DateTime end)
    {
        TimeSpan daysBetween = end - start;
        return (int)daysBetween.TotalDays;
    }
}