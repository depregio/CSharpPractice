//Generic constraints

//Generic constraints restrict which types can be used as type arguments.
//They ensure the generic type has specific capabilities, enabling you to safely use certain operations within the generic code.


//The where keyword
static T DoSomething<T>() where T : new()    //Syntax: where T : constraint
{
    return new T();                                             //Only works because of the constraint
}

static void Process<T>(T item) where T : class
{
    Console.WriteLine(item == null ? "null" : item.ToString()); //T must be a reference type
}

static T Compare<T>(T a, T b) where T : struct
{
    return a.Equals(b) ? a : b;                                 //T must be a value type
}


//Common constraints:
//CONSTRAINT            DESCRIPTION	                            EXAMPLE
//where T : new()       T must have a parameterless constructor	Allows new T()
//where T : class       T must be a reference type	            Classes, interfaces
//where T : struct      T must be a value type	                int, double, structs
//where T : SomeClass   T must inherit from SomeClass	        Ensures inheritance
//where T : IInterface  T must implement IInterface	            Ensures capability


//Why constraints matter
static T Create<T>()    //Without constraint this won't compile
{
    return new T();     //Error: T might not have a constructor. It wouldn't work if T were to be an int for example.
}

static T Create2<T>() where T : new()    //With constraint compiler knows T can be instantiated
{
    return new T();
}



//Test: create a generic method CreateInstance<T>() that creates and returns a new instance of type T.
//      The method must use the new() constraint to ensure only types with a parameterless constructor can be used.
public class Solution
{
    public static T CreateInstance<T>() where T : new()
    {
        return new T();
    }
}

public class Person
{
    public string Name { get; set; } = "Unknown";
    public int Age { get; set; } = 0;
}

public class Product
{
    public string Title { get; set; } = "Untitled";
    public decimal Price { get; set; } = 0m;
}

public class Counter
{
    public int Count { get; set; } = 0;
}