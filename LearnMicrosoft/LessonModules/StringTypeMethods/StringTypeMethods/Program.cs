//For more useful methods check ArrayHelperMethods, FormatData and the DoWhileStatements test



//IndexOf() and Substring() methods
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('('); //IndexOf() returns the position of the first occurrence of one or more characters inside a string.
int closingPosition = message.IndexOf(')'); //Remember, these values are zero-based. It returns -1 if it can't find a match.

Console.WriteLine(openingPosition);     //13
Console.WriteLine(closingPosition);     //36

int length = closingPosition - openingPosition; //Substring() returns the part of a larger string using a starting position and optional length.
Console.WriteLine(message.Substring(openingPosition, length));      //(inside the parentheses
                                                                    
openingPosition += 1;

Console.WriteLine(message.Substring(openingPosition, length));      //inside the parentheses)

length -= 1;        //Or do again length = closingPosition - openingPosition

Console.WriteLine(message.Substring(openingPosition, length));      //inside the parentheses


string message2 = "What is the value <span>between the tags</span>?";

int openingPosition2 = message2.IndexOf("<span>");      //IndexOf("<");  is valid too.
int closingPosition2 = message2.IndexOf("</span>");     //IndexOf("</"); is valid too.

Console.WriteLine(openingPosition2);    //18    //The value return is always the first character position.
Console.WriteLine(closingPosition2);    //40    //Multiple characters are needed for more precision, both <span> and </span> start with a <.
                                        //These are known as "magic strings". If mispelled like <sapn> the program doesn't work as intended.
openingPosition2 += 6;
int length2 = closingPosition2 - openingPosition2;
Console.WriteLine(message2.Substring(openingPosition2, length2));   //between the tags

//Avoid magic values
string message3 = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";       //A constant allows you to define and initialize a variable whose value can never be changed. 
const string closeSpan = "</span>";     //It's better if you can't avoid magic values since it's only defined once, you only need to check there.

int openingPosition3 = message3.IndexOf(openSpan);
int closingPosition3 = message3.IndexOf(closeSpan);

openingPosition3 += openSpan.Length;    //Safer than +=6 and more scalable.
int length3 = closingPosition3 - openingPosition3;
Console.WriteLine(message3.Substring(openingPosition3, length3));   //between the tags


//LastIndexOf() method
string message4 = "hello there!";

int first_h = message4.IndexOf('h');
int last_h = message4.LastIndexOf('h'); //LastIndexOf() returns the position of the last occurrence of one or more characters inside a string.

Console.WriteLine($"For the message: '{message4}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");


string message5 = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition4 = message5.LastIndexOf('(');

openingPosition4 += 1;
int closingPosition4 = message5.LastIndexOf(')');
int length4 = closingPosition4 - openingPosition4;
Console.WriteLine(message5.Substring(openingPosition4, length4));   //set of parentheses


string message6 = "(What if) I want to retrieve (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition5 = message6.IndexOf('(');
    if (openingPosition5 == -1) break;      //If there are no more parenthesis break out of the loop.

    openingPosition5 += 1;
    int closingPosition5 = message6.IndexOf(')');
    int length5 = closingPosition5 - openingPosition5;
    Console.WriteLine(message6.Substring(openingPosition5, length5));

    message6 = message6.Substring(closingPosition5 + 1);    //returns every character after the starting specified position (+1 to remove ) ). 
}                                               //This you can effectively modify the original string (you can do the same with other methods).


//IndexOfAny() method
string message7 = "Hello, world!";
char[] charsToFind = { 'a', 'e', 'i' };

int index = message7.IndexOfAny(charsToFind);   //IndexOfAny() returns the first occurring position of possible chars inside another string.
                                                //Returns -1 if all characters in the array of characters are not found.
Console.WriteLine($"Found '{message7[index]}' in '{message7}' at index: {index}."); //Found 'e' in 'Hello, world!' at index: 1.


string message8 = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message8}");
char[] openSymbols = { '[', '{', '(' };         //It finds the first occurrence of ANY character in the array, not in order.
int startPosition = 5;
int openingPosition6 = message8.IndexOfAny(openSymbols);

Console.WriteLine($"Found WITHOUT using startPosition: {message8.Substring(openingPosition6)}");

openingPosition6 = message8.IndexOfAny(openSymbols, startPosition); //If overloaded the second value (int) is used as a starting position.
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message8.Substring(openingPosition6)}");


string message9 = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

char[] openSymbols2 = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
// next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition6 = 0;

while (true)
{
    int openingPosition5 = message9.IndexOfAny(openSymbols2, closingPosition6);

    if (openingPosition5 == -1) break;

    string currentSymbol = message9.Substring(openingPosition5, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition5 += 1;
    closingPosition6 = message9.IndexOf(matchingSymbol, openingPosition5);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length5 = closingPosition6 - openingPosition5;
    Console.WriteLine(message9.Substring(openingPosition5, length5));
}


//Remove() and Replace() methods
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);    //Remove() works like Substring(), except that its copy changes by deletion instead of selection.
Console.WriteLine(updatedData);             //123455000  3  //Note, Remove() does not affect the original string. 


string message10 = "This--is--ex-amp-le--da-ta";
message10 = message10.Replace("--", " ");   //Replace() swaps all instances of a string with another string.
message10 = message10.Replace("-", "");     //Note that it always returns a modified copy of the original string.
Console.WriteLine(message10);               //This is example data



//Test: extract, replace, and remove data from an input string
/*
Desired output:
Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span> 
*/
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

const string startSpan = "<span>";
const string endSpan = "</span>";

int startQuantity = input.IndexOf(startSpan) + startSpan.Length;
int endQuantity = input.IndexOf(endSpan);
int lengthQuantity = endQuantity - startQuantity;

quantity = input.Substring(startQuantity, lengthQuantity);

const string startDiv = "<div>";
int indexStartDiv = input.IndexOf(startDiv);    //Or just write output = input.Replace(startDiv, "");
output = input.Remove(indexStartDiv, startDiv.Length);  //Using Remove() for the sake of the exercise.
                                                        //Remember that every time you overwrite your string with Remove(), Replace() and such
const string endDiv = "</div>";                         //the indexes change. Need to find the new indexes in the new string after each change.
int indexEndDiv = output.IndexOf(endDiv);       //Or just write output = output.Replace(endDiv, "");
output = output.Remove(indexEndDiv, endDiv.Length);

const string tradeCode = "&trade";
const string regCode = "&reg";

output = output.Replace(tradeCode, regCode);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");