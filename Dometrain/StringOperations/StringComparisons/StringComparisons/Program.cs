//String Comparisons

//String comparisons in C# go beyond simple == checks.
//The String.Equals() and String.Compare() methods give you precise control over how strings are compared.

//String.Equals compares two strings based on selected ruleset and returns a boolean.

//String.Compare() compares two strings and returns an integer indicating their relative order:
//      Negative number:    first string comes BEFORE second in sort order
//      Zero:               strings are equal
//      Positive number:    first string comes AFTER second in sort order

//Important: for String.Compare() the exact negative or positive value returned is implementation-specific.
//Never rely on it being exactly -1 or 1. Instead, check if the result is < 0, == 0, or > 0:

//For both methods StringComparison.Ordinal is the default ruleset.


//String.Equals with StringComparison
string.Equals("Hello", "hello");    //false     //Case-sensitive comparison (default)

string.Equals("Hello", "hello", StringComparison.OrdinalIgnoreCase);        //true  //Case-insensitive comparison

string.Equals("café", "CAFÉ", StringComparison.CurrentCultureIgnoreCase);   //true  //Culture-aware comparison


//Understanding String.Compare
string.Compare("apple", "banana", StringComparison.Ordinal);    //negative (a < b)
string.Compare("banana", "apple", StringComparison.Ordinal);    //positive (b > a)
string.Compare("apple", "apple", StringComparison.Ordinal);     //zero (equal)
string.Compare("Apple", "apple", StringComparison.Ordinal);     //negative ('A' < 'a' in ASCII)

int result = string.Compare("apple", "banana", StringComparison.Ordinal);

if (result < 0)
    Console.WriteLine("First comes before second");
else if (result > 0)
    Console.WriteLine("First comes after second");
else
    Console.WriteLine("Strings are equal");


//Case-Insensitive comparison with String.Compare
string.Compare("Apple", "apple", StringComparison.Ordinal); //negative  //Case-sensitive: 'A' (65) < 'a' (97) in ASCII

string.Compare("Apple", "apple", StringComparison.OrdinalIgnoreCase);   //zero  //Case-insensitive: treated as equal


//Why == Can Be Problematic
bool compareDoubleEqual = "Hello" == "hello";   //false. No way to ignore case

string.Equals("Hello", "hello", StringComparison.OrdinalIgnoreCase);    //true  //Use String.Equals for case-insensitive



//Test: implement three methods:
//          AreEqualIgnoreCase: Check if two strings are equal, ignoring case differences
//          CompareStrings:     Compare two strings and return -1, 0, or 1 for ordering
//          AreExactlyEqual:    Check if two strings are exactly equal (case-sensitive)
public class Solution
{
    public static bool AreEqualIgnoreCase(string text1, string text2)
    {
        return string.Equals(text1, text2, StringComparison.OrdinalIgnoreCase);
    }

    public static int CompareStrings(string text1, string text2) => string.Compare(text1, text2) switch     //Practicing switch epressions.
    {                                                                                                       //If or Math.Sign would be clearer
        <0 => -1,
        0 => 0,
        >0 => 1
    };

    public static bool AreExactlyEqual(string text1, string text2)
    {
        return text1 == text2;
    }
}