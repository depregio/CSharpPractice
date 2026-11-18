//Init-only properties

//Init-only properties allow you to set a property value only during object initialization.
//After the object is created, the property becomes read-only.

//Why Use init-only?
//      BENEFIT                     DESCRIPTION
//      Immutability	            Prevents accidental modification after creation
//      Thread Safety	            Immutable objects are safer in concurrent code
//      Clear Intent	            Signals that values shouldn't change
//      Object Initializer Support	Unlike readonly fields, works with object initializers


//Basic syntax
public class Product
{
    public string Name { get; init; }   //Can only be set during initialization or with construsctor.
    public decimal Price { get; init; } //You can't set a property during initialization with { get; }
}

//Usage: setting values during initialization
var product = new Product
{
    Name = "Laptop",
    Price = 999.99m
};

// product.Name = "Desktop";    //This would cause a compile error: Error. Cannot assign after initialization.


//Init vs set
public class Comparison
{
    public string Mutable { get; set; }     //Can be changed anytime
    public string Immutable { get; init; }  //Only settable during init
}

var obj = new Comparison { Mutable = "A", Immutable = "B" };
obj.Mutable = "Changed";        //Works fine
//obj.Immutable = "Changed";    //Compile error



//Test: create a Person class with three init-only properties:
//          Name(string)
//          Age(int)
//          City(string)
//      Then implement CreateAndDescribePerson to create a Person and return a formatted description.
public class Solution
{
    public static string CreateAndDescribePerson(string name, int age, string city)
    {
        Person person = new Person
        {
            Name = name,
            Age = age,
            City = city
        };

        return $"Name: {person.Name}, Age: {person.Age}, City: {person.City}";
    }
}

public class Person
{
    public string Name { get; init; }
    public int Age { get; init; }
    public string City { get; init; }
}