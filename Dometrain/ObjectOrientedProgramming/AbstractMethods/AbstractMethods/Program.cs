//Abstract methods

//An abstract method is a method declared in an abstract class that has no implementation, it only defines the signature.
//Any non-abstract class that inherits from the abstract class must provide an implementation.

//Why use abstract methods?
//Abstract methods enforce a contract: they guarantee that all derived classes will have a specific method with a specific signature. 
//This is useful when you know what operation should exist, but each subclass needs to define how it works.


//Declaring abstract methods
public abstract class Animal
{
    public abstract void MakeSound();   //Abstract method: no body, ends with semicolon

    public abstract int GetLegs();      //Abstract method with return type
}

//Implementing abstract methods
public class Dog : Animal
{
    public override void MakeSound()    //Must use override keyword
    {
        Console.WriteLine("Woof!");
    }

    public override int GetLegs()       //Must use override keyword
    {
        return 4;
    }
}



//Test: In the Shape abstract class, declare an abstract method GetArea() that returns a double.
//      In the Rectangle class, override and implement GetArea() to return the area (width × height).
public abstract class Shape
{
    public string Name { get; set; }

    public Shape(string name)
    {
        Name = name;
    }

    public abstract double GetArea();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height) : base("Rectangle")
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return (Width * Height);
    }
}