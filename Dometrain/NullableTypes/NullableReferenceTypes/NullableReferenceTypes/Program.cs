//Nullable reference types

//In modern C# (8.0+), you can enable nullable reference types to distinguish between references that can be null and those that cannot.
//This helps prevent null reference exceptions at compile time.


//Declaration Syntax
string regularText = "hello";       //Non-nullable: cannot be null
string? nullableText = null;        //Nullable: can be null
string? alsoNullable = "world";     //Nullable but has a value


//string? vs string
string name = null;         //Warning: cannot assign null   //The compiler helps catch potential null issues
string? nickname = null;    //OK: explicitly nullable

int length = nickname.Length;           //Warning: possible null reference
int safeLength = nickname?.Length ?? 0; //OK: null-safe access


//Combining with null-coalescing
string? input = null;
string result = input ?? "default"; //result = "default"

string? greeting = "Hello";
string output = greeting ?? "Hi";   //output = "Hello"



//Test: write a method that takes two string parameters:
//          nullableText(type string ?) - may or may not have a value
//          regularText (type string) - always has a value
//      Return a formatted description showing both values. If nullableText is null, display the word "null" in its place.
public class Solution
{
    public static string DescribeStrings(string? nullableText, string regularText)
    {
        return $"Nullable: {nullableText ?? "null"}, Regular: {regularText}";
    }
}