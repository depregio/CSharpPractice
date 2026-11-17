//Named tuple elements

//Named tuple elements give your tuple fields meaningful names instead of the default Item1, Item2, etc.
//This makes your code more readable and self-documenting.


//Declaring named tuples
(string, int) person1 = ("Alice", 30);          //Without names (harder to read)
Console.WriteLine(person1.Item1);               //"Alice"

(string Name, int Age) person2 = ("Bob", 25);   //With names (easier to read)
Console.WriteLine(person2.Name);                //"Bob"
Console.WriteLine(person2.Age);                 //25


//Creating named tuples
(string FirstName, string LastName) fullName = ("John", "Doe");         //Names in the type declaration

var employee = (Name: "Sarah", Department: "Engineering", Years: 5);    //Names when creating the value
Console.WriteLine(employee.Department); //"Engineering"

static (int Width, int Height) GetDimensions()  //Returning named tuples from methods
{
    return (Width: 1920, Height: 1080);
}



//Test: implement two methods:
//          CreateNamedPersonTuple  - Create and return a named tuple with Name, Age, and City elements
//          GetPersonDescription    - Use the named tuple to build a description string
public class Solution
{
    public static (string Name, int Age, string City) CreateNamedPersonTuple(string name, int age, string city)
    {
        return (name, age, city);   //Thanks to the names in the signature I can be sure the first string is name and second is city.
    }

    public static string GetPersonDescription(string name, int age, string city)
    {
        var person = CreateNamedPersonTuple(name, age, city);   
                                        //var takes its type from whatever the right side returns.
                                        //The return type of CreateNamedPersonTuple is (string Name, int Age, string City), names included.
                                        //So person is declared as that exact type.
        return $"{person.Name} is {person.Age} years old and lives in {person.City}";
    }
}