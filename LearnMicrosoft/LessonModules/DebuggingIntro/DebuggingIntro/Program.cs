/*
Usual pannels of a debugger:

    - VARIABLES section. Used to view and manage variable state during a debug session. This is automatic.
        It's also possible to change the value of a variable at runtime using the VARIABLES section.
    - WATCH section. Used to monitor variables or expressions. This is something you configure yourself.
    - CALL STACK section. Used to keep track of the current point of execution within the running application.
        The call stack shows which method is currently being executed, as well as the methods in the execution path that led to the current line of code.
    - BREAKPOINTS section. Displays the current breakpoint settings. When you run your code in the debugger, execution pauses at the breakpoint you've set.
        You can also set conditional breakpoints, which are triggered only after an expression is evaluated.
        A "hit count" is a conditional breakpoint that can be used to specify how many times a breakpoint must be encountered before halting execution.
        A "logpoint" or "tracepoint" can be used to log information to the terminal without pausing execution or inserting code. It can include a condition or hit count.
    - DEBUG TOOLBAR. Provides execution controls while your application is running such as pause/continue, step over, step into, step out, restart and stop.
    - DEBUG CONSOLE. Used to display messages from the debugger. It can also display console output from your application.
*/



//Configure a breakpoint
string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

string messageText = "";

foreach (string name in names)
{
    if (name == "Sophia")               //Set a breakpoint here
        messageText = SophiaMessage();  //Here, select step into, then end method call, then select step into, it goes to line 32
    else if (name == "Andrew")
        messageText = AndrewMessage();
    else if (name == "AllGreetings")
        messageText = SophiaMessage(); //+ "\n\r" + AndrewMessage();    //<- Solution
    messageText = messageText + "\n\r" + AndrewMessage();   //It goes here because it isn't part of the else if, {} would have made code easier to read.

    Console.WriteLine(messageText + "\n\r");
}

static string SophiaMessage()
{
    return "Hello, my name is Sophia.";
}

static string AndrewMessage()
{
    return "Hi, my name is Andrew. Good to meet you.";
}


//Configure conditional breakpoints
int productCount = 2000;
string[,] products = new string[productCount, 2];

LoadProducts(products, productCount);

for (int i = 0; i < productCount; i++)
{
    string result;
    result = Process1(products, i);     //Set a breakpoint here with the condition: products[i,1] == "new"
                                        //In this simulated data processing scenario, there is about a 1% chance that a product is new
    if (result != "obsolete")           //Conditional breakpoints can save you lots of time this way
    {
        result = Process2(products, i);
    }
}

static void LoadProducts(string[,] products, int productCount)
{
    Random rand = new Random();

    for (int i = 0; i < productCount; i++)
    {
        int num1 = rand.Next(1, 10000) + 10000;
        int num2 = rand.Next(1, 101);

        string prodID = num1.ToString();

        if (num2 < 91)
        {
            products[i, 1] = "existing";
        }
        else if (num2 == 91)
        {
            products[i, 1] = "new";
            prodID = prodID + "-n";
        }
        else
        {
            products[i, 1] = "obsolete";
            prodID = prodID + "-0";
        }

        products[i, 0] = prodID;
    }
}

static string Process1(string[,] products, int item)
{
    Console.WriteLine($"Process1 message - working on {products[item, 1]} product");

    return products[item, 1];
}

static string Process2(string[,] products, int item)
{
    Console.WriteLine($"Process2 message - working on product ID #: {products[item, 0]}");
    if (products[item, 1] == "new")
        Process3(products, item);

    return "continue";
}

static void Process3(string[,] products, int item)
{
    Console.WriteLine($"Process3 message - processing product information for 'new' product");
}


//Monitor variables and execution flow
string? readResult;
int startIndex = 0;
bool goodEntry = false;

int[] numbers = { 1, 2, 3, 4, 5 };

// Display the array to the console.
Console.Clear();
Console.Write("\n\rThe 'numbers' array contains: { ");
foreach (int number in numbers)
{
    Console.Write($"{number} ");
}

// To calculate a sum of array elements, 
//  prompt the user for the starting element number.
Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
while (goodEntry == false)
{
    readResult = Console.ReadLine();
    goodEntry = int.TryParse(readResult, out startIndex);

    if (startIndex > 5)
    {
        goodEntry = false;
        Console.WriteLine("\n\rEnter an integer value between 1 and 5");
    }
}

// Display the sum and then pause.                              //If you put 3 it says the sum of 3+4+5 is 9, which is wrong.
Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex)}");    //Set a breakpoint here
                                                                                    //{SumValues(numbers, startIndex - 1)}
Console.WriteLine("press Enter to exit");
readResult = Console.ReadLine();

// This method returns the sum of elements n through 5
static int SumValues(int[] numbers, int n)
{
    int sum = 0;
    for (int i = n; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum;
}


//Monitor watch expressions
bool exit = false;
var rand = new Random();
int num1 = 5;
int num2 = 5;

do
{
    num1 = rand.Next(1, 11);
    num2 = num1 + rand.Next(1, 51);

} while (exit == false);    //Set a breakpoint here with the watch expression: num2 / num1 > 5. Watch it turn true.
                            //Insert manually the value of exit as true while debugging.




//Test: use breakpoints and the VARIABLES section of the RUN AND DEBUG view to help you figure out the issues
/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
int x = 5;

ChangeValue(x);         //You can track the value of x from here. It never changes because x is passed by value, not reference.
                        //To solve this make ChangeValue return value and modify its call as x=ChangeValue(x);
Console.WriteLine(x);   //The debugger tool isn't even needed here if you are aware of how things work.

void ChangeValue(int value)
{
    value = 10;
}