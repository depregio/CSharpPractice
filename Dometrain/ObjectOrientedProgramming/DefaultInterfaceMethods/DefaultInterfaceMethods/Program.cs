//Default interface methods

//Default interface methods (introduced in C# 8.0) allow you to provide a default implementation for methods directly in an interface.
//Classes can choose to use the default or override it with their own implementation.


//Important: calling default interface methods
IGreeter greeter = new SimpleGreeter("Alice");
string result = greeter.Greet();                    //Returns "Hello, Alice!"

SimpleGreeter simple = new SimpleGreeter("Bob");    //Must be called through the interface type
//simple.Greet();                                   //Compiler error. Not accessible this way
string result2 = ((IGreeter)simple).Greet();        //Works after cast


//Why use default interface methods?
public interface IOldInterface      //Before C# 8: adding a method to an interface broke all implementations
{
    void ExistingMethod();      //All classes MUST implement this
    void NewMethod();           //Adding this afterwards breaks existing code!
}

public interface INewInterface      //With C# 8+: default methods provide backwards compatibility
{
    void ExistingMethod();

    public void NewMethod()     //Default behaviour implementation: existing classes don't need to change
    {
        Console.WriteLine("Default behavior");
    }
}


//Using vs overriding default methods
public interface IGreeter
{
    string Name { get; }

    public string Greet() => $"Hello, {Name}!";     //Default implementation
}

public class SimpleGreeter : IGreeter       //Uses the default: no need to implement Greet()
{
    public string Name { get; }
    public SimpleGreeter(string name) => Name = name;
}

public class FormalGreeter : IGreeter       //Overrides with custom behavior
{
    public string Name { get; }
    public FormalGreeter(string name) => Name = name;

    public string Greet() => $"Good day, {Name}. How may I assist you?";
}

//In one way or the other the interface is implemented with everything it requires, but its content becomes mutable.



//Test: complete the Bicycle and Car classes that implement IVehicle.
//          Bicycle:        implement IVehicle but do NOT override GetDescription() - let it use the default implementation
//          Car:            implement IVehicle AND override GetDescription() to return "Car: {Brand} ({Horsepower} HP)"
//          GetVehicleInfo: simply call and return the result of GetDescription() on the vehicle
public class Solution
{
    public static string GetVehicleInfo(IVehicle vehicle)
    {
        return vehicle.GetDescription();
    }
}


public class Bicycle : IVehicle
{
    public string Brand { get; }

    public Bicycle(string brand)
    {
        Brand = brand;
    }
}

public class Car : IVehicle
{
    public string Brand { get; }
    public int Horsepower { get; }

    public Car(string brand, int horsepower)
    {
        Brand = brand;
        Horsepower = horsepower;
    }

    public string GetDescription()
    {
        return $"Car: {Brand} ({Horsepower} HP)";
    }
}

public interface IVehicle
{
    string Brand { get; }

    public string GetDescription()
    {
        return $"Vehicle: {Brand}";
    }
}