//Explicit conversion (casting)

//Explicit conversion, also called casting, is required when you convert from a larger type to a smaller type,
//or between incompatible types where data loss might occur.

//Unlike implicit conversion (which happens automatically),
//explicit conversion requires you to explicitly tell the compiler "I know this might lose data, but do it anyway."

//Implicit vs explicit conversion
//      CONVERSION      EXAMPLE	                TYPE
//      int → double	double d = 5;           Implicit(safe)
//      double → int	int i = (int)5.9;       Explicit(may lose data)
//      long → int	    int i = (int)bigNum;    Explicit(may overflow)


//Why casting is required
double price = 19.99;
int wholePrice = (int)price;    //Explicit cast required. Result is 19.


//Casting syntax
double d = 9.7;                 //Place the target type in parentheses before the value: (targetType)value.
int i = (int)d;                 //i = 9 (truncated, not rounded!)

long bigNumber = 1000L;
int smaller = (int)bigNumber;   //Works if value fits in int


//Truncation vs rounding
double a = 3.9;     //Important: Casting to int truncates(removes) the decimal part, it does NOT round.
int x = (int)a;     //x = 3 (not 4)

double b = -2.7;
int y = (int)b;     //y = -2 (truncates toward zero)



//Test: implement a method that takes a double value and returns it cast to an int. Observe how the decimal portion is truncated.
public class Solution
{
    public static int CastToInt(double value)
    {
        return (int)value;
    }
}