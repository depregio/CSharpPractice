//Interfaces in C#

//An interface defines a contract that classes must follow.
//It specifies what a class must do, but not how it does it.
//Use interfaces when you want unrelated classes to share common behavior.

//Interface vs abstract class
//      FEATURE:            INTERFACE:	                    ABSTRACT CLASS:
//      Implementation  ->  No method bodies	            Can have method bodies
//      Inheritance	    ->  Class can implement multiple	Class can only inherit one
//      Fields	        ->  No instance fields	            Can have fields
//      Constructor	    ->  No constructors	                Can have constructors


//Why use interfaces?

static void MoveAll(IMovable[] movables)    //You can treat different types uniformly
{
    foreach (var m in movables)
    {
        Console.WriteLine(m.Move());
    }
}
MoveAll(new IMovable[] { new Dog(), new Fish() });  //This works with any IMovable


//Defining interfaces
public interface IMovable   //Use the interface keyword
{
    string Move();          //Method signature only, no implementation
}

public interface IVehicle   //Interfaces can have multiple members
{
    int Speed { get; set; }
    string Start();
    string Stop();
}


//Implementing an interface
public class Dog : IMovable             //Must implement ALL interface members
{
    public string Move()
    {
        return "Dog is running";
    }
}

public class Fish : IMovable
{
    public string Move()
    {
        return "Fish is swimming";
    }
}


//Test: Define an IMovable interface with a single method: string Move()
//      The TestMovement method should accept any IMovable and return the result of calling Move()
//      Check Vehicles.cs - it contains Car, Boat, and Airplane classes that already implement IMovable.
//
//      Expected results:
//          TestMovement(new Car("Tesla")) -> "Tesla is driving on the road"
//          TestMovement(new Boat("Titanic"))-> "Titanic is sailing on water"
//          TestMovement(new Airplane("AA100"))-> "Flight AA100 is flying through the sky"
public interface IMovable2
{
    public string Move();
}

public class Solution
{
    public static string TestMovement(IMovable2 movable)
    {
        return movable.Move();
    }
}

public class Car : IMovable2
{
    public string Model { get; set; }

    public Car(string model)
    {
        Model = model;
    }

    public string Move()
    {
        return $"{Model} is driving on the road";
    }
}

public class Boat : IMovable2
{
    public string Name { get; set; }

    public Boat(string name)
    {
        Name = name;
    }

    public string Move()
    {
        return $"{Name} is sailing on water";
    }
}

public class Airplane : IMovable2
{
    public string FlightNumber { get; set; }

    public Airplane(string flightNumber)
    {
        FlightNumber = flightNumber;
    }

    public string Move()
    {
        return $"Flight {FlightNumber} is flying through the sky";
    }
}