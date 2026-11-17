//When guards

//When guards add extra conditions to pattern matching using the when keyword.
//They let you refine a match beyond just the type, checking additional criteria before a pattern is considered a match.

//Common Guard Conditions
//      CONDITION       EXAMPLE
//      Range check	    when n >= 1 && n <= 10
//      Null check	    when s != null
//      String check	when string.IsNullOrEmpty(s)
//      Property check	when p.Age >= 18


//Basic syntax
object value = 42;                      //This value type is unknown in a narrower sense. Remember type pattern matching.
string result = value switch
{
    int n when n > 0 => "Positive",
    int n when n < 0 => "Negative",
    int => "Zero",
    _ => "Not an integer"
};


//Multiple Conditions
string category = person switch         //You can use && and || inside when guards
{
    Person p when p.Age >= 18 && p.HasLicense => "Can drive",
    Person p when p.Age >= 18 => "Adult without license",
    Person => "Minor",
    _ => "Unknown"
};


//Order Matters
int x when x > 100 => "Large",          //Patterns are evaluated top-to-bottom.
int x when x > 0 => "Positive",         //More specific patterns (with when guards) should come before general ones.
int => "Zero or negative"



//Test: implement a method that classifies values using type patterns with when guards:
//          Negative integers       → "Negative integer"
//          Zero                    → "Zero"
//          Positive integers 1-10  → "Small positive integer"
//          Positive integers > 10  → "Large positive integer"
//          Negative doubles        → "Negative decimal"
//          Non-negative doubles    → "Non-negative decimal"
//          Empty or null strings   → "Empty string"
//          Non-empty strings       → "Non-empty string"
//          Null                    → "Null value"
//          Anything else           → "Unknown type"
public class Solution
{
    public static string ClassifyNumber(object value) => value switch
    {
        int n when n < 0 => "Negative integer",
        int n when n == 0 => "Zero",
        int n when n <= 10 => "Small positive integer",
        int n when n > 10 => "Large positive integer",

        double d when d < 0 => "Negative decimal",
        double d when d >= 0 => "Non-negative decimal",

        string s when string.IsNullOrEmpty(s) => "Empty string",    //Consider also string.IsNullOrWhiteSpace(n) (works with "   ").
        string s => "Non-empty string",

        null => "Null value",

        _ => "Unknown type"
    };
}