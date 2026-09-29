//Value vs. reference types

//Reference types store references to their data (objects), that is the address that points to data values stored somewhere else. 
//In comparison, variables of value types directly contain their data.



//Integral types

//An integral type represents whole numbers with no fraction (such as -1, 0, 1, 2, 3).
//The most popular in this category is the int data type.

//There are signed and unsigned integral types.

//A signed type uses its bytes to represent an equal number of positive and negative numbers.
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");    //sbyte  : -128 to 127
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");    //short  : -32768 to 32767
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");        //int    : -2147483648 to 2147483647
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");      //long   : -9223372036854775808 to 9223372036854775807

//An unsigned type uses its bytes to represent only positive numbers.
Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");      //byte   : 0 to 255            
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");  //ushort : 0 to 65535
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");      //uint   : 0 to 4294967295
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");    //ulong  : 0 to 18446744073709551615
//It's obvious that the byte type is intended to hold a value that represents a byte of data (clusters of 8 bits -> 2^8=256).
//Data stored in files or data transferred across the internet is often in a binary format.
//When working with data from these external sources, you need to receive data as an array of bytes, then convert them into strings.
//Many of the methods in the .NET Class Library that deal with encoding and decoding data requires you handle byte arrays.



//Floating-point types

//A floating point is a simple value type that represents numbers to the right of the decimal place.

//First, you must consider the digits of precision each type allows. Precision is the number of value places stored after the decimal point.
//Second, you must consider the manner in which the values are stored and the impact on the accuracy of the value.

//For example, float and double values are stored internally in a binary (base 2) format, while decimal is stored in a decimal (base 10) format.
//Math on binary floating-point values can produce inaccurate results compared to decimal math. It is often an approximation of the real value.
//Therefore, float and double are useful since large numbers can be stored using a small memory footprint.
//However, they should only be used when an approximation is useful. If you need a more precise, always accurate answer, you should use decimal.

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");        //float  : -3.402823E+38 to 3.402823E+38                                    (with ~6-9 digits of precision)
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");    //double : -1.79769313486232E+308 to 1.79769313486232E+308                  (with ~15-17 digits of precision)
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");   //decimal: -79228162514264337593543950335 to 79228162514264337593543950335  (with 28-29 digits of precision)
//Floating-point values can sometimes be represented using "E notation" when the numbers grow especially large.
//"E notation" is a form of scientific notation that means "times 10 raised to the power of."
//So, a value like 5E+2 would be the value 500 because it's the equivalent of 5 * 10^2, or 5 x 100.



//Reference types

//Reference types include arrays, classes, and strings.

//A value type variable stores its values directly in an area of storage called the stack, a memory allocated to the code that runs on the CPU.
//When the stack frame has finished executing, the values in the stack are removed.

//A reference type variable stores its values in a separate memory region called the heap.
//The heap is a memory area that is shared across many applications running on the operating system at the same time.

int[] data;         //data is not pointing to a memory address a this point, so it's called a null reference.
data = new int[3];  //The new keyword informs .NET Runtime to create an instance of int array, in coordination with the operating system.
                    //The .NET Runtime complies, and returns a memory address of the new int array.
                    //The memory address is then stored in the variable data. The int array's elements default to the value 0, as default.

string shortenedString = "Hello World!";    //The string data type is also a reference type. new isn't used as a convenient design choice.
Console.WriteLine(shortenedString);



//Practical concerns using value and reference types

//Value Type example
int val_A = 2;
int val_B = val_A;      //The value of val_A is copied and stored in val_B.
val_B = 5;              //When val_B is changed, val_A remains unaffected.

Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}");       //Output: val_A: 2
Console.WriteLine($"val_B: {val_B}");       //Output: val_B: 5

//Reference type example
int[] ref_A = new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;        //ref_B points to the same memory location as ref_A.
ref_B[0] = 5;               //when ref_B[0] is changed, ref_A[0] also changes because they both point to the same memory location.

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}"); //Output: ref_A[0]: 5
Console.WriteLine($"ref_B[0]: {ref_B[0]}"); //Output: ref_B[0]: 5


//You may be tempted to choose the data type that uses the fewest bits to store data thinking it improves your application's performance.
//Don't. Resist the temptaion to "prematurely optimize" your code. A good enough job will do.
//First choose the right fit for your data, then look into where performance is negatively impacted.

//When choosing a data type, consider also the library function you can use. For example System.TimeSpan methods mostly accepts int and double.

//Sometimes, you must consider how the information will be consumed by other applications or other systems like a database. 

//When in doubt, stick with the basics.