//Using delegates

//Once you have a delegate type defined, you can create instances of it by assigning methods that match its signature.
//You can then invoke the delegate just like calling a regular method.


//Assigning Methods to Delegates
Calculator calc = Add;          //Direct assignment
Calculator calc2 = Multiply;    //Different method, same signature


//Invoking Delegates
int result = calc(5, 3);            //Once assigned, invoke like a regular method       //Calls Add(5, 3), returns 8
int result2 = calc.Invoke(10, 2);   //You can also use .Invoke() explicitly             //Same as calc(10, 2)


//Delegates as Parameters
static int ApplyTwice(int value, Calculator operation)  //Methods can accept delegates as parameters
{
    int temp = operation(value, value);
    return operation(temp, temp);
}

int doubled = ApplyTwice(2, Add);       //(2+2) then (4+4) = 8
int squared = ApplyTwice(2, Multiply);  //(2*2) then (4*4) = 16


static int Add(int a, int b) => a + b;      //Methods that match the delegate signature
static int Multiply(int a, int b) => a * b;

public delegate int Calculator(int x, int y);   //Define a delegate type



//Test: you are given a Greeter delegate and three greeting methods already defined.
//      Complete the ExecuteGreeting method that takes a name and a Greeter delegate,
//      then invokes the delegate with the name and returns the result.
public delegate string Greeter(string name);

public class Solution
{
    public static string FormalGreeting(string name)
    {
        return $"Good day, {name}. How may I assist you?";
    }

    public static string CasualGreeting(string name)
    {
        return $"Hey {name}! What's up?";
    }

    public static string ShortGreeting(string name)
    {
        return $"Hi {name}!";
    }

    public static string ExecuteGreeting(string name, Greeter greeter)
    {
        return greeter(name);
    }
}