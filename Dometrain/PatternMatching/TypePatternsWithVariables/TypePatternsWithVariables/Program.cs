//Type patterns with variables

//Type patterns combine type checking and variable declaration in a single expression using is Type variableName syntax.


//Basic syntax
if (obj is string)      //Old way: separate check and cast
{
    string s = (string)obj;     //Manual cast required
    Console.WriteLine(s.Length);
}

if (obj is string s)    //New way: type pattern with variable
{
    Console.WriteLine(s.Length);//s is already typed
}


//The Variable is scoped
if (value is int number)
{
    
    return number * 2;  //number is available here as an int
}
                        //number is not accessible here, outiside of the if block


//Combining with else if
if (value is int i)
    return $"Got int: {i}";
else if (value is double d)
    return $"Got double: {d}";
else
    return "Unknown";



//Test: write a method that describes a value based on its type using type patterns with variables:
//          If value is an int, return "Integer: {doubled value}" (multiply by 2)
//          If value is a string, return "String: {uppercase text}"
//          If value is a double, return "Double: {value with 2 decimal places}"
//          If value is a bool, return "Boolean: yes" for true or "Boolean: no" for false
//          For any other type, return "Unknown type"
public class Solution
{
    public static string DescribeValue(object value) 
    {
        if (value is int integer)
            return "Integer: " + (integer * 2);
        else if (value is string word)
            return "String: " + word.ToUpper();
        else if (value is double preciseNumber)
            return $"Double: {preciseNumber:F2}";
        else if (value is bool isBool)
            return "Boolean: " + (isBool ? "yes" : "no");
        else
            return "Unknown type";
    }

    //or

    public static string DescribeValueExpression(object value) => value switch  //inside a switch expression is it's redundant.
    {                                                                           //The pattern is the is.
        int integer => $"Integer: {integer * 2}",
        string word => $"String: {word.ToUpper()}",
        double preciseNumber => $"Double: {preciseNumber:F2}",
        bool isBool => "Boolean: " + (isBool ? "yes" : "no"),
        _ => "Unknown type"
    };
}