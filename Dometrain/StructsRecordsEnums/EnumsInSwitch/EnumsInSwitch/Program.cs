//Enums in switch statements

//Switch statements and enums are a perfect match.
//The compiler can verify you've handled all enum values, making your code safer and more maintainable.


//Basic enum switch
string GetTemperature(Season season)
{
    switch (season)
    {
        case Season.Summer:
            return "Hot";

        case Season.Winter:
            return "Cold";

        case Season.Spring:
        case Season.Fall:       //When multiple enum values should produce the same result, stack the cases.
            return "Mild";      //Both Spring and Fall return "Mild"

        default:
            return "Unknown";
    }
}

enum Season { Spring, Summer, Fall, Winter }


//The DayOfWeek enum
//C# provides a built-in DayOfWeek enum in the System namespace:
//
//  DayOfWeek values:
//      Sunday = 0, Monday = 1, Tuesday = 2, Wednesday = 3,
//      Thursday = 4, Friday = 5, Saturday = 6



//Test: write a method that takes a DayOfWeek enum value and returns:
//          "Weekend" for Saturday and Sunday
//          "Weekday" for Monday through Friday
public class Solution
{
    public static string GetDayType(DayOfWeek day)
    {
        switch (day)
        {
            case DayOfWeek.Sunday:
            case DayOfWeek.Saturday:
                return "Weekend";

            default:
                return "Weekday";
        }
    }
}

//Or

public class Solution2
{
    public static string GetDayType(DayOfWeek day) => day switch
    {
        DayOfWeek.Sunday or DayOfWeek.Saturday => "Weekend",
        _ => "Weekday"
    };
}