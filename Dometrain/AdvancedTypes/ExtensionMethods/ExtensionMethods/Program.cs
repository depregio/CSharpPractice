//Extension methods in C#

//Extension methods let you add new methods to existing types without modifying the original type or creating a derived class.

//Extension methods are defined in a static class with a special this modifier on the first parameter.
//Once defined, you call extension methods as if they were instance methods.

//Key rules:
//      RULE                    DESCRIPTION
//      Static class            Extension methods must be in a static class
//      Static method           The method itself must be static
//      this keyword            First parameter uses this modifier
//      First parameter type    Determines which type gets the extension


//The this parameter syntax
static class StringExtensions
{
    public static bool IsNullOrEmpty(this string str)
    {
        return string.IsNullOrEmpty(str);
    }
}


//Calling extension methods
string name = "Alice";
bool empty = name.IsNullOrEmpty();                  //Extension method call(looks like instance method)

bool empty2 = StringExtensions.IsNullOrEmpty(name); //Equivalent static call


//More examples
public static class IntExtensions
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }

    public static int Square(this int number)
    {
        return number * number;
    }
}

int x = 4;      //Usage
bool even = x.IsEven();   //true
int squared = x.Square(); //16



//Test: create an extension method WordCount for the string type that returns the number of words in the string.
//      Words are separated by whitespace (spaces, tabs, newlines).
public static class StringExtensions
{
    public static int WordCount(this string text)
    {
        string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}

public class Solution
{
    public static int CountWords(string text)
    {
        return text.WordCount();
    }
}