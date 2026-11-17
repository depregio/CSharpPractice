//Tuples in C#

//Tuples let you group multiple values together into a single lightweight data structure without creating a separate class.
//They are mostly for returning more than one value from a method, without writing a class.

//Tuples vs classes
//      TUPLES                              CLASSES
//      Quick, inline grouping	            Named, reusable types
//      No need to define a type	        Requires class definition
//      Access via Item1, Item2...	        Access via property names
//      Great for returning multiple values	Better for complex data models


//Creating Tuples
(int, string) person = (25, "Alice");                   //Basic tuple creation with parentheses syntax

var coordinates = (10.5, 20.3);                         //You can also use var for type inference

(string, int, bool) record = ("Product", 100, true);    //Tuples can hold any combination of types


//Returning Tuples from Methods
static (string, int) GetPerson()    //Methods can return tuples
{
    return ("Bob", 30);
}

var result = GetPerson();   //The caller receives both values grouped together  //result.Item1 = "Bob", result.Item2 = 30
string name = result.Item1;     //string name = GetPerson().Item1; works too.
int age = result.Item2;         //int age = GetPerson().Item2; works too.



//Test: create a method that takes a person's name and age, then returns them as a tuple.
//      The tuple should have the name first and age second.
public class Solution
{
    public static (string, int) CreatePersonTuple(string name, int age)
    {
        return (name, age);
    }
}