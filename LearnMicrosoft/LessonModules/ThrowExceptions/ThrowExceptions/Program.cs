//For the reference materials with additional information:
//https://learn.microsoft.com/en-us/training/modules/create-throw-exceptions-c-sharp/7-summary

/*
The ability to generate an exception in response to a specific condition, issue, or error helps you to ensure the stability of your application.

The created exception type depends on the coding issue, and should match the intended purpose of the exception as closely as possible.
Here are some common exception types that you might use when creating an exception:
    
    -ArgumentException or ArgumentNullException:
        Use these exception types when a method or constructor is called with an invalid argument value or null reference.
    -InvalidOperationException:
        Use this exception type when the operating conditions of a method don't support the successful completion of a particular method call.
    -NotSupportedException:
        Use this exception type when an operation or feature is not supported.
    -IOException:
        Use this exception type when an input/output operation fails.
    -FormatException:
        Use this exception type when the format of a string or data is incorrect.
*/

//Throw an exception
ArgumentException invalidArgumentException = new ArgumentException("ArgumentException: The 'GraphData' method received data outside the expected range.");
throw invalidArgumentException;

//or

throw new FormatException("FormatException: Calculations in process XYZ have been cancelled due to invalid data format.");

/*
The Message property of an exception is readonly. Therefore, a custom Message property must be set when instantiating the object.
When customizing an exception object, it's important to provide clear error messages that describe the problem and how to resolve it.

The Message property should explain the reason for the exception. 
However, information that's sensitive, or that represents a security concern shouldn't be put in the message text.

The StackTrace property is often used to track the origin of the exception.
This string property contains the name of the methods on the current call stack, together with the file name and line number in each method that's associated with the exception.
A StackTrace object is created automatically by the common language runtime (CLR) from the point of the throw statement.
Exceptions must be thrown from the point where the stack trace should begin.
*/


//When to throw an exception
string[][] userEnteredValues = new string[][]
{
        new string[] { "1", "two", "3"},
        new string[] { "0", "1", "2"}
};

foreach (string[] userEntries in userEnteredValues)
{
    try
    {
        BusinessProcess1(userEntries);
    }
    catch (Exception ex)
    {
        if (ex.StackTrace.Contains("BusinessProcess1") && (ex is FormatException))
        {
            Console.WriteLine(ex.Message);
        }
    }
}

static void BusinessProcess1(string[] userEntries)  //Methods should throw an exception whenever they can't complete their intended purpose.
{                                                   //The exception thrown should be based on the most specific exception available that fits the error conditions.
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        try
        {
            valueEntered = int.Parse(userValue);

            // completes required calculations based on userValue
            // ...
        }
        catch (FormatException)
        {
            FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
            throw invalidFormatException;   //The exception is caught in the top-level statements as an object named ex
        }                                   //Throwing it to the next try-catch
    }
}


//Re-throwing exceptions
try
{
    OperatingProcedure1();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);              //An error occurred - 
    Console.WriteLine("Exiting application.");
}

static void OperatingProcedure1()
{
    string[][] userEnteredValues = new string[][]
    {
        new string[] { "1", "two", "3"},
        new string[] { "0", "1", "2"}
    };

    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            BusinessProcess2(userEntries);
        }
        catch (Exception ex)
        {
            if (ex.StackTrace.Contains("BusinessProcess2"))
            {
                if (ex is FormatException)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Corrective action taken in OperatingProcedure1");
                }
                else if (ex is DivideByZeroException)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

                    // re-throw the original exception
                    throw;  //When you re-throw an exception, the original exception object is used, so you don't lose any information about the exception.
                }
                else
                {
                    // create a new exception object that wraps the original exception
                    throw new ApplicationException("An error occurred - ", ex);
                }   //You can pass the original exception as an argument to the constructor of a new exception object.
            }
        }

    }
}

static void BusinessProcess2(string[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        try
        {
            valueEntered = int.Parse(userValue);

            checked
            {
                int calculatedValue = 4 / valueEntered;
            }
        }
        catch (FormatException)
        {
            FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess2' must be valid integers");
            throw invalidFormatException;
        }
        catch (DivideByZeroException)
        {
            DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess2' encountered an unexpected divide by zero");
            throw unexpectedDivideByZeroException;

        }
    }
}

/*
Things to avoid when throwing exceptions

    -Don't use exceptions to change the flow of a program as part of ordinary execution. Use exceptions to report and handle error conditions.
    -Exceptions shouldn't be returned as a return value or parameter instead of being thrown.
    -Don't throw System.Exception, System.SystemException, System.NullReferenceException, or System.IndexOutOfRangeException intentionally from your own source code.
    -Don't create exceptions that can be thrown in debug mode but not release mode. To identify runtime errors during the development phase, use Debug.Assert instead.
*/


//Sample application to create and throw an exception
// Prompt the user for the lower and upper bounds
Console.Write("Enter the lower bound: ");
int lowerBound = int.Parse(Console.ReadLine());

Console.Write("Enter the upper bound: ");
int upperBound = int.Parse(Console.ReadLine());

decimal averageValue = 0;

bool exit = false;

do
{
    try
    {
        // Calculate the sum of the even numbers between the bounds
        averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

        // Display the result to the user
        Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

        exit = true;
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine("An error has occurred.");
        Console.WriteLine(ex.Message);
        Console.WriteLine($"The upper bound must be greater than {lowerBound}");

        //What if the user doesn't have a valid upper bound value to enter and needs to exit the loop?
        Console.Write($"Enter a new upper bound (or enter Exit to quit): ");
        string? userResponse = Console.ReadLine();
        if (userResponse.ToLower().Contains("exit"))
        {
            exit = true;
        }
        else
        {
            exit = false;
            upperBound = int.Parse(userResponse);
        }
    }
} while (exit == false);

// Wait for user input
Console.ReadLine();

static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
{

    if (lowerBound >= upperBound)
    {
        throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
    }

    int sum = 0;
    int count = 0;
    decimal average = 0;

    for (int i = lowerBound; i <= upperBound; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
            count++;
        }
    }

    average = (decimal)sum / count;

    return average;
}



//Test: create and throw exceptions
string[][] userEnteredValues2 = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

try
{
    Workflow1(userEnteredValues2);
    Console.WriteLine("'Workflow1' completed successfully.");
}
catch(DivideByZeroException exceptionDivideZero)
{
    Console.WriteLine("An error occurred during 'Workflow1'.");
    Console.WriteLine(exceptionDivideZero.Message);
}

static void Workflow1(string[][] userEnteredValues2)
{

    foreach (string[] userEntries in userEnteredValues2)
    {
        try
        {
            Process1(userEntries);
            Console.WriteLine("'Process1' completed successfully.");
            Console.WriteLine();
        }
        catch (FormatException exceptionFormat)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(exceptionFormat.Message);
            Console.WriteLine();
        }
    }
}

static void Process1(string[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        bool integerFormat = int.TryParse(userValue, out valueEntered);

        if (integerFormat == true)
        {
            if (valueEntered != 0)
            {
                checked
                {
                    int calculatedValue = 4 / valueEntered;
                }
            }
            else
            {
                throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
            }
        }
        else
        {
            throw new FormatException("Invalid data. User input values must be valid integers.");
        }
    }
}