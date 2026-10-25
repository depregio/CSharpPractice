//Constructor overloading

//It allows a class to have multiple constructors with different parameter lists, giving flexibility in how objects are created.
//Different situations require different initialization options. Sometimes you know different attributes od the same class you want to initialize.


//The compiler selects the constructor based on the arguments you provide.
Product p1 = new Product("Widget");           //Uses first constructor
Product p2 = new Product("Gadget", 19.99m);   //Uses second constructor

//Create different constructors by changing their signature (number and types of parameters).
public class Product
{
    public string Name;
    public decimal Price;

    public Product(string name)                 //Constructor with one parameter
    {
        Name = name;
        //Price = 0.00m;  //default value
    }

    public Product(string name, decimal price)  //Constructor with two parameters
    {
        Name = name;
        Price = price;
    }
}



//Test: create a Person class with two overloaded constructors:
//          A constructor that takes only a name parameter and sets Age to 0
//          A constructor that takes both name and age parameters
public class Person
{
    public string Name;
    public int Age;

    public Person (string name)
    {
        Name = name;
        //Age = 0; is not needed since it is the default value of int.
    }

    public Person (string name, int age)
    {
        Name = name;
        Age = age;
    }
}