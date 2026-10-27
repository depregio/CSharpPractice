//The static keyword

//The static keyword means something belongs to the type itself, not to individual instances (objects) of that type.
//Static members are shared across all uses of the class through the same copy in memory. They are not shared through different instances.

//A static field is shared by all code that accesses the class.
//There's only one copy of it, no matter how many times you call methods on the class.

//Static methods belong to the class, not to an object. You call them using the class name directly without instantiation.

//Why Use Static?
//      Utility methods:    Functions that don't need object state (like Math.Sqrt)
//      Shared state:       Counters, configuration, or caches shared across the app
//      Factory methods:    Methods that create objects


//Static methods
int result = Math.Max(5, 10);       //Math is a class, Max is a static method.
string text = Console.ReadLine();   //Console is a class, ReadLine is a static method.


//Static fields
public class Counter
{
    private static int count = 0;   //Shared across all calls

    public static int GetCount()
    {
        return count;
    }
}



//Test: create a simple ID generator using a static counter. Implement three methods:
//          GetNextId():        Increments the counter and returns the new value
//          GetCurrentCount():  Returns the current counter value without changing it
//          ResetCounter():     Resets the counter back to 0
public class IDGenerator
{
    private static int counter = 0;

    public static int GetNextId()
    {
        return ++counter;   //return counter++; would return the actual counter and then increment. This does the opposite.
    }

    public static int GetCurrentCount()
    {
        return counter;
    }

    public static void ResetCounter()
    {
        counter = 0;
    }
}