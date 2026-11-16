//Type checking with is

//The is keyword checks whether an object is compatible with a specific type at runtime.
//It returns true if the object is of that type (or a derived type), and false otherwise.

//The is keyword safely handles null values. It returns false when checking a null reference.


//Basic usage
object myValue = "Hello";
bool isString = myValue is string;  //true

object myNumber = 42;
bool isInt = myNumber is int;       //true
bool isDouble = myNumber is double; //false


//Handling null values
object nullValue = null;            //object is the most general type, so this variable can possibly hold anything (or null).
bool result = nullValue is string;  //false (not a string, it's null)
bool isNull = nullValue is null;    //true (C# 7+)


//Why use is instead of GetType()?
if (value is string)        //Using is: cleaner and handles null safely
{
    Console.WriteLine("It's a string!");
}

if (value != null && value.GetType() == typeof(string))     //Using GetType(): throws if null, more verbose
{
    Console.WriteLine("It's a string!");
}


//Test: implement a method that checks whether a given object is a string type.
public class Solution
{
    public static bool IsString(object value)
    {
        return value is string;
    }
}