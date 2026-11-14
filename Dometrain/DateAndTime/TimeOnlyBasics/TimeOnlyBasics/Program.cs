//TimeOnly basics

//TimeOnly represents a time of day without a date component—perfect for schedules, store hours,
//or any scenario where you only care about the time.


//Creating TimeOnly values
var morning = new TimeOnly(9, 30);              //09:30:00    //From hours and minutes

var precise = new TimeOnly(14, 30, 45);         //14:30:45    //From hours, minutes, and seconds

var fromSpan = TimeOnly.FromTimeSpan(TimeSpan.FromHours(8.5)); //08:30:00   //From a TimeSpan

var now = TimeOnly.FromDateTime(DateTime.Now);  //Current time


//Formatting TimeOnly
var time = new TimeOnly(14, 30, 15);

time.ToString("HH:mm:ss");  //"14:30:15" (24-hour)
time.ToString("hh:mm tt");  //"02:30 PM" (12-hour with AM/PM)
time.ToString("HH:mm");     //"14:30" (no seconds)


//Comparing times
var early = new TimeOnly(8, 0);
var late = new TimeOnly(17, 0);
var current = new TimeOnly(12, 0);

bool isOpen = current >= early && current < late;   //true
bool isAfterClose = current > late;


//Time arithmetic
var start = new TimeOnly(9, 0);
var end = new TimeOnly(17, 30);

TimeSpan duration = end - start;    //08:30:00

var later = start.AddHours(2);      //11:00
var earlier = end.AddMinutes(-30);  //17:00



//Test: implement three methods:
//          FormatTime:         Create a TimeOnly from hour, minute, second and format as "HH:mm:ss"
//          GetMinutesUntil:    Calculate minutes from current time to target time (if target is earlier, assume next day)
//          IsBusinessHours:    Check if time is within 09:00 - 17:00(start inclusive, end exclusive)
public class Solution
{
    public static string FormatTime(int hour, int minute, int second)
    {
        TimeOnly formattedTime = new TimeOnly(hour, minute, second);
        return formattedTime.ToString("HH:mm:ss");
    }

    public static int GetMinutesUntil(int currentHour, int currentMinute, int targetHour, int targetMinute)
    {
        TimeOnly currentTime = new TimeOnly(currentHour, currentMinute);
        TimeOnly targetTime = new TimeOnly(targetHour, targetMinute);

        TimeSpan timeDifference = targetTime - currentTime;

        return (int)timeDifference.TotalMinutes;    //If target is earlier it means next day, returns positive minutes.
    }                                               //TimeOnly wraps past midnight, so no Math.Abs needed.

    public static bool IsBusinessHours(int hour, int minute)
    {
        TimeOnly inquiredTime = new TimeOnly(hour, minute);
        TimeOnly openingTime = new TimeOnly(9, 0);
        TimeOnly closingTime = new TimeOnly(17, 0);
        return openingTime <= inquiredTime && inquiredTime < closingTime;
    }
}