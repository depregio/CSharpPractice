//The params keyword

//The params keyword allows a method to accept a variable number of arguments of the same type.
//Instead of creating an array manually, callers can pass any number of arguments directly.


//Basic syntax
static void PrintNumbers(int[] numbers)     //Caller must create an array or pass an existing one.
{
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}
PrintNumbers(new int[] { 1, 2, 3 });

//Syntax using params
static void PrintNumbers2(params int[] numbers) //Caller can pass values directly, which are then copied into the local array.
{
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}
PrintNumbers2(1, 2, 3);
PrintNumbers2(1, 2, 3, 4, 5);   //Any number of arguments works.
PrintNumbers2();                //Zero arguments also works.

//A params parameter must be the last one in the method signature.

//Only one params parameter is allowed per method.


//Example with more parameters
static string FormatMessage(string prefix, params string[] words)
{
    return prefix + ": " + string.Join(", ", words);
}
Console.WriteLine(FormatMessage("Items", "apple", "banana", "cherry"));    //Items: apple, banana, cherry



//Test: calculate the sum of all numbers passed to it using the params keyword.
static int SumAll(params int[] numbers)
{
    int sum = 0;

    foreach (int number in numbers)
    {
        sum += number;
    }

    return sum;
}