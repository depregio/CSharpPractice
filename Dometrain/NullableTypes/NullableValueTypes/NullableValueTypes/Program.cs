//Nullable value types

//In C#, value types like int, bool, and double cannot normally be null.
//The nullable value type syntax (int?) allows these types to also hold a null value,
//which is useful when a value might be missing or undefined.


//Declaring Nullable Value Types
int regularNumber = 42;         //Regular int, cannot be null

int? nullableNumber = 42;       //Nullable int, can be null or hold a value
int? anotherNullable = null;


//Checking for Values
int? age = 25;                      //Nullable types have two important properties:

bool hasAge = age.HasValue;         //true      //HasValue returns true if the variable contains a value

int actualAge = age.Value;          //25        //Value returns the actual value (throws if null)

int? unknown = null;
bool hasUnknown = unknown.HasValue; //false


//Comparison with null
int? score = 100;

if (score != null)      //You can also compare directly with null
{
    Console.WriteLine("Score exists: " + score);
}

if (score.HasValue)     //This is equivalent to using HasValue
{
    Console.WriteLine("Score exists: " + score.Value);
}



//Test: write a method that takes a nullable integer and checks if it has a value.
//      Return a string indicating whether the value exists and what it is.
public class Solution
{
    public static string CheckNullableValue(int? number)
    {
        if (number.HasValue)
            return "Has value: " + number.Value;
        else
            return "No value";
    }
}