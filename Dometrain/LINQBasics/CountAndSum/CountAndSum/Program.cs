//Count and sum aggregation methods

//Count() and Sum() are LINQ aggregation methods that reduce a collection to a single value.
//They're essential for calculating totals and quantities from your data.

//Count() returns the number of elements in a collection. It can be used with or without a predicate.
//Sum() adds up all numeric values in a collection. It works on numeric types directly or can use a selector.


//Count() Method
using System.Linq;

var numbers = new List<int> { 1, 2, 3, 4, 5 };

int total = numbers.Count();                    //Count all elements                    //Returns 5

int evens = numbers.Count(n => n % 2 == 0);     //Count elements matching a condition   //Returns 2


//Sum() Method
var numbers2 = new List<int> { 10, 20, 30 };

int total2 = numbers2.Sum();                    //Sum all elements                          //Returns 60

int doubled = numbers2.Sum(n => n * 2);         //Sum with selector (transform then sum)    //Returns 120


//Combining with Where
var numbers3 = new List<int> { 1, 2, 3, 4, 5, 6 };   //You can filter first, then aggregate:

int oddSum = numbers3.Where(n => n % 2 != 0).Sum();  //Sum only odd numbers      //Returns 9



//Test: implement two methods:
//          CountPositiveNumbers:   Count how many numbers are greater than zero
//          SumEvenNumbers:         Sum all even numbers in the list
public class Solution
{
    public static int CountPositiveNumbers(List<int> numbers)
    {
        return numbers.Count(n => n > 0);
    }

    public static int SumEvenNumbers(List<int> numbers)
    {
        return numbers.Where(n => n % 2 == 0).Sum();
    }
}