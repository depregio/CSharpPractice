//The Lock type

//C# 13 introduces System.Threading.Lock,
//a dedicated type for thread synchronization that's more efficient and explicit
//than using the traditional lock statement with an object.

//Why use the Lock type?
//      ASPECT          TRADITIONAL LOCK	LOCK TYPE
//      Type safety	    Uses any object	    Dedicated Lock type
//      Intent	        Implicit	        Explicit
//      Performance	    Good	            Optimized for locking
//      Scope Control	Automatic	        Via EnterScope()


//Traditional lock vs Lock type
private static readonly object _syncRoot = new object();    //Old way: using lock with object
lock (_syncRoot)
{
    //critical section
}

private static readonly Lock _lock = new Lock();            //New way: using Lock type
using (_lock.EnterScope())
{
    // critical section
}


//Using EnterScope()
private static readonly Lock _lock = new Lock();

void ThreadSafeMethod()
{                                   //The EnterScope() method returns a Lock.Scope struct that implements IDisposable.
    using (_lock.EnterScope())      //This allows you to use the using statement for automatic lock release.
    {
        //This code is thread-safe
        //Lock is automatically released when scope ends
    }
}



//Test: complete the SafeIncrement method to safely increment the _counter field using the Lock type.
//      Multiple threads will call this method simultaneously, so you must ensure thread safety.
public class Solution
{
    private static int _counter = 0;
    private static readonly Lock _lock = new Lock();

    public static int IncrementCounter(int times)
    {
        //Resets counter for each test
        _counter = 0;

        //Creates multiple threads that increment the counter
        Thread[] threads = new Thread[times];

        for (int i = 0; i < times; i++)
        {
            threads[i] = new Thread(() => SafeIncrement());
            threads[i].Start();
        }

        //Waits for all threads to complete
        foreach (var thread in threads)
        {
            thread.Join();
        }

        return _counter;
    }

    private static void SafeIncrement()
    {
        using (_lock.EnterScope()) 
        {
            _counter++;
        }
    }
}