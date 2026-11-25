//Params collections

//C# 13 extends the params keyword to work with any collection type, not just arrays.
//This allows you to use List<T>, Span<T>, ReadOnlySpan<T>, and other collection types as params parameters.

//Benefits of params collections:
//      - More flexibility in parameter types.
//      - Better performance with Span<T> for stack allocation.
//      - Caller can pass individual items OR a collection.

//Supported collection types:
//      TYPE            DESCRIPTION
//      List<T>         Mutable list
//      Span<T>	        Stack-allocated memory span
//      ReadOnlySpan<T>	Read-only memory span
//      IEnumerable<T>	Any enumerable


//Traditional params (arrays only)
public static int Sum(params int[] numbers)     //Before C# 13: only arrays supported
{
    return numbers.Sum();
}
Sum(1, 2, 3, 4, 5);     //Calling it


//Params with List<T> (C# 13+)
public static int Sum(params List<int> numbers) //C# 13: params works with List<T>
{
    return numbers.Sum();
}
Sum(1, 2, 3, 4, 5);     //Calling it, same syntax.

List<int> myList = new List<int> { 10, 20, 30 };    //Can also pass an existing list
Sum(myList);            //This also works.



//Test: create a method SumAll that accepts a params List<int> parameter and returns the sum of all numbers in the list.
public class Solution
{
    public static int SumAll(params List<int> numbers)
    {
        return numbers.Sum();
    }
}