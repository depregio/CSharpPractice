//Comparing dates

//DateTime values can be compared using standard comparison operators,
//making it easy to determine chronological order or check if dates fall within certain periods.

//DateTime.Now vs DateTime.Today
//      PROPERTY        RETURNS	                    EXAMPLE
//      DateTime.Now	Current date and time	    2024-03-15 14:30:45
//      DateTime.Today  Current date at midnight	2024-03-15 00:00:00


//Comparison operators
DateTime date1 = new DateTime(2024, 1, 15);
DateTime date2 = new DateTime(2024, 6, 20);

bool isBefore = date1 < date2;   //True. date1 is earlier
bool isAfter = date1 > date2;    //False. date1 is not later
bool isEqual = date1 == date2;   //False. Different dates
bool notEqual = date1 != date2;  //True. Dates differ


//Checking past and future
DateTime appointment = new DateTime(2025, 3, 15);
DateTime now = DateTime.Now;

bool isInPast = appointment < now;              //Is the date before now?
bool isInFuture = appointment > now;            //Is the date after now?
bool isToday = appointment.Date == now.Date;    //Same calendar day?


//CompareTo method
int result = date1.CompareTo(date2);
//Returns:
//  -1 if date1 < date2
//  0 if date1 == date2
//  1 if date1 > date2



//Test: write a method that checks if a given DateTime is in the future (after the current moment).
public class Solution
{
    public static bool IsInFuture(DateTime date)
    {
        return DateTime.Now < date; 
    }
}