//The using statement

//The using statement ensures that IDisposable objects are properly cleaned up when you're done with them, even if an exception occurs.
//This is how C# manages files, database connections, network sockets, and locks.

//Types that hold resources implement IDisposable. When Dispose() is called, the held resource is released.
//The classic using syntax wraps code in braces, Dispose() is called at the closing brace.

//Why it matters:
//once the using block ends, Dispose() has run and the resource has been released.
//If the resource was a lock, the item is now free for someone else to use.
//WITHOUT USING:	                WITH USING:
//Must remember to call Dispose()	Automatic cleanup
//Exceptions can skip cleanup	    Cleanup even on exceptions
//Resource leaks / stuck locks	    Resources always released


//IDisposable pattern
public class DatabaseConnection : IDisposable
{
    public void Dispose()
    {
        // Close the connection automatically
    }
}


//Traditional using block
using (var connection = new DatabaseConnection("server1"))  //"I am using this class with :IDisposable so it will have a Dispose() that I'll use after }"
{
    connection.RunQuery("SELECT * FROM users");
} //Dispose() called here automatically, connection is now closed.



//Test: implement three methods that use the LockedResource class:
//          ProcessLockedResource(resourceName, content):   Use a using block to acquire the resource, process the content,
//                                                              and return the result.
//          IsResourceAvailable(resourceName):              Return whether the given resource name is currently available (not locked).
//          ProcessThenReport(resourceName, content):       Use a using block to process the content.
//                                                              After the using block ends (so the lock has been released),
//                                                              check whether the resource is available again.
//                                                              Return: "Result: {processed}, ReleasedAfterUse: {isAvailable}".
public class Solution
{
    public static string ProcessLockedResource(string resourceName, string content)
    {
        using (var resource = new LockedResource(resourceName))
        {
            string processedResult = resource.Process(content);
            return processedResult;                 //return before } from the using block is safe.
        }   //using is a shorthand for try/finally. finally always runs on the way out, even through a return. So it will not be skipped.
    }

    public static bool IsResourceAvailable(string resourceName)
    {
        return LockedResource.IsAvailable(resourceName);
    }

    public static string ProcessThenReport(string resourceName, string content)
    {
        string processedResult; //Variables declared inside a using block don't exist after it.
                                //To use a result afterward, declare it before the block and assign inside.

        using (var resource = new LockedResource(resourceName))
        {
            processedResult = resource.Process(content);
        }

        bool isAvailable = LockedResource.IsAvailable(resourceName);
        return $"Result: {processedResult}, ReleasedAfterUse: {isAvailable}";
    }
}


/*
LockedResource class key members:
MEMBER	                                    DESCRIPTION
new LockedResource(name)	                Acquires (locks) the resource. Throws if already locked.
Process(content)	                        Returns "[name] Processed: content".
LockedResource.IsAvailable(name) (static)	Returns true if the resource is NOT currently locked.
Dispose()	                                Releases the lock (called automatically by using). 
 */
/// <summary>
/// Represents a resource that can only be accessed by one user at a time.
/// Implements IDisposable to automatically release the lock when done.
/// </summary>
public class LockedResource : IDisposable
{
    private static readonly HashSet<string> _lockedResources = new HashSet<string>();
    private readonly string _resourceName;
    private bool _disposed = false;

    public string ResourceName => _resourceName;
    public bool IsLocked => !_disposed;

    public LockedResource(string resourceName)
    {
        if (string.IsNullOrEmpty(resourceName))
            throw new ArgumentException("Resource name cannot be empty", nameof(resourceName));

        if (_lockedResources.Contains(resourceName))
            throw new InvalidOperationException($"Resource '{resourceName}' is already locked");

        _resourceName = resourceName;
        _lockedResources.Add(resourceName);
    }

    public string Process(string content)
    {
        if (_disposed)
            throw new ObjectDisposedException(nameof(LockedResource));

        return $"[{_resourceName}] Processed: {content}";
    }

    public static bool IsAvailable(string resourceName)
    {
        return !_lockedResources.Contains(resourceName);
    }

    public void Dispose()
    {
        if (!_disposed)
        {
            _lockedResources.Remove(_resourceName);
            _disposed = true;
        }
    }
}