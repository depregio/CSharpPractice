//The out keyword

//The out keyword allows a method to return additional values by passing variables that the method will assign.
//Unlike ref, out parameters don't need to be initialized before passing.
//But they MUST be assigned inside the method before returning.


//Method with out parameters
static bool CustomTryParse(string input, out int result)
{
    result = 0;     //Assign default

    if (int.TryParse(input, out int parsed))
    {
        result = parsed;
        return true;
    }
    return false;
}

int value;
if (CustomTryParse("42", out value))    //true
{
    Console.WriteLine(value);   //42
}


//You can use more than one out parameter per method
int quotient;
int remainder;
Divide(10, 3, out quotient, out remainder);

//C# allows declaring out variables inline when calling a method.
Divide(10, 3, out int quotientInline, out int remainderInline);

static void Divide(int dividend, int divisor, out int quotient, out int remainder)
{
    quotient = dividend / divisor;
    remainder = dividend % divisor;
}



//Test: create a Divide method that performs integer division and returns both the quotient and remainder using out parameters.
static bool TryDivide(int dividend, int divisor, out int quotient, out int remainder)
{
    if (divisor is not 0)
    {
        quotient = dividend / divisor;
        remainder = dividend % divisor;
        return true;
    }
    else
    {
        quotient = 0;
        remainder = 0;
        return false;
    }
}