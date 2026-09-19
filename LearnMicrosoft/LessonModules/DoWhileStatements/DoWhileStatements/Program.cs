//The do-while and while statements allow us to iterate by using logic inside of the code block to affect when we can stop iterating.

Random random = new Random();
int current = 0;

do                              //It is executed at least once.
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);         //Condition is checked last so 7 is printed.

while (current >= 3)            //Condition acts as a "gate". 
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

//Use the continue statement to step directly to the Boolean expression
do
{
    current = random.Next(1, 11);

    if (current >= 8) 
        continue;       //the continue key word will transfer control to the end of the code block, to the condition check.

    Console.WriteLine(current);
} while (current != 7);


//Test: Role playing game battle challenge
int heroHP = 10;
int monsterHP = 10;

Random die = new Random();
int attackDMG;

while(heroHP>0 && monsterHP>0)
{
    attackDMG = die.Next(1,11);
    monsterHP-=attackDMG;
    Console.WriteLine($"Monster was damaged and lost {attackDMG} health and now has {monsterHP} health.");
    if (monsterHP <= 0)
        continue;

    attackDMG = die.Next(1, 11);
    heroHP -= attackDMG;
    Console.WriteLine($"Hero was damaged and lost {attackDMG} health and now has {heroHP} health.");
}

Console.WriteLine(monsterHP <= 0 ? "Hero wins" : "Monster wins");


/*
Microsoft's language reference documentation describes these statements as follows:

    The for statement: executes its body while a specified Boolean expression (the 'condition') evaluates to true.
    The foreach statement: enumerates the elements of a collection and executes its body for each element of the collection.
    The do-while statement: conditionally executes its body one or more times.
    The while statement: conditionally executes its body zero or more times.
*/


//Manage user input 
string? readResult; //It's common practice to use a nullable type string (designated string?) for input variable to evaluate later.
Console.WriteLine("Enter a string:"); 
do
{
    readResult = Console.ReadLine();    //Reads user input
} while (readResult == null);           //The iteration continues while the user-supplied value is null

//Example: a prompt asks the user to enter a string that includes at least three characters
string? readResult2;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult2 = Console.ReadLine();
    if (readResult2 != null)
    {
        if (readResult2.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);

/*
If you want to use Console.ReadLine() input for numeric values, you need to convert the string value to a numeric type.

The int.TryParse() method can be used to convert a string value to an integer. 
The method uses two parameters, a string that will be evaluated and the name of an integer variable that will be assigned a value. 
The method returns a Boolean value. 

Here's an example:
*/

string? readResult3;
Console.WriteLine("Enter a string:");
do
{
    readResult3 = Console.ReadLine(); 
} while (readResult3 == null);

int numericValue = 0;
bool validNumber = false;   //If readResult3 represents a valid int, the value will be assigned to the int named numericValue
                            //and true will be assigned to the bool named validNumber. Otherwise validNumber will be assigned false.
validNumber = int.TryParse(readResult3, out numericValue);


//Test: write code that validates integer input
string? readResult4;
string resultInput="";
bool validEntry2=false;

bool validNumber2=false;
int numericValue2;

Console.WriteLine("Write an integer number between 5 and 10");

do
{

    readResult4 = Console.ReadLine();

    if (readResult4 != null)
    {
        resultInput = readResult4;
    }

    validNumber2 = int.TryParse(resultInput, out numericValue2);

    if (validNumber2 == true)
        if (numericValue2 >= 5 && numericValue2 <= 10)
            validEntry2 = true;
        else
            Console.WriteLine($"You entered {resultInput}. Please enter a number between 5 and 10.");
    else
        Console.WriteLine("Sorry, you entered an invalid number, please try again");

} while (validEntry2 == false);

Console.WriteLine($"Your input value ({resultInput}) has been accepted.");


//Test: write code that validates string input
string? userInput;
string roleInput = "";
bool validInput=false;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
    userInput = Console.ReadLine();

    if(userInput!=null)
        roleInput=userInput.Trim();

    switch (roleInput.ToLower())    
    {
        case "administrator":
            validInput= true; 
            break;

        case "manager":
            validInput = true;
            break;

        case "user":
            validInput = true;
            break;

        default:
            Console.WriteLine($"The role name that you entered, \"{roleInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");
            break;
    }

}while(validInput == false);

Console.WriteLine($"Your input value({roleInput}) has been accepted.");


//Test: Write code that processes the contents of a string array
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation;

string currentString;

foreach(string myString in myStrings)
{
    currentString = myString;    

    periodLocation = myString.IndexOf(".");

    while (periodLocation != -1)
    {
        Console.WriteLine(currentString.Remove(periodLocation));    //Prints all string minus characters after the period. 

        currentString = currentString.Substring(periodLocation+1);  //Returns a substring from a certain point. +1 removes the period.

        currentString = currentString.TrimStart();                  //Removes empty spaces before sentence.

        periodLocation = currentString.IndexOf(".");                //Looks for next period location.
    }

    Console.WriteLine(currentString);   //To print sentences without a period.

}