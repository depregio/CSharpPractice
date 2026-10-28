//Static methods

//Static methods belong to the class itself, not to any specific instance.
//You call them directly on the class name without creating an object first.

//Static methods are ideal for utility operations that:
//      Don't need to access instance data.
//      Perform calculations using only the parameters passed in.
//      Provide helper functionality shared across your application.


//Calling static vs instance methods
double result = Math.Sqrt(16);  //Static method: called on the class  
int max = Math.Max(5, 10);      //No need to create a Math object

string text = "hello";          //Instance method: requires an object
string upper = text.ToUpper();  //Called on the string instance

bool empty = StringHelper.IsNullOrEmpty("");
string reversed = StringHelper.Reverse("hello");

public class StringHelper
{
    public static bool IsNullOrEmpty(string value)
    {
        return value == null || value.Length == 0;
    }

    public static string Reverse(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}



//Test: create a static utility method CalculateCircleArea in the MathUtilities class that calculates the area of a circle given its radius.
//      Formula: Area = π × radius²
//      Use Math.PI for the value of pi.
public class MathUtilities
{
    // Create a static method that calculates the area of a circle
    // Formula: π × radius²
    // Use Math.PI for the value of pi
    public static double CalculateCircleArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}