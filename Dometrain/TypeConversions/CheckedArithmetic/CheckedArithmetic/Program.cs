//Checked arithmetic

//By default, C# arithmetic operations silently wrap around when overflow occurs.
//The checked keyword forces the runtime to detect overflow and throw an OverflowException.

//When to use checked
//      SCENARIO                        RECOMMENDATION
//      Financial calculations	        Use checked
//      User input multiplication	    Use checked
//      Performance-critical loops	    Leave unchecked
//      Intentional wrapping (hashing)	Leave unchecked


//Unchecked vs checked behavior
int max = int.MaxValue; //2,147,483,647             //Unchecked (default): silently wraps around
int wrapped = max + 1;  //-2,147,483,648 (no error)

checked                                             //Checked: throws OverflowException
{
    int result = max + 1;                           //Throws OverflowException here
}


//Using checked blocks
checked                         //Wrap operations in a checked block
{
    int a = 1000000;
    int b = 3000;
    int product = a * b;        //Throws if overflow occurs
}

int result = checked(a * b);    //Or use checked expression for single operation


//Catching overflow
try
{
    checked
    {
        int result = int.MaxValue * 2;
    }
}
catch (OverflowException)
{
    Console.WriteLine("Overflow detected");
}



//Test: write a method that multiplies two integers safely using a checked block.
//      If the multiplication would cause overflow, catch the exception and return the string "overflow".
//      Otherwise, return the result as a string.
public class Solution
{
    public static string SafeMultiply(int a, int b)
    {
        int result;

        try
        {
            checked
            {
                result = a * b;
            }
        }
        catch (OverflowException)
        {
            return "overflow";
        }

        return Convert.ToString(result);
    }
}