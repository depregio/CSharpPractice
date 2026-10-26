//Public access modifier

//The public access modifier makes class members (fields, properties, methods)
//accessible from anywhere in your code, including from outside the class.

//Access modifiers control the visibility and accessibility of class members.
//The public keyword is the most permissive - it allows any code to read, write, or call the member.


//Public members are accessed using dot notation from any part of your code
using System.Xml.Linq;

Car myCar = new Car();

myCar.Brand = "Toyota";         //Setting a public field
myCar.Year = 2023;              //Setting a public field

string carBrand = myCar.Brand;  //Reading a public field

myCar.StartEngine();            //Calling a public method

public class Car
{
    public string Brand;        //Anyone can read/write this field
    public int Year;            //Anyone can read/write this field

    public void StartEngine()   //Anyone can call this method
    {
        Console.WriteLine("Engine started!");
    }
}


//Test: create a Person class with:
//          A public field Name of type string
//          A public field Age of type int
//          A public method Greet() that returns a formatted greeting string
//          Then implement in the program a method GetPersonInfo to create a Person, set its fields, and return the greeting.
string GetPersonInfo(string name, int age)
{
    Person myPerson = new Person();

    myPerson.Name = name;
    myPerson.Age = age;

    return myPerson.Greet();
}

public class Person
{
    public string Name;     //Not using camel case as per the exercise request
    public int Age;

    public string Greet()
    {
        return $"Hello, I'm {Name} and I'm {Age} years old.";
    }
}