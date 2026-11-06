//Lambda expressions

//A lambda expression is a concise way to write an anonymous method.
//Instead of declaring a full method, you can define inline logic using the => (arrow) syntax.


//Basic syntax
x => x * 2          //Single parameter, parentheses optional
(x) => x * 2        //Same thing with parentheses

(a, b) => a + b     //Multiple parameters, parentheses required

() => 42            //No parameters


//Lambda vs traditional method
static int Double(int x)         //Traditional method
{
    return x * 2;
}

Func<int, int> doubler = x => x * 2;    //Lambda expression


//Expression vs statement lambdas
Func<int, int> square = x => x * x;     //Expression lambda (single expression, implicit return)

Func<int, int> squareVerbose = x => {   //Statement lambda (multiple statements, explicit return)
    int result = x * x;
    return result;
};



//Test: implement three methods that each return a lambda expression:
//          GetDoubler() - returns a lambda that doubles the input
//          GetSquarer() - returns a lambda that squares the input
//          GetNegator() - returns a lambda that negates the input
public class Solution
{
    public static int ApplyTransform(int number, Func<int, int> transform)
    {
        return transform(number);
    }

    public static Func<int, int> GetDoubler()
    {
        return x => x * 2;      //In C#, a function can be treated like any other value: stored in a variable, passed as an argument, or returned.
    }

    public static Func<int, int> GetSquarer()
    {
        return x => x * x;
    }

    public static Func<int, int> GetNegator()
    {
        return x => x * -1;
    }
}