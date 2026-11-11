//LINQ query syntax

//LINQ query syntax provides a SQL-like way to write queries in C#, making complex data transformations more readable.


//Method Syntax vs Query Syntax
using System.Linq;

List<int> numbers = new List<int> { 2, 4, 6, 8, 10 };

var result = numbers.Where(n => n > 5).Select(n => n * 2);  //Method syntax (fluent)

var result2 = from n in numbers                             //Query syntax (declarative)
             where n > 5
             select n * 2;                                  //Both produce identical results, choose based on readability


//Query Syntax Structure
List<Person> people = new List<Person>
{
    new Person("Alice", 30),
    new Person("Bob", 15),
    new Person("Carla", 22),
    new Person("Dan", 17)
};

var adultNames = from person in people      //person is a name chosen for the current item
                 where person.Age >= 18     //optional: filter items
                 select person.Name;        //required: of these items what to return and how to transform them (like in select n * 2)

public record Person(string Name, int Age); //var adultNames is "IEnumerable<T>" type. It isn't a List or array.
                                            //It doesn't store the results but how to get to them. It can be looped.
                                            //It checks the original collection when run, so no need to update at every change.



//test: convert the following method syntax query to query syntax:
//          numbers.Where(n => n % 2 == 0).Select(n => n * 2).ToList()
//      This query filters even numbers and doubles them.
public class Solution
{
    public static List<int> GetEvenNumbersDoubled(List<int> numbers)
    {
        var result = from number in numbers         //This is also valid:   return (from number in numbers
                     where number % 2 == 0          //                             where number % 2 == 0
                     select number * 2;             //                             select number * 2).ToList();

        return result.ToList();     //This turns result into an effective copy of the values,
                                    //so it is not updated automatically when the original collecton changes.
    }
}