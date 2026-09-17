//Variable scope refers to a variable's visibility to the other code in your application.

bool flag = true;

if (flag)
{                       //These {} are the boundaries of a code block
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}
//Console.WriteLine($"Outside the code block: {value}");      //Error: the name 'value' does not exist in the current context

//---------------------------------------------------------------------------------------------------------

int value2;
if (flag)
{
    //Console.WriteLine($"Inside the code block: {value2}");    //Error: use of unassigned local variable 'value2'
}
value2 = 10;
Console.WriteLine($"Outside the code block: {value2}");

//---------------------------------------------------------------------------------------------------------

int value3 = 0;
if (flag)
{
    Console.WriteLine($"Inside the code block: {value3}");      //0
}
value3 = 10;
Console.WriteLine($"Outside the code block: {value3}");         //10

//---------------------------------------------------------------------------------------------------------

int value4;
if (flag)
{
    value4 = 10;
    Console.WriteLine($"Inside the code block: {value4}");
}
//Console.WriteLine($"Outside the code block: {value4}");       //Error: use of unassigned local variable 'value4'.

//The compiler looks at the variable flag as a possible false, so it preevently signals an error as a possible outcome.

int value5;
if (true)       //The same doesn't happen here. There is no possible outcome where this statement is false and the variable used isn't assigned.
{
    value5 = 10;
    Console.WriteLine($"Inside the code block: {value5}");
}
Console.WriteLine($"Outside the code block: {value5}");

//---------------------------------------------------------------------------------------------------------

//Remove code blocks from if statements
bool flag2 = true;
if (flag2) 
    Console.WriteLine(flag2);   //This is still a code block, even without {}


string name = "steve";          
if (name == "bob") Console.WriteLine("Found Bob");              //You can also do all in one line.
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");


string name2 = "steve";
                                                               //But this is still much easier to read.
if (name2 == "bob")
    Console.WriteLine("Found Bob");
else if (name2 == "steve")
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");


//Test: update problematic code in the code editor

/*  
int[] numbers = { 4, 8, 15, 16, 23, 42 };         

foreach (int number in numbers)
{
    int total;

    total += number;

    if (number == 42)
    {
        bool found = true;

    }

}

if (found)
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");
*/

//Becomes
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total=0;
bool found=false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
