//Structs in C#

//A struct is a value type that groups related data together. They are considered value types.
//Use structs for small, simple data structures that represent a single value, like coordinates or colors.

//When to use structs:
//      The data is small (16 bytes or less recommended)
//      It logically represents a single value
//      It's immutable or rarely modified
//      Examples: coordinates, RGB colors, time spans


//Creating and using structs
Point p1;           //Assign fields directly
p1.X = 10;
p1.Y = 20;

Point p2 = new Point { X = 5, Y = 15 }; //Use object initializer

int xValue = p1.X;  //Accessing fields  //10


//Defining a struct
struct Point
{
    public int X;
    public int Y;
}



//Test:
//      Define a Point struct with two public int fields: X and Y
//      Implement DescribePoint to create a Point, set its X and Y values, and return a formatted string
struct Point2
{
    public int X;
    public int Y;
}

public class Solution
{
    public static string DescribePoint(int x, int y)
    {
        Point2 point = new Point2 { X = x, Y = y };
        return $"Point({point.X}, {point.Y})";
    }
}