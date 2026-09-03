//If statement
string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))        //A Boolean expression, any code that returns a Boolean value.
{                                   //Spaces inside {} are called code blocks. 
    Console.WriteLine("What does the fox say?");
}

//If-else, if-elseif-else statements and nested code blocks
Random die = new Random();

int roll1 = die.Next(1, 7);
int roll2 = die.Next(1, 7);
int roll3 = die.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))       //This too is a boolean expression.
{                                                                   //  || (OR), && (AND) make compound conditions.
    if ((roll1 == roll2) && (roll2 == roll3))                       
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

Console.WriteLine($"Your total: {total}");

if (total >= 16)    
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)       //When you only want one outcome to happen, but you have several possible conditions and results.
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else                        //If none of the other statements apply, the final else code block will be executed.
{                           //The else is optional, but it must come last if you choose to include it.
    Console.WriteLine("You win a kitten!");
}

//Test:Improve renewal rate of subscriptions
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code starts from here

if (daysUntilExpiration==0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if(discountPercentage!=0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}