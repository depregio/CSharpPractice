//Auto-properties

//Auto-properties provide a concise way to declare properties without explicitly defining backing fields.
//The compiler automatically creates a hidden backing field for you. The behaviour is the same and it saves code.


//Basic syntax
public class Product
{
    private string _name;
    public string Name                  //Traditional approach with backing field.
    {
        get { return _name; }
        set { _name = value; }
    }

    public decimal Price { get; set; }  //Approach with auto-properties. The compiler creates a hidden private field for you.
}


//Different access levels
public class Person
{
    public string Name { get; set; }        //Read-write property

    public int Age { get; private set; }    //Read-only from outside, settable from inside the class

    public string Id { get; }               //Read-only (must be set in constructor)
}


//Test: refactor the PersonSolution class to use auto-properties instead of manual backing fields and getter/setter methods.
//          Replace the private fields (_name, _age, _email) with auto-properties
//          Remove the manual getter/setter methods (GetName, SetName, etc.)
//          Update the constructor to use the new property names
//          Solution.GetPersonInfo already accesses the properties directly (person.Name), so it will not compile until your properties exist. Getting it to compile is the point.
public class PersonSolution
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }

    public PersonSolution(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;
    }
}

public class Solution
{
    public static string GetPersonInfo(string name, int age)
    {
        var person = new PersonSolution(name, age, "test@example.com");
        return $"{person.Name}, {person.Age}, {person.Email}";
    }
}