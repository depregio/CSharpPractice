//TryParse methods

//TryParse methods attempt to convert a string to a specific type and return a boolean indicating success or failure,
//without throwing exceptions.

//TryParse uses an out parameter to return the converted value.

//Common TryParse methods:
//      TYPE        METHOD	            EXAMPLE
//      int	        int.TryParse()	    int.TryParse("5", out int i)
//      double	    double.TryParse()	double.TryParse("3.14", out double d)
//      bool	    bool.TryParse()	    bool.TryParse("true", out bool b)
//      DateTime	DateTime.TryParse()	DateTime.TryParse("2024-01-01", out DateTime dt)


//Why use TryParse?
int value = int.Parse("abc");   //FormatException   //Parse throws an exception if conversion fails

bool success = int.TryParse("abc", out int value2);  //success = false, value = 0    //TryParse returns false instead of throwing


//The out parameter
if (int.TryParse("42", out int number))     //Declare the variable inline with out
{
    Console.WriteLine(number);  //42
}

int result;                                 //Or declare it beforehand
bool parsed = int.TryParse("100", out result);


//Parse vs TryParse
int age = int.Parse(validatedInput);        //Use Parse when you're certain the string is valid

if (int.TryParse(userInput, out int age2))   //Use TryParse when the string might be invalid
{
    //Use the parsed value
}
else
{
    //Handle invalid input gracefully
}



//Test: create a method that safely parses a string to an integer.
//      If parsing succeeds, return the parsed value.
//      If parsing fails (invalid format, null, or empty string), return the provided default value.
public class Solution
{
    public static int SafeParseToInt(string input, int defaultValue)
    {
        return int.TryParse(input, out int parsedValue) ? parsedValue : defaultValue;
    }
}