//Introduction to LINQ

//LINQ (Language Integrated Query) is a powerful feature in C# that lets you query and manipulate collections using a consistent, readable syntax.
//It's available by adding using System.Linq; to your code.

//LINQ provides extension methods that you can chain onto any collection. These methods are called using dot notation.


//Method syntax basics
using System.Linq;


var numbers = new List<int> { 1, 2, 3, 4, 5 };

int first = numbers.First();    //Get the first element

int last = numbers.Last();      //Get the last element

int count = numbers.Count();    //Count elements


//First() vs FirstOrDefault()
var empty = new List<int>();

int first2 = empty.First();          //This throws InvalidOperationException
                                     //The First() method returns the first element but throws an exception if the collection is empty.
int firstOrDefault = empty.FirstOrDefault();    //This returns 0 (default for int)
                                                //Use FirstOrDefault() when you want a default value instead of an exception

/*
Useful LINQ methods:
    METHOD	    DESCRIPTION	                    EXAMPLE
    First()	    Returns first element	        numbers.First()
    Last()	    Returns last element	        numbers.Last()
    Count()	    Returns element count	        numbers.Count()
    Any()	    Checks if any elements exist    numbers.Any()
*/



//Test: implement a method that uses LINQ to return the first element from a list of integers.
public class Solution
{
    public static int GetFirstElement(List<int> numbers)
    {
        return numbers.FirstOrDefault();
    }
}