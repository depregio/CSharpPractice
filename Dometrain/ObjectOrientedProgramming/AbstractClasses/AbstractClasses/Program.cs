//Abstract classes

//An abstract class is a class that cannot be instantiated directly and may contain abstract members that derived classes must implement.
//Use abstract classes when you want to define a common interface and shared behavior for related classes.

//Why use abstract classes?
//  Enforce contracts:          Derived classes must implement specific methods
//  Prevent incomplete usage:   Can't accidentally create a "base" shape with no dimensions
//  Share common code:          Non -abstract methods are inherited normally


//Declaring abstract classes and methods
public abstract class Animal            //Abstract class: cannot create instances with new
{
    public string Name { get; set; }
    public abstract void MakeSound();   //Abstract method: no implementation, must be overridden

    public void Sleep()                 //Regular method: can have implementation
    {
        Console.WriteLine("Sleeping...");
    }
}

public class Dog : Animal               //Derived class MUST implement all abstract methods
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}


//Difference between abstract and virtual method
public abstract class Vehicle
{
    public abstract void StartEngine(); //MUST be overridden: no default behavior

    public virtual void Honk()          //CAN be overridden: has default behavior
    {
        Console.WriteLine("Beep!");
    }
}



//Test: create an abstract Shape class with two abstract methods, then implement two concrete shapes:
//          Shape(abstract class):
//              public abstract double CalculateArea()
//              public abstract double CalculatePerimeter()
//          Circle(inherits Shape):
//              Constructor takes radius (double)
//              Area = π × radius²
//              Perimeter = 2 × π × radius
//          Rectangle (inherits Shape):    
//              Constructor takes width and height (doubles)
//              Area = width × height
//              Perimeter = 2 × (width + height)
public abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

public class Circle : Shape
{
    public double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(radius, 2);    
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

public class Rectangle : Shape
{
    public double width;
    public double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double CalculateArea()
    {
        return width * height;
    }

    public override double CalculatePerimeter()
    {
        return (height + width) * 2;
    }
}