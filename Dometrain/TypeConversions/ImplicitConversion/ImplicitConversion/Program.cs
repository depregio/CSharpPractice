//Implicit conversion

//Implicit conversion happens automatically when you assign a value of one type to a variable of a compatible larger type,
//without any data loss.

//Implicit conversions are safe. They are allowed when no data can be lost.
//An int can hold values from -2,147,483,648 to 2,147,483,647.
//A double can hold much larger values plus decimals, so any int fits safely inside a double

//Common implicit conversions:
//      FROM    TO	    EXAMPLE
//      int	    long	long x = 100;
//      int     float	float x = 100;
//      int     double	double x = 100;
//      float   double	double x = 3.14f;
//      char    int	    int x = 'A'; (65)


//How implicit conversion works
int wholeNumber = 42;
double decimalNumber = wholeNumber;  //Implicit conversion: 42 becomes 42.0

int small = 100;
long big = small;       //int to long is also implicit

float f = 3.14f;
double d = f;           //float to double is implicit


//Why it's safe
int age = 25;               //Safe: double can hold any int value
double ageAsDouble = age;   //25.0

double price = 19.99;       //Not allowed implicitly (would lose decimal precision)
int priceAsInt = price;     //Compiler error


//Test: write a method that takes an int parameter and returns it as a double using implicit conversion.
//      Simply assign the int to a double variable and return it.
public class Solution
{
    public static double ConvertToDouble(int number)
    {
        double convertedInt = number;
        return convertedInt;            //return number; would have also been enough.
    }
}