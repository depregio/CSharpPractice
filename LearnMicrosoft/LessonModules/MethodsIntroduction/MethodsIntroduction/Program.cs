using static System.Runtime.InteropServices.JavaScript.JSType;

SayHello();         //A method can be called before or after its definition. It's common to define all methods at the end of a program.

void SayHello()
{
    Console.WriteLine("Hello World!");
}

int[] a = { 1, 2, 3, 4, 5 };

Console.WriteLine("Contents of Array:");
PrintArray();

void PrintArray()
{
    foreach (int x in a)
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Before calling a method");
PrintInsideMethod();                                 //Once a method is defined, it can be called anytime, as many times as you need to use it.
Console.WriteLine("After calling a method");

void PrintInsideMethod()
{
    Console.WriteLine("I'm inside the method.");
}

/*
Best practices for method names:
    It's important to keep the name concise and make it clear what task the method performs.
    Method names should be Pascal case and generally shouldn't start with digits.
    Names for parameters should describe what kind of information the parameter represents.

    For example:
        void ShowData(string a, int b, int c);              //Bad
        void DisplayDate(string month, int day, int year);  //Good
*/


//Display random numbers
Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

void DisplayRandomNumbers()
{
    Random random = new Random();

    for (int i = 0; i < 5; i++)
    {
        Console.Write($"{random.Next(1, 100)} ");   //Generates a number between 1 and 99 (inclusive).
    }

    Console.WriteLine();
}


//Create reusable methods to avoid duplicate code
int[] times = { 800, 1200, 1600, 2000 };
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");
DisplayTimes();                                                 //Method call

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    AdjustTimes();                                              //Method call
}
else
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    AdjustTimes();                                              //Method call
}

Console.WriteLine("New Medicine Schedule:");
DisplayTimes();                                                 //Method call

Console.WriteLine();

void DisplayTimes()
{
    /* Format and display medicine times */
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }

    Console.WriteLine();
}

void AdjustTimes()
{
    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    for (int i = 0; i < times.Length; i++)
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}


//Combine pseudo-code and methods
/*
Pseudo-code is when you use plain language to describe steps in code, without strictly adhering to syntax rules.


An interviewer wants you to write a program that checks whether an IPv4 address is valid or invalid. 
You're given the following rules:

    -A valid IPv4 address consists of four numbers separated by dots
    -Each number must not contain leading zeroes
    -Each number must range from 0 to 255
    -1.1.1.1 and 255.255.255.255 are examples of valid IP addresses.

The IPv4 address is provided as a string.


So, in pseudo-code:

    if ipAddress consists of 4 numbers
    and
    if each ipAddress number has no leading zeroes
    and
    if each ipAddress number is in range 0 - 255
    
    then ipAddress is valid
    
    else ipAddress is invalid
*/

string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input)
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength();
    ValidateZeroes();
    ValidateRange();

    if (validLength && validZeroes && validRange)
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    }
    else
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}

void ValidateLength()
{
    validLength = address.Length == 4;
}
void ValidateZeroes()
{
    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            validZeroes = false;
            return;                 //The return statement terminates execution of the method and returns control to the method caller.
        }
    }

    validZeroes = true;
}
void ValidateRange()
{
    foreach (string number in address)
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255)
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}


//Test: tell a fortune (create and call the TellFortune method)
/*

//Starting code:

Random random = new Random();
int luck = random.Next(100);

string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

Console.WriteLine("A fortune teller whispers the following words:");
string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
for (int i = 0; i < 4; i++)
{
    Console.Write($"{text[i]} {fortune[i]} ");
}
*/

Random random = new Random();
int luck = random.Next(100);

string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

TellFortune();

void TellFortune()
{
    Console.WriteLine("A fortune teller whispers the following words:");

    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++)
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
}

//If you want to recycle this method between programs, it's better to keep the variables declared inside the method
//or to pass them as arguments needed. This module was just a simple and brief introduction to methods.
