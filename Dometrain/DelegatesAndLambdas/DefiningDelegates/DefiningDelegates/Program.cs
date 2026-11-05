//Delegates

//A delegate is a type that represents references to methods with a specific signature.
//Think of it as a "method pointer" that lets you pass methods as parameters.


//Declaring a Delegate Type
public delegate int CalcOperation(int x, int y);    
public delegate void Logger(string message);
public delegate bool Predicate(int value);


//Using Delegates
public static int Add(int x, int y) => x + y;   //Create a method

public delegate int Calculator(int a, int b);   //Declare a delegate type that matches the signature

Calculator calc = Add;                          //Create a delegate instance pointing to the method

int result = calc(5, 3);  //result = 8          //Invoke the delegate (calls the referenced method)


//Delegates as parameters to pass behaviour around like data
static int Execute(int a, int b, Calculator operation)  //Methods can accept delegates as parameters
{
    return operation(a, b);  //Invoking the delegate
}

// Call with different methods
int sum = Execute(10, 5, Add);          //15
int sum2 = Execute(10, 5, calc);        //15
int diff = Execute(10, 5, Subtract);    //5

static int Subtract(int x, int y) => x - y;



//Test: 
//      Define a delegate type called MathOperation that:
//          Takes two int parameters
//          Returns an int
//      Implement ApplyOperation that:    
//          Takes two integers and a MathOperation delegate
//          Invokes the delegate with the two integers
//          Returns the result
public delegate int MathOperation(int a, int b);

public class Solution
{
    public static int ApplyOperation(int a, int b, MathOperation operation)
    {
        return operation(a,b);
    }

    // Helper methods you can use with your delegate
    public static int Add(int x, int y) => x + y;
    public static int Subtract(int x, int y) => x - y;
    public static int Multiply(int x, int y) => x * y;
    public static int Divide(int x, int y) => x / y;
}