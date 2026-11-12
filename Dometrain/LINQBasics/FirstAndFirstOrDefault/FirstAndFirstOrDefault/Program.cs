//First and FirstOrDefault

//First() and FirstOrDefault() retrieve the first element from a collection, optionally filtered by a condition.
//The key difference is how they handle empty results.

//First() method throws on empty, FirstOrDefault() is a safer alternative if unsure a certain match exists.


//First()
using System.Linq;

var numbers = new List<int> { 1, 2, 3, 4, 5 };

int first = numbers.First();                    //Get first element             //Returns 1

int firstEven = numbers.First(n => n % 2 == 0); //Get first matching element    //Returns 2

int firstBig = numbers.First(n => n > 100);     //DANGER: Throws InvalidOperationException (no match)


//FirstOrDefault()
var numbers2 = new List<int> { 1, 2, 3, 4, 5 };     //Returns default value if no match (0 for int, null for reference types)

int firstBig2 = numbers2.FirstOrDefault(n => n > 100);          //Returns 0

var names = new List<string> { "Alice", "Bob" };
string firstZ = names.FirstOrDefault(n => n.StartsWith("Z"));   //Returns null


//Handling Null with ??
string result = names.FirstOrDefault(n => n.Length > 10) ?? "Not found";    //Use null-coalescing operator for custom default

//The ?? operator means “use the left side, unless it’s null, then use the right side.”

//FirstOrDefault returns null for reference types like string when nothing matches,
//and using that null later (for example result.Length) would crash with a NullReferenceException.
//?? replaces the null with something safe right away.




//Test: find the first name in a list that has a length greater than or equal to a minimum length.
//      If no name meets the criteria, return the string "No match found".
public class Solution
{
    public static string GetFirstLongName(List<string> names, int minLength)
    {
        return names.FirstOrDefault(name => name.Length >= minLength) ?? "No match found";
    }
}