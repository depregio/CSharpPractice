//The convert class

//The Convert class provides methods to convert between different data types safely.
//Unlike casting, Convert methods handle null values and perform proper rounding.

//Convert vs casting
//      OPERATION       CASTING	        CONVERT
//      (int)3.7	    Truncates to 3	Convert.ToInt32(3.7) rounds to 4
//      (int)null	    Error	        Convert.ToInt32(null) returns 0
//      String to int	Not possible	Convert.ToInt32("42") works


//Common convert methods
int num = Convert.ToInt32("42");            //Returns 42                //String to number
double d = Convert.ToDouble("3.14");        //Returns 3.14

string s = Convert.ToString(123);           //Returns "123"             //Number to string

int rounded = Convert.ToInt32(3.7);         //Returns 4 (rounds up)     //Double to int (rounds to nearest)
int rounded2 = Convert.ToInt32(3.4);        //Returns 3 (rounds down)

string boolStr = Convert.ToString(true);    //Returns "True"            //Boolean conversions
int boolInt = Convert.ToInt32(true);        //Returns 1



//Test: implement a method that:
//          Converts a string to an integer using Convert.ToInt32.
//          Converts a double to an integer using Convert.ToInt32.
//          Converts a boolean to a string using Convert.ToString.
//          Returns the sum of the two integers and the boolean string in format: "sum:boolString".
public class Solution
{
    public static string ConvertValues(string numberString, double decimalValue, bool boolValue)
    {
        int numberFromString = Convert.ToInt32(numberString);
        int integerFromDouble = Convert.ToInt32(decimalValue);
        string stringFromBool = Convert.ToString(boolValue);

        return $"{numberFromString + integerFromDouble}:{stringFromBool}";
    }
}