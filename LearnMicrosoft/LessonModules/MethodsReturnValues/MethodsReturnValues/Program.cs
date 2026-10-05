//Methods can return a value by including the return type in the method signature.
//Methods can return any data type, or they can return nothing at all (void).
//The return type must always be specified before the method name.

double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

total -= TotalMeetsMinimum() ? 5.00 : 0.00;

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    return items[itemIndex] * (1 - discounts[itemIndex]);   //The return keyword can be used with variables, literals, and expressions
}

bool TotalMeetsMinimum()
{
    return total >= minimumSpend;   //Returns the result of the comparison that evaluates to a bool.
}

string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5);    //You can call other methods in a return statement expression.
}


//Combine return and data conversion
double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd)
{
    int rate = 23500;
    return (int)(rate * usd);   //Cannot implicitly convert type 'double' to 'int'. A casting is necessary.
}

double VndToUsd(int vnd)
{
    double rate = 23500;
    return vnd / rate;
}


//Return strings from methods
string input = "snake";

Console.WriteLine(input);               //snake
Console.WriteLine(ReverseWord(input));  //ekans

string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }
    return result;
}

string input2 = "there are snakes at the zoo";

Console.WriteLine(input2);                  //there are snakes at the zoo
Console.WriteLine(ReverseSentence(input2)); //ereht era sekans ta eht ooz 

string ReverseSentence(string input)
{
    string result = "";
    string[] words = input.Split(" ");

    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
    }

    return result.Trim();
}


//Return booleans from methods
string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

Console.WriteLine("Is it a palindrome?");
foreach (string word in words)
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end)
    {
        if (word[start] != word[end])
        {
            return false;       //Returning a value terminates the execution of the method.
        }
        start++;
        end--;
    }

    return true;                //You can branch your method to return different values in different situations.
}


//Return arrays from methods
int target = 60;
int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[] result = TwoCoins(coins, target);

if (result.Length == 0)
{
    Console.WriteLine("No two coins make change");
}
else
{
    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");    //Change found at positions 2 and 5
}

int[] TwoCoins(int[] coins, int target)
{
    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                return new int[] { curr, next };    //Returns an array representing the correct indexes.
            }
        }
    }

    return new int[0];
}

//You can also return a 2D array
int target2 = 30;                                       //int target = 80; for output: No two coins make change
int[] coins2 = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[,] result2 = TwoCoins2(coins2, target2);

if (result2.Length == 0)
{
    Console.WriteLine("No two coins make change");
}
else
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < result2.GetLength(0); i++)
    {
        if (result2[i, 0] == -1)
        {
            break;
        }
        Console.WriteLine($"{result2[i, 0]},{result2[i, 1]}");
    }
}

int[,] TwoCoins2(int[] coins, int target)
{
    int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0))
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0, 0] : result;
}



//Test: add methods to make the game playable
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = SetRandomTarget();
        var roll = SetRandomRoll();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target,roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string? userInput="";

    do
    {
        userInput = Console.ReadLine();

        if(userInput!=null)
        {
            userInput = userInput.ToLower();
        }
    } while (userInput!="y" && userInput!="n");

    if (userInput == "y")   //A shorter way to write this is: return userInput == "y";
        return true;
    else 
        return false;
}   
//Official solution: string response = Console.ReadLine(); return response.ToLower().Equals("y");
//Equals() returns a bool by comparison to the argument. It's like writing: response == "y"

string WinOrLose(int target, int roll)
{
    if (roll > target)
        return "You win!";
    else
        return "You lose!";
}

int SetRandomTarget ()
{
    return random.Next(1,6);
}

int SetRandomRoll ()
{
    return random.Next(1,7);
}