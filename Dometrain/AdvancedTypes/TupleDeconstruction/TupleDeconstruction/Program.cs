//Tuple deconstruction

//Deconstruction lets you unpack a tuple's values into separate, named variables in a single statement.
//This makes your code more readable and easier to work with.


//Basic deconstruction syntax
var person = ("Alice", 30, "London");   //Given a tuple

var (name, age, city) = person;         //Deconstruct into separate variables

Console.WriteLine(name);    //Alice     //Now you can use each variable independently
Console.WriteLine(age);     //30


//Deconstruction with explicit types
(string name, int age, string city) = person;   //You can specify types explicitly

var (name, age, _) = person;                    //Or mix var with explicit types    //Use _ to discard values you don't need


//Deconstruction vs direct access
var greeting = $"{person.Item1} is {person.Item2}";     //Without deconstruction: accessing tuple members directly

var (name, age, _) = person;                            //With deconstruction: cleaner variable names
var greeting = $"{name} is {age}";


//Discarding values
var (name, _, city) = person;   //Ignores age   //Use underscore to ignore values you don't need



//Test: deconstruct the input tuple into separate variables, then use those variables to build a formatted string.
public class Solution
{
    public static string DeconstructPerson((string Name, int Age, string City) person)
    {
        (string name, int age, string city) = person;

        return $"{name} is {age} years old and lives in {city}";
    }
}