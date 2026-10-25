//Classes in C#

//A class is a blueprint for creating objects.
//It defines what data an object holds and what actions it can perform.


//Defining a class
public class Car    //The simplest possible class, just a name.
{
}

public class Dog    //A class with a field (data).
{
    public string Name;
}

public class Calculator //// A class with a method (behaviour).
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}


//Creating Objects (Instantiation) with the new keyword
Car myCar = new Car();  //Creates an instance of Car

Dog myDog = new Dog();  //Creates an instance of Dog
myDog.Name = "Buddy";

Calculator calc = new Calculator(); //Creates and uses Calculator
int result = calc.Add(5, 3);        //result = 8

//Note: Defining a class before the top level statements will give an error: Top-level statements must precede namespace and type declarations.
//A different solution to writing the classes definition after is to make the top-level statements inside their own method:
class Program   //This requires to not have any top-level statement outside the Main() method and any method outside the class Program.
{
    static void Main()
    {
        Car myCar = new Car();

        Dog myDog = new Dog();
        myDog.Name = "Buddy";

        Calculator calc = new Calculator();
        int result = calc.Add(5, 3);
    }
}



//Test: define an empty Person class, then create and return an instance of it.
public class Person
{
    public static Person CreatePerson()
    {
        return new Person();
    }
}