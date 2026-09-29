using System.Runtime.Intrinsics.X86;

int first = 2;
string second = "4";

//int result = first + second;        //Error: cannot implicitly convert type 'string' to 'int'
string result2 = first + second;    //However, this is possible and doesn't cause errors.

Console.WriteLine(result2);
//This is because from the compiler's perspective, the safer operation would be to convert int into a string and perform concatenation.
//It is easier to manage since the opposite could cause an exception at runtime, given that a string is a container of arbitrary characters.
//So the compiler forces you to be more involved into the data conversion, so that you can put more precautions to handle a thrown exception.

//To perform data conversion, you can use one of several techniques:
    //Use a helper method on the data type
    //Use a helper method on the variable
    //Use the Convert class' methods



int myInt = 3;
Console.WriteLine($"int: {myInt}");             //int: 3

decimal myDecimal = myInt;  //This is a widening conversion, there is no loss of information.
                            //It is also an implicit conversion, it is handled by the compiler.

Console.WriteLine($"decimal: {myDecimal}");     //decimal: 3


decimal myDecimal2 = 3.14m;
Console.WriteLine($"decimal: {myDecimal2}");    //decimal: 3.14

int myInt2 = (int)myDecimal2;   //This is a narrowing conversion, it can lose information. It is done by perfomring a cast.
                                //It is also an explicit conversion, directly telling the compiler that you know it's possible to lose precision. 

Console.WriteLine($"int: {myInt2}");            //int: 3

decimal myDecimal3 = 1.23456789m;
float myFloat = (float)myDecimal3;

Console.WriteLine($"Decimal: {myDecimal3}");    //Decimal: 1.23456789
Console.WriteLine($"Float  : {myFloat}");       //Float  : 1.2345679


//Every data type variable has a ToString() helper method.
int firstNumber = 5;
int secondNumber = 7;
string message = firstNumber.ToString() + secondNumber.ToString();      //On most primitives, it performs a widening conversion.
Console.WriteLine(message);     //57
//Not necessary since it also works as an implicit conversion, but it shows other developers that what you're doing is intentional.


//Most numeric data types have a Parse() helper method
string firstString = "5";
string secondString = "7";
int sum = int.Parse(firstString) + int.Parse(secondString);     //Converting strings to int.
Console.WriteLine(sum);         //12
//An exception is thrown at runtime if either of the variables are set to values that can't be converted to an int (like "hello").
//It is expected of you to plan ahead and prevent "illegal" conversions. The easiest way to mitigate this situation is by using TryParse().


//Use the Convert class
string value1 = "5";
string value2 = "7";
int result3 = Convert.ToInt32(value1) * Convert.ToInt32(value2);    //Here TryParse() would have still been the better choice.
Console.WriteLine(result3);     //35
//The Convert class is best for converting fractional numbers into whole numbers (int) because it rounds up the way you would expect.


//Compare casting and converting
int value = (int)1.5m;              //casting truncates if used as narrowing conversion.
Console.WriteLine(value);   //1     //You could change the value to 1.999m and the result of casting would be the same.

int value3 = Convert.ToInt32(1.5m); //converting rounds up
Console.WriteLine(value3);  //2     //If you changed the value to 1.499m, it would be rounded down to 1.



//Examining the TryParse() method
string name = "Bob";
//Console.WriteLine(int.Parse(name)); //Exception: 'Input string was not in a correct format.'


string value4 = "102";
int result = 0;
if (int.TryParse(value4, out result))   //Tries to parse. If successful returns true and stores result in out. If not returns false.
{
    Console.WriteLine($"Measurement: {result}");    //Measurement: 102
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");   //Measurement (w/ offset): 152  //result is populated by the out parameter.


string value5 = "bad";      //This value can't be parsed.
int result4 = 0;
if (int.TryParse(value5, out result4))
{
    Console.WriteLine($"Measurement: {result4}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");     //This line is printed.
}

if (result > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result4}");  //Measurement (w/ offset): 50



//Test: combine string array values as strings and as integers
string[] values = { "12,3", "45", "ABC", "11", "DEF" };     //My local decimal separator is "," not "." and without it 12.3 -> 123

decimal sum2 = 0m;
string phrase = "";

for (int i=0; i<values.Length; i++)
{
    decimal number=0;

    if (decimal.TryParse(values[i], out number))
    {
        sum2 += number;
    }
    else
    {
        phrase+= values[i];
    }
}

Console.WriteLine($"Message: {phrase}");
Console.WriteLine($"Total: {sum2}");



//Test: output math operations as specific number types
int value6 = 11;
decimal value7 = 6.2m;
float value8 = 4.3f;

int result6 = Convert.ToInt32(value6/value7);   //If value6 / Convert.ToInt32(value7) then result6 is 1 (11 / 6) (the divisor is rounded up).
Console.WriteLine($"Divide value6 by value7, display the result as an int: {result6}"); //resul6 is 2 (1,774) (the result is rounded up).

decimal result7 = value7 / (decimal)value8;     //No need to consider rounding. The conversion wouldn't change it's value, it is direct.
Console.WriteLine($"Divide value7 by value8, display the result as a decimal: {result7}");

float result8 = value8 / value6;                //int is implicitly widened to float. Widening conversion.
Console.WriteLine($"Divide value8 by value6, display the result as a float: {result8}");