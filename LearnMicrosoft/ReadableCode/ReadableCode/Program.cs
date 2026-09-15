//Code comments should be used to say what the code cannot
//It's best to use comments for higher-level ideas and not to add comments about how an individual line of code works.

string firstName = "Bob";
int widgetsPurchased = 7;
// Testing a change to the message.
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");

/*                              //This is a block comment
string firstName = "Bob";       //Great if you need to write a long comment or remove many lines of code. 
int widgetsPurchased = 7;   
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/





/*                                                      
Random random = new Random();                   //Avoid these types of comments
string[] orderIDs = new string[5];              //They unnecessarily explain the obvious functionality of individual lines of code.
// Loop through each blank orderID              //They don't provide any context to the problem being solved by the code.
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
*/





/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
Random random = new Random();                       //Notice that the code is already less cluttered.
string[] orderIDs = new string[5];                  //This explains the higher-level purpose of your code.
                                                    //Easier to read and it introduces the idea from the start.
for (int i = 0; i < orderIDs.Length; i++)           //Remember that a comment's usefulness is subjective. 
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}


//Use whitespace to make your code easier to read

//Examples of what is whitespace
//Example 1:
Console
.
WriteLine
(
"Hello Example 1!"              //The C# compiler ignores whitespace.
)
;

//Example 2:
string firstWord = "Hello"; string lastWord = "Example 2"; Console.WriteLine(firstWord + " " + lastWord + "!");

//------------------------------------------------------------------------------------------
Random dice = new Random();                 //Declaration of dice vaiable
                                                    
int roll1 = dice.Next(1, 7);                //Declaration of roll variables
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;          //Declaration of total, that is calculated and then used alongside other variables
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))       //first if statement
{                                                                   //{} use more whitespace to make the nested ones more readable
    if ((roll1 == roll2) && (roll2 == roll3))                       //nested if statement
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else       //As you can see, whitespace divides code into readable blocks organized by function. Still, it all remains subjective.
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}
//------------------------------------------------------------------------------------------

//Test: Complete a challenge activity to improve code readability


string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");


//Becomes

/*Reverses a string and prints how many times 'o' is present*/
string message = "The quick brown fox jumps over the lazy dog.";

char[] messageInLetters = message.ToCharArray();
Array.Reverse(messageInLetters);

int counter = 0;
foreach (char letter in messageInLetters) 
{ 
    if (letter == 'o') 
    {
        counter++; 
    } 
}

string newMessage = new String(messageInLetters);       // _ is allowed in variable names, i just prefer not to use it
Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {counter} times.");