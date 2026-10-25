//Parameterized constructors

//A parameterized constructor accepts arguments when creating an object, allowing you to initialize fields with specific values immediately.


//Using Parameterized Constructors
Bike myBike = new Bike("Indian 101 Scout");
Rectangle myRectangle = new Rectangle(10, 5);
Console.WriteLine(myBike.Model);


//Default vs parameterized constructors
public class Car
{
    public string Model;

    public Car()                //Default constructor
    {
        Model = "Unknown";
    }
}

public class Bike
{
    public string Model;

    public Bike(string model)    //Parameterized constructor
    {
        Model = model;
    }
}

public class Rectangle
{
    public int Width;
    public int Height;

    public Rectangle(int width, int height)     //Parameterized parameters
    {
        Width = width;
        Height = height;
    }
}



//Test: create a Person class with a parameterized constructor that:
//          Accepts a string name and an int age as parameters
//          Assigns these values to the Name and Age fields with a parameterized constructor
//          Then implement in the program a method to create a Person and return their info in format: "Name: [name], Age: [age]".
static string CreatePrintPersonInfo(string name, int age)
{
    Person person = new Person(name, age);
    return $"Name: {person.Name}, Age: {person.Age}";
}

public class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}