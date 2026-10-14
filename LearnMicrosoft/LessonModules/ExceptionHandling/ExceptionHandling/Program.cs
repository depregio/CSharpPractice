/*
Exception handling in C# is implemented by using the try, catch, and finally keywords.

    The try code block contains the guarded code that may cause an exception. 
    If the code within a try block causes an exception, the exception is handled by a corresponding catch block.

    The catch code block contains the code that's executed when an exception is caught.
    The catch block can handle the exception, log it, or ignore it.
    A catch block can be configured to execute when any exception type occurs, or only when a specific type of exception occurs.

    The finally code block contains code that executes whether an exception occurs or not.
    The finally block is often used to clean up any resources that are allocated in a try block.
    For example, ensuring that a variable has the correct or required value assigned to it.


The .NET runtime throws exceptions when basic operations fail. Here's a short list of runtime exceptions and their error conditions:

    ArrayTypeMismatchException:
        Thrown when an array can't store a given element because the actual type of the element is incompatible with the actual type of the array.
    DivideByZeroException:
        Thrown when an attempt is made to divide an integral value by zero.
    FormatException:
        Thrown when the format of an argument is invalid.
    IndexOutOfRangeException:
        Thrown when an attempt is made to index an array when the index is less than zero or outside the bounds of the array.
    InvalidCastException:
        Thrown when an explicit conversion from a base type to an interface or to a derived type fails at runtime.
    NullReferenceException:
        Thrown when an attempt is made to reference an object whose value is null.
    OverflowException:
        Thrown when an arithmetic operation in a checked context overflows.
*/


//Implement a simple try-catch
double float1 = 3000.0;
double float2 = 0.0;
int number1 = 3000;
int number2 = 0;

try                 //C# syntax requires a catch or finally clause when you use a try statement.
{
    Console.WriteLine(float1 / float2);     //∞         //Dividing a float or double by 0 gives infinity
    Console.WriteLine(number1 / number2);   //DivideByZeroException
}
catch
{
    Console.WriteLine("An exception has been caught");
}

Console.WriteLine("Exit program");

/*
When an exception is thrown and the current method doesn't catch the exception, the common language runtime will unwind the stack,
looking for a method that contains a catch clause that can handle the exception.
The first catch clause found that can handle the exception will be executed. If no appropriate catch clause is found 
anywhere in the call stack, the common language runtime will terminate the process and display an error message to the user.
*/
//Catch exceptions thrown in called methods
try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    WriteMessage();
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}



//Test: update the Process2 method to catch the exception that's thrown in the WriteMessage method.
try
{
    Process2();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process2()
{
    try
    {
        WriteMessage2();
    }
    catch
    {
        Console.WriteLine("Exception caught in Process2");
    }
}

static void WriteMessage2()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}


/*
System.Exception is the base class that all derived exception types inherit from.

Here are the properties of the Exception class:
    Data:           The Data property holds arbitrary data in key-value pairs.
    HelpLink:       The HelpLink property can be used to hold a URL (or URN) to a help file that provides extensive information about the cause of an exception.
    HResult:        The HResult property can be used to access to a coded numerical value that's assigned to a specific exception.
    InnerException: The InnerException property can be used to create and preserve a series of exceptions during exception handling.
    Message:        The Message property provides details about the cause of an exception.
    Source:         The Source property can be used to access the name of the application or the object that causes the error.
    StackTrace:     The StackTrace property contains a stack trace that can be used to determine where an error occurred.
    TargetSite:     The TargetSite property can be used to get the method that throws the current exception.

*/

//Catch specific exception types
try
{
    Process3();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process3()
{
    try
    {
        WriteMessage3();
    }
    catch (Exception ex)    //Although the catch clause can be used without arguments, that approach is not recommended.
    {                       //If you don't specify an argument, all exception types are caught and you can't decern between them.
        Console.WriteLine($"Exception caught in Process3: {ex.Message}");   //Exception caught in Process1: Attempted to divide by zero.
    }
}

static void WriteMessage3()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}

//In general, you should only catch the exceptions that your code knows how to recover from.
//Therefore, your catch clause should specify an object argument that's derived from System.Exception.
//Now that you know the type of exception to catch, you can update your catch clause to handle that specific exception type.
try
{
    Process4();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process4()  //Your Process4 method will only catch exceptions of the specific type that it's prepared to handle.
{                       //If a different exception type is met, it will be caught by the more generic catch above
    try
    {
        WriteMessage4();
    }
    catch (DivideByZeroException ex)    //The exception type should be as specific as possible.
    {                                   //This helps to avoid catching exceptions that your exception handler isn't able to resolve.
        Console.WriteLine($"Exception caught in Process4: {ex.Message}");
    }
}

static void WriteMessage4()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    byte smallNumber;

    Console.WriteLine(float1 / float2);
    //Console.WriteLine(number1 / number2);
    checked     //When performing integral type calculations the result depends on the overflow-checking context.
    {           //In a checked context, the conversion succeeds if the source value is within the range of the destination type.
        smallNumber = (byte)number1;    //Otherwise, an OverflowException is thrown.
    }           //Integral type calculations that are not inside a checked code block are treated as if they are inside an unchecked code block.
}


//Catch multiple exceptions in a code block
try
{
    Process5();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process5()
{
    try
    {
        WriteMessage5();
    }
    catch (OverflowException ex)
    {
        Console.WriteLine($"Exception caught in Process5: {ex.Message}");
    }
}

static void WriteMessage5()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    byte smallNumber;

    try     //Without this the code would catch the DivideByZeroException and exit the method call, skipping the checked section entirely.
    {
        Console.WriteLine(float1 / float2);
        Console.WriteLine(number1 / number2);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in WriteMessage5: {ex.Message}");
    }
    
    checked
    {
        smallNumber = (byte)number1;
    }
}


//Catch separate exception types in a code block
string[] inputValues = new string[] { "three", "9999999999", "0", "2" };    // inputValues is used to store numeric values entered by a user

foreach (string inputValue in inputValues)
{
    int numValue = 0;
    try
    {
        numValue = int.Parse(inputValue);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid readResult. Please enter a valid number.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The number you entered is too large or too small.");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}



//Test: catch specific exceptions
checked
{
    try
    {
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;
        int result = num1 + num2;
        Console.WriteLine("Result: " + result);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
    }
}

try
{
    string str = null;
    int length = str.Length;
    Console.WriteLine("String Length: " + length);
}
catch (System.NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null. " + ex.Message);
}

try
{
    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range. " + ex.Message);
}

try 
{
    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
}

Console.WriteLine("Exiting program.");