//The select method

//Select() transforms each element in a collection into a new form.
//Think of it as a "map" operation - it takes each item, applies a transformation, and returns a new collection with the results.


//Basic Usage
using System.Linq;

var numbers = new List<int> { 1, 2, 3 };
var doubled = numbers.Select(n => n * 2).ToList();          //Transform numbers to their doubles    //Result: [2, 4, 6]

var words = new List<string> { "cat", "elephant", "dog" };
var lengths = words.Select(w => w.Length).ToList();         //Transform strings to their lengths    //Result: [3, 8, 3]    

var prices = new List<int> { 10, 20, 30 };
var formatted = prices.Select(p => $"${p}.00").ToList();    //Transform to a different type         //Result: ["$10.00", "$20.00", "$30.00"]


//Select vs where
var nums = new List<int> { 1, 2, 3, 4, 5 };

var filtered = nums.Where(n => n > 3).ToList();         //Where: keeps only elements matching condition     //[4, 5]

var transformed = nums.Select(n => n * 10).ToList();    //Select: transforms every element                  //[10, 20, 30, 40, 50]



//Test: write a method that takes a list of integers and returns a new list containing the square of each number.
//      Formula: square = number × number(or number²)
public class Solution
{
    public static List<int> GetSquares(List<int> numbers)
    {
        return numbers.Select(n => n * n).ToList();
    }
}