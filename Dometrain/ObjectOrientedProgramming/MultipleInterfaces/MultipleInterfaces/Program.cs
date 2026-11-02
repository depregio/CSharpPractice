//Multiple interfaces

//A class can implement multiple interfaces, giving it capabilities from different contracts.
//This is powerful because C# doesn't support multiple class inheritance, but a class can implement as many interfaces as needed.


//Syntax for multiple interfaces
using System.Numerics;

public class MyClass : IFirstInterface, ISecondInterface    //Must implement ALL methods from BOTH interfaces
{
    public void MethodFromFirst() { }
    public void MethodFromSecond() { }
}

public interface IFirstInterface
{
    public void MethodFromFirst();
}
public interface ISecondInterface
{
    public void MethodFromSecond();
}


//Why use multiple interfaces?
public interface ISwimmable { void Swim(); }    //Each interface defines a specific capability
public interface IFlyable { void Fly(); }

public class Duck : ISwimmable, IFlyable        //A duck can do both
{
    public void Swim() => Console.WriteLine("Swimming");
    public void Fly() => Console.WriteLine("Flying");
}


//Interface segregation
public interface IPrintable { void Print(); }   //Multiple small interfaces are often better than one large interface
public interface ISaveable { void Save(); }     //Focused interfaces are a good approach

public class Document : IPrintable, ISaveable   //A document might implement both
{
    public void Print() { }
    public void Save() { }
}



//Test: implement a Robot class that implements both IMovable and ISoundMaker interfaces.
//      
//      The interfaces are defined in Interfaces.cs (read-only):
//          IMovable has a Move() method returning a string
//          ISoundMaker has a MakeSound() method returning a string
//
//      Your Robot class should :      
//          Return "Moving forward" from Move()
//          Return "Beep boop!" from MakeSound()
//
//      Also complete the TestRobot method to call both methods and return the combined result.
public class Solution
{
    public static string TestRobot(Robot robot)
    {
        return robot.Move() + " " + robot.MakeSound();
    }
}


public class Robot : IMovable, ISoundMaker
{
    public string Move()
    {
        return "Moving forward";
    }

    public string MakeSound()
    {
        return "Beep boop!";
    }
}

public interface IMovable
{
    string Move();
}

public interface ISoundMaker
{
    string MakeSound();
}