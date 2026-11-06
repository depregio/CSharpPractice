//Statement lambdas (multi-line lambdas)

//When a lambda expression needs multiple statements, you use curly braces { } to create a statement lambda (also called a block lambda).


//Expression lambda vs statement lambda
Func<int, int> square = x => x * x;     //Expression lambda: single expression, implicit return

Func<int, int> process = x =>           //Statement lambda: multiple statements, explicit return required
{
    int doubled = x * 2;
    int result = doubled + 5;
    return result;  // Must use 'return' keyword
};


//Statement lambda syntax
Func<int, int> transform = n =>             //With one parameter
{
    int step1 = n * 2;
    int step2 = step1 + 10;
    return step2;
};

Func<int, int, int> combine = (a, b) =>     //With multiple parameters
{
    int sum = a + b;
    int product = a * b;
    return sum + product;
};



//Test: create a statement lambda that processes a number through multiple steps:
//          If the number is negative, convert it to positive (absolute value)
//          Double the number
//          Add 10 to the result
//          Return the final value
public class Solution
{
    public static int ProcessNumber(int number, Func<int, int> processor)
    {
        return processor(number);
    }

    public static int RunComplexProcessing(int number)
    {
        Func<int, int> complexProcessor = num =>
        {
            if (num < 0)
                num *= -1;
            num *= 2;
            num += 10;
            return num;
        };

        return ProcessNumber(number, complexProcessor);
    }
}