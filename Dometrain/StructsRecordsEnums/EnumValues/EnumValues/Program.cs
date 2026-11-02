//Enum underlying values

//Every enum in C# has an underlying integral type (int by default) that stores the actual numeric value for each member.


//Accessing the Numeric Value
int value = (int)Priority.High; //Cast enum to int to get the underlying value  //value = 3

Priority p = (Priority)2;       //You can also cast an int back to an enum      //p = Priority.Medium

public enum Priority
{
    Low = 1,
    Medium = 2,
    High = 3
}


//Default values vs custom values
public enum Color           //Default: starts at 0 and increments
{
    Red,    //0
    Green,  //1
    Blue    //2
}

public enum HttpStatus      //Custom: you assign specific values
{
    OK = 200,
    NotFound = 404,
    ServerError = 500
}



//Test: given a DayOfWeek enum member, return its underlying integer value.
//      The DayOfWeek enum is defined with Sunday = 0 through Saturday = 6.
public enum DayOfWeek
{
    Sunday = 0,
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6
}

public class Solution
{
    public static int GetEnumValue(DayOfWeek day)
    {
        return (int)day;
    }
}