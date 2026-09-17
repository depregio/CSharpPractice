//The for statement iterates through a code block a specific number of times.
//This level of control makes the for statement unique among the other iteration statements.
//The for statement also allows more control over the process of iteration by exposing the conditions for iteration.


                                //Prints from 0 to 9
for (int i = 0; i < 10; i++)        //int i = 0 is the initializer. It is run once at the start.
{                                   //i < 10 is the condition. The code block (body) will iterate as long as this is true.
    Console.WriteLine(i);           //i++ is the iterator. This action will be taken after every iteration.
}                                   //i is a valid common variable name that holds the current iteration, along with j if nested.

for (int i = 10; i >= 0; i--)   //Prints from 10 to 0
{
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i += 3) //Prints 0 3 6 9
{
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i++)    //Prints from 0 to 7
{
    Console.WriteLine(i);
    if (i == 7) break;              //Use break keyword if you need to exit the iteration statement prematurely based on some condition.
}


//Loop through each element of an array
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

string[] names2 = { "Alex", "Eddie", "David", "Michael" };
for (int i = names2.Length - 1; i >= 0; i--)                //This is also valid
{
    Console.WriteLine(names2[i]);
}


//Limitations of the foreach statement
string[] names3 = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names3)
{
    //if (name == "David") name = "Sammy";        //Error. Can't assign a foreach iteration variable.
}


string[] names4 = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names4.Length; i++)
{
    if (names4[i] == "David")
    {
        names4[i] = "Sammy";        //This overcomes the limitation.
    }
}

foreach (var name in names4)
{
    Console.WriteLine(name);        //At this point, you could write this at the end of the for body too.
}


//Test: FizzBuzz challenge
/*
Rules:
    Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
    When the current value is divisible by 3, print the term Fizz next to the number.
    When the current value is divisible by 5, print the term Buzz next to the number.
    When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.
*/
for(int i=1 ; i<101 ; i++) 
{
    Console.Write(i);                   //This is always going to be printed.

    if (i % 3 == 0 || i % 5 == 0)
    {
        Console.Write(" - ");           //If either cases apply this is always printed, following the expected output from the module.

        if (i % 3 == 0)
            Console.Write("Fizz");      //Fizz is always printed before Buzz.
        if (i % 5 == 0)
            Console.Write("Buzz");      //Buzz can be printed without Fizz.
    }

    Console.Write("\n");                //Next iteration, next line.
}

/*
This is the solution proposed by the lesson module:

for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
} 
*/