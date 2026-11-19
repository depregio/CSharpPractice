//Parse methods

//Parse methods convert string representations of values into their corresponding data types.
//Use them when you have user input or text data that needs to be converted to numbers.

//Parse methods throw a FormatException if the string is not a valid number.

//Common parse methods
//      METHOD          DESCRIPTION	        EXAMPLE
//      int.Parse(s)	String to integer	int.Parse("42") = 42
//      double.Parse(s)	String to double	double.Parse("3.14") = 3.14
//      bool.Parse(s)	String to boolean	bool.Parse("True") = true
//      long.Parse(s)	String to long	    long.Parse("999999999")


//Basic usage
int number = int.Parse("42");           //number = 42       //int.Parse converts a string to an integer
int negative = int.Parse("-15");        //negative = -15

double price = double.Parse("19.99");   //price = 19.99     //double.Parse converts a string to a double
double pi = double.Parse("3.14159");    //pi = 3.14159


//Parse vs convert
int fromParse = int.Parse("100");               //100           //Both achieve similar results for valid strings
int fromConvert = Convert.ToInt32("100");       //100

int fromConvertNull = Convert.ToInt32(null);    //Returns 0     //Key difference: Convert handles null gracefully
int fromParseNull = int.Parse(null);            //Throws exception


//Important: parse throws exceptions
int.Parse("hello");     //FormatException
int.Parse("12.5");      //FormatException (decimal in int.Parse)
int.Parse("");          //FormatException (empty string)



//Test: implement a method that takes a string containing a number and returns it as an integer using int.Parse().
public class Solution
{
    public static int ParseStringToInt(string numberString)
    {
        return int.Parse(numberString);
    }
}