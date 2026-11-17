//Returning tuples from methods

//Tuples are perfect for methods that need to return multiple related values without creating a custom class.


//Why return tuples?
static void GetStats(int[] arr, out int min, out int max)       //Old approach with out parameters
{                               //Traditionally, returning multiple values required creating a class or using out parameters.
    min = arr.Min();
    max = arr.Max();    
}

static (int Min, int Max) GetStats(int[] arr)                   //Tuple approach. Cleaner.
{
    return (arr.Min(), arr.Max());
}


//Declaring return types
static (int, int) Divide(int a, int b)                      //Unnamed tuple return
{
    return (a / b, a % b);
}

static (int Quotient, int Remainder) Divide(int a, int b)   //Named tuple return. Easier to understand which number is what.
{
    return (a / b, a % b);
}


//Using the returned values
var result = Divide(10, 3);
Console.WriteLine(result.Quotient);  //3
Console.WriteLine(result.Remainder); //1

var (q, r) = Divide(10, 3);         //Or use deconstruction



//Test: write a method that finds both the minimum and maximum values in an integer array and returns them as a named tuple.
//      The method should:
//          Accept an array of integers
//          Return a tuple with Min and Max named elements
//          Find the smallest and largest values in the array
public class Solution
{
    public static (int Min, int Max) FindMinMax(int[] numbers)
    {
        return (numbers.Min(), numbers.Max());
    }
}