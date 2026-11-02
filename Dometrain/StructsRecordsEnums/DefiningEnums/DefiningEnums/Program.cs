//Enums in C#

//An enum (enumeration) is a value type that defines a set of named constants,
//making your code more readable and type-safe than using raw integers or strings.


//Why Use Enums Instead of Integers?
int statusI = 200;                      //Without enum, what does 1 mean?

HttpStatus statusE = HttpStatus.OK;     //With enum, self-documenting


//Using enums
Color myColor = Color.Red;

if (myColor == Color.Red)   //Compare enum values
{
    Console.WriteLine("It's red!");
}

switch (myColor)            //Switch on enum values
{
    case Color.Red:
        Console.WriteLine("Stop");
        break;

    case Color.Green:
        Console.WriteLine("Go");
        break;
}


//Declaring an enum
enum Color       //Basic enum: values start at 0 by default and increase by 1
{
    Red,    //0
    Green,  //1
    Blue    //2
}

enum HttpStatus //Enum with explicit values
{
    OK = 200,
    NotFound = 404,
    ServerError = 500
}



//Test: 
//      Define a DayOfWeek enum with all seven days:
//          Sunday (0), Monday (1), Tuesday (2), Wednesday (3), Thursday (4), Friday (5), Saturday (6)
//      Implement GetDayType that returns "Weekend" for Saturday and Sunday, and "Weekday" for all other days
public enum DayOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}
public class Solution
{
    public static string GetDayType(DayOfWeek day) => day switch
    {
        DayOfWeek.Sunday or DayOfWeek.Saturday => "Weekend",
        _ => "Weekday"
    };
}