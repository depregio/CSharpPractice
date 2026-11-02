//Implementing interfaces

//An interface defines a contract that classes must follow.
//When a class implements an interface, it must provide concrete implementations for all members declared in that interface.


//Working with interface types
IMovable movable = new Robot();     //You can use the interface as a type
movable.Move(10);                   //Uses the Robot's implementation

movable = new Car();         //The same variable could hold any IMovable
movable.Move(10);                   //Now uses Car's implementation


//The implementation syntax
public interface IMovable       //Interface definition
{
    int TotalDistance { get; }
    void Move(int distance);
}

public class Robot : IMovable   //Class implementing the interface
{
    public int TotalDistance { get; private set; }

    public void Move(int distance)
    {
        TotalDistance += distance;
        Console.WriteLine($"Robot moved {distance} units");
    }
}

public class Car : IMovable   //Class implementing the interface
{
    public int TotalDistance { get; private set; }

    public void Move(int distance)
    {
        TotalDistance += distance;
        Console.WriteLine($"Car moved {distance} units");
    }
}



//Test: implement the IMovable interface in the Car class. The interface is defined in IMovable.cs and requires:
//          A Move(int distance) method that adds the distance to TotalDistance
//          A TotalDistance property (already declared, just needs the Move method to update it)
//          Then complete GetTotalDistanceTraveled to move the car according to each value in the movements array and return the total distance.
public class Solution
{
    public static int GetTotalDistanceTraveled(Car car, int[] movements)
    {
        foreach(int movement in movements)
        {
            car.Move(movement);
        }

        return car.TotalDistance;
    }
}

public class Car2 : IMovable2
{
    public string Model { get; set; }
    public int TotalDistance { get; private set; }

    public Car2(string model)
    {
        Model = model;
        TotalDistance = 0;
    }

    public void Move(int distance)
    {
        TotalDistance += distance;
    }
}

public interface IMovable2
{
    int TotalDistance { get; }
    void Move(int distance);
}