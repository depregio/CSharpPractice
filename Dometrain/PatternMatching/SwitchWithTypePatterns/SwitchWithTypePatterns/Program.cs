//Switch with type patterns

//Type pattern matching in switch statements lets you branch based on an object's runtime type
//while simultaneously extracting a typed variable for use in that branch.


//Basic syntax
switch (obj)
{
    case int number:
        Console.WriteLine($"It's an integer: {number}");
        break;
    case string text:
        Console.WriteLine($"It's a string: {text}");
        break;
    default:
        Console.WriteLine("Unknown type");
        break;
}


//vs if-else chains
if (obj is int)                 //Before: verbose if-else with is and casts
{
    int n = (int)obj;
    //using n
}
else if (obj is string)
{
    string s = (string)obj;
    //using s
}

switch (obj)                    //After: clean switch with type patterns
{
    case int n:    //type check + variable in one
        //using n
        break;
    case string s:
        //using s
        break;
}


//Handling null
switch (value)
{
    case null:                  //Explicit null case
        return "Nothing";
    case string s:
        return s;
    default:
        return "Other";
}



//Test: write a method that handles different object types using a switch statement with type patterns:
//          int → return "Integer: {value}"
//          double → return "Double: {value}" (formatted to 2 decimal places)
//          string → return "String: {value}" (converted to uppercase)
//          bool → return "Boolean: {value}"
//          null → return "Null value"
//          Any other type → return "Unknown type"
public class Solution
{
    public static string HandleObject(object value)
    {
        switch(value)
        {
            case int i:
                return $"Integer: {i}";

            case double d:
                return $"Double: {d:F2}";

            case string s:
                return $"String: {s.ToUpper()}";

            case bool b:
                return $"Boolean: {b}";

            case null:
                return "Null value";

            default:
                return "Unknown type";
        }
    }
}