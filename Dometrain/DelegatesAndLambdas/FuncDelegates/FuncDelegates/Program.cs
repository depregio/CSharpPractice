//Func delegates

//Func is a built-in generic delegate type for methods that return a value.
//While Action is for void methods, Func captures the return type as its last type parameter.


//Declaration and type parameters.
Func<int> getNumber = () => 42;                                                                     //Func<TResult>

Func<string, int> getLength = s => s.Length;    //The last type is always the type of the result.   //Func<T1, TResult>

Func<int, int, int> add = (a, b) => a + b;                                                          //Func<T1, T2, TResult>

Func<int, int, int, int> addThree = (a, b, c) => a + b + c;     //Up to 16 input parameters         //Func<T1, T2, , T3, TResult>


//Func vs Action
Action<string> print = msg => Console.WriteLine(msg);   //Executes a void method. Returns nothing. 

Func<int, int> square = x => x * x;                     //Executes non-void method. Returns a value
int result = square(5); //25


//Using Func as a Parameter
static T ExecuteTwice<T>(T value, Func<T, T> func)
{
    return func(func(value));   //The input and output types are the same, so it can feed itself.
}

Func<int, int> doubleIt = x => x * 2;
int result2 = ExecuteTwice(5, doubleIt); // ((5*2)*2) = 20   //Easier to understand as a math expression - f(f(x))


//Test: implement a calculator method that takes two integers and a Func<int, int, int> operation,
//      then returns the result of applying that operation to the two numbers.
//      This pattern allows you to pass different mathematical operations (add, subtract, multiply, etc.)
//      without changing the method signature.
//      Expected results:
//          Calculate(10, 5, (a, b) => a + b);  -> 15
//          Calculate(10, 5, (a, b) => a - b);  -> 5
//          Calculate(10, 5, (a, b) => a * b);  -> 50
public class Solution
{
    public static int Calculate(int a, int b, Func<int, int, int> operation)
    {
        return operation(a,b);
    }
}