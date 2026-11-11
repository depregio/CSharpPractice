//The where method

//Where() is one of the most commonly used LINQ methods.
//It filters a collection based on a condition (predicate) and returns only the elements that match.

//A predicate is a function that takes an element and returns true or false.
//The Where() method keeps elements where the predicate returns true.

//Where() uses deferred execution, meaning the filtering doesn't happen until you iterate over the result or convert it to a concrete type.


//Basic Usage
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

var result = numbers.Where(n => n > 3);             //Filter to get only numbers greater than 3     //Result: { 4, 5, 6 }

var oddNumbers = numbers.Where(n => n % 2 != 0);    //Filter to get only odd numbers                //Result: { 1, 3, 5 }


//Understanding predicates
numbers.Where(n => n % 2 == 0);     //The lambda expression is the predicate

bool IsEven(int n) => n % 2 == 0;   //You can also use a separate method as the predicate
numbers.Where(IsEven);


//Deferred Execution
var query = numbers.Where(n => n > 3);  // No filtering yet
var list = query.ToList();              // Filtering happens here



//Test: use the Where() method to filter a list of integers and return only the even numbers.
//      An even number is divisible by 2 with no remainder.
public class Solution
{
    public static List<int> GetEvenNumbers(List<int> numbers)
    {
        return numbers.Where(n => n % 2 == 0).ToList();
    }
}