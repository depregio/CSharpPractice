//An expression is any combination of values (literal or variable), operators, and methods that return a single value.

//Equality operator
Console.WriteLine("a" == "a");          //True
Console.WriteLine("a" == "A");          //False
Console.WriteLine(1 == 2);              //False

string myValue = "a";
Console.WriteLine(myValue == "a");      //True

Console.WriteLine("a" == "a ");         //False

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim() == value2.Trim().ToLower());        //True
Console.WriteLine(value1.Trim().ToUpper() == value2.Trim());        //True
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());      //True
Console.WriteLine(value1.Trim().ToUpper() == value2.Trim().ToUpper());      //True


//Inequality operator
Console.WriteLine("a" != "a");          //False
Console.WriteLine("a" != "A");          //True
Console.WriteLine(1 != 2);              //True

string myValue3 = "a";
Console.WriteLine(myValue3 != "a");     //False


//Comparison operators
Console.WriteLine(1 > 2);       //False
Console.WriteLine(1 < 2);       //True
Console.WriteLine(1 >= 1);      //True
Console.WriteLine(1 <= 1);      //True


//Methods that return a Boolean value
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));     //True
Console.WriteLine(pangram.Contains("cow"));     //False

//Logical Negation
Console.WriteLine(pangram.Contains("fox") == false);        //False
Console.WriteLine(!pangram.Contains("fox"));                //False

Console.WriteLine(!pangram.Contains("fox"));                //False
Console.WriteLine(!pangram.Contains("cow"));                //True

                            //The inequality operator != includes !, but should not be confused with logical negation. 
int a = 7;                  //The inequality operator returns true if its operands aren't equal, and returns false if the operands are equal.                   
int b = 6;                  //The expression x != y produces the same result as the expression !(x == y)
Console.WriteLine(a != b);      //True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2);    //False


//Conditional operator
int saleAmount = 1001;  
int discount = saleAmount > 1000 ? 100 : 50;    //<condition> ? <if true, return this> : <if false, return this>
Console.WriteLine($"Discount: {discount}");     //100


//Test:Write code to display the result of a coin flip
Random coin = new Random();
int coinflip = coin.Next(0, 2);
string result = coinflip == 0 ? "heads" : "tails";   //0=heads    1=tails
Console.WriteLine(result);


//Test:Decision logic challenge
string permission = "Admin|Manager";    //permission.Contains("Admin") will return true 
int level = 55;

if (permission.Contains("Admin"))
{
    Console.WriteLine(level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.");
}
else if (permission.Contains("Admin"))      //Or use (permission.Contains("Admin") && level >= 20) and move second option with the else statement
{
    Console.WriteLine(level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}