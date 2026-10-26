//Auto-properties

//Auto-properties provide a concise way to declare properties without explicitly defining backing fields.
//The compiler automatically creates a hidden backing field for you. The behaviour is the same and it saves code.


//Basic syntax
// Traditional approach with backing field
public class Product
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    private decimal _price;
    public decimal Price { get; set; }
}


//Different access levels
public class Person
{
    private string _name;
    public string Name { get; set; }        //Read-write property

    private int _age;
    public int Age { get; private set; }    //Read-only from outside, settable from inside the class

    private string _id;
    public string Id { get; }               //Read-only (must be set in constructor)
}


//Test: refactor the PersonSolution class to use auto-properties instead of manual backing fields and getter/setter methods.
//          Replace the private fields (_name, _age, _email) with auto-properties
//          Remove the manual getter/setter methods (GetName, SetName, etc.)
//          Update the constructor to use the new property names
//          Solution.GetPersonInfo already accesses the properties directly (person.Name), so it will not compile until your properties exist. Getting it to compile is the point.
public class PersonSolution
{
    private string _name;
    public string Name { get; set; }
    
    private int _age;
    public int Age { get; set; }

    private string _email;
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