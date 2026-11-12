//Any and All Boolean Checks

//Any() and All() are LINQ methods that return boolean results based on conditions across a collection.
//They're perfect for validation and quick checks.

//Any() returns true if at least one element matches the condition.
//All() returns true only if every element matches the condition.

//Both methods stop processing as soon as the result is determined (short-circuiting):
//      Any() stops at the first true result
//      All() stops at the first false result


//The Any() method
using System.Linq;

var numbers = new List<int> { 1, 2, -3, 4 };    //Check if any element matches a condition

bool hasNegative = numbers.Any(n => n < 0);     //true
bool hasZero = numbers.Any(n => n == 0);        //false

bool hasElements = numbers.Any();               //true  //Any() without a predicate checks if collection is not empty


//The All() method
var scores = new List<int> { 75, 82, 90, 68 };  //Check if all elements match a condition

bool allPassing = scores.All(s => s >= 60);     //true
bool allExcellent = scores.All(s => s >= 80);   //false


//Beware of vacuous truths
var empty = new List<int>();
bool isListPositive;
                                                        //This is a vacuous truth (checks on false, if nothing exists nothing can fail).
isListPositive = empty.All(n => n > 0);                 //All() is true unless an element fails, so on an empty collection it is true.
isListPositive = empty.Any() && empty.All(n => n > 0);  //If empty should NOT count as success, guard it. This returns false.



//Test: implement two methods:
//          HasAnyNegative:     Return true if any number in the list is negative (less than 0)
//          AreAllPositive:     Return true if all numbers are positive (greater than 0)
public class Solution
{
    public static bool HasAnyNegative(List<int> numbers)
    {
        return numbers.Any(n => n < 0);
    }

    public static bool AreAllPositive(List<int> numbers)
    {
        return numbers.Any() && numbers.All(n => n > 0);
    }
}