//OrderBy for sorting

//OrderBy() sorts elements in ascending order based on a key you specify.
//It's the LINQ equivalent of sorting a collection, but with more flexibility since you control what to sort by.


//Basic Usage
var numbers = new List<int> { 5, 2, 8, 1, 9 };
var sorted = numbers.OrderBy(n => n).ToList();              //Result: [1, 2, 5, 8, 9]

var names = new List<string> { "Charlie", "Alice", "Bob" };
var alphabetical = names.OrderBy(name => name).ToList();    //Result: ["Alice", "Bob", "Charlie"]


//OrderBy vs OrderByDescending
var scores = new List<int> { 85, 92, 78, 95 };

var ascending = scores.OrderBy(s => s).ToList();            //OrderBy() sorts in ascending order (A-Z, 0-9)                 //Result: [78, 85, 92, 95]

var descending = scores.OrderByDescending(s => s).ToList(); //OrderByDescending() sorts in descending order (Z-A, 9-0)      //Result: [95, 92, 85, 78]


//Sorting by a Property

var words = new List<string> { "apple", "hi", "banana" };
var byLength = words.OrderBy(w => w.Length).ToList();   //You can sort objects by any property or computed value    // Result: ["hi", "apple", "banana"]



//Test: given a list of names, return them sorted in alphabetical order (A to Z).
public class Solution
{
    public static List<string> SortNamesAlphabetically(List<string> names)
    {
        return names.OrderBy(n => n).ToList();
    }
}