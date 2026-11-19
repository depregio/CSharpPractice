//Unchecked arithmetic

//By default, C# allows integer overflow to wrap around silently.
//The unchecked keyword explicitly allows this behavior, even when the project has overflow checking enabled globally.

//Why use unchecked?
//      Performance-critical code where overflow is acceptable.
//      When project has <CheckForOverflowUnderflow>true</CheckForOverflowUnderflow> unchecked block overrides the global setting.
//      It's common for hash calculations to overflow.

//Checked vs unchecked comparison:
//      KEYWORD     OVERFLOW BEHAVIOUR	        USE CASE
//      checked	    Throws OverflowException	Financial calculations, critical data
//      unchecked	Wraps around silently	    Hash functions, bit manipulation


//Default behavior vs unchecked
int result1 = int.MaxValue + 1;     //Wraps to int.MinValue         //Both produce the same result by default

unchecked
{
    int result2 = int.MaxValue + 1; //Also wraps to int.MinValue
}


//Hash calculations often overflow
unchecked
{
    int hash = value1 * 31 + value2;    
}


//Wrap-around behaviour
unchecked
{
    int max = int.MaxValue;     //2147483647
    int overflow = max + 1;     //-2147483648 (wraps to int.MinValue)

    int min = int.MinValue;     //-2147483648
    int underflow = min - 1;    //2147483647 (wraps to int.MaxValue)
}



//Test: write a method that adds two integers using an unchecked block, allowing overflow to wrap around without throwing an exception.
public class Solution
{
    public static int UncheckedAdd(int a, int b)
    {
        int result;

        unchecked
        {
            result = a + b;
        }

        return result;      //return unchecked(a + b); for the whole method is also valid
    }
}