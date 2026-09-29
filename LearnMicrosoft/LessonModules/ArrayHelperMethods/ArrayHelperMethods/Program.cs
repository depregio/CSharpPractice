//The Array class contains methods that you can use to manipulate the content, arrangement, and size of an array.



//Array.Sort() method
string[] pallets = ["B14", "A11", "B12", "A13"];

Console.WriteLine("Sorted...");
Array.Sort(pallets);                //Sorts the items in the array alphanumerically.
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");  //-- A11 -- A13 -- B12 -- B14
}
Console.WriteLine("");


//Array.Reverse() method
Console.WriteLine("Reversed...");
Array.Reverse(pallets);             //Reverts the order of items in the array.
foreach (var pallet in pallets) 
{
    Console.WriteLine($"-- {pallet}");  //-- B14 -- B12 -- A13 -- A11
}
Console.WriteLine("");


//Array.Clear() method
string[] pallets2 = ["B14", "A11", "B12", "A13"];

Array.Clear(pallets2, 0, 2); //Replaces specific elements in your array with the array's default value. String -> null. int -> 0.
Console.WriteLine($"Clearing 2 ... count: {pallets2.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");  //-- -- -- B12 -- A13
}
Console.WriteLine("");
                            //Array.Clear() removes an array element's reference to a value, if it exists. This could throw an exception. 
if (pallets2[0] != null)    //To fix it check for null with an if.
    Console.WriteLine($"After: {pallets2[0].ToLower()}");   //ToLower() throws an exception if null


//Array.Resize() method
Array.Resize(ref pallets2, 6);  //Resizes the array. //The ref keyword passes the pallets2 array by reference, as reuquired by the method.
Console.WriteLine($"Resizing 6 ... count: {pallets2.Length}");

pallets2[4] = "C01";
pallets2[5] = "C02";

foreach (var pallet in pallets2)
{
    Console.WriteLine($"-- {pallet}");  //-- -- -- B12 -- A13 -- C01 -- C02
}
Console.WriteLine("");

//You can remove array elements using Array.Resize().
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");  //-- -- -- B12
}


//value.ToCharArray() method to reverse a string
string value = "abc123";
char[] valueArray = value.ToCharArray();    //Creates an array of char, where each element represents one character of the original string.

Array.Reverse(valueArray);
string result = new string(valueArray);     //Creates a new empty instance of the System.String class (thesame as the string data type in C#) and passes in the char array as a constructor.
                                            //Essentially, it makes the array of chars into a string
Console.WriteLine(result);     //321cba


//String.Join() method to combine all of the chars into a new comma-separated-value
string value2 = "abc123";
char[] valueArray2 = value2.ToCharArray();

Array.Reverse(valueArray);
string result2 = String.Join(",", valueArray2); //This too turns back the array of chars into a string.
Console.WriteLine(result2);     //3,2,1,c,b,a


//value.Split() to split the comma-separated-value string into an array of strings
string[] items = result2.Split(',');            //This method is designed for variables of type string and creates an array of strings.
foreach (string item in items)                  //the delimeter character (,) is lost during the split.
{
    Console.WriteLine(item);    //3 2 1 c b a (with \n after each)
}


//Test: reverse the letters of each words in a sentence, keeping the original word position
string pangram = "The quick brown fox jumps over the lazy dog";

string[] reversedWords = new string[0];

string[] words = pangram.Split(" ");

for(int i=0; i<words.Length; i++)
{
    char[] letters = words[i].ToCharArray();
    Array.Reverse(letters);
    string reversedWord = new string(letters);
    
    Array.Resize(ref reversedWords, i+1);
    reversedWords[i] = reversedWord;
}

string reversedPhrase = String.Join(" ", reversedWords);
Console.WriteLine(reversedPhrase);

//Official solution:
/*
string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result);
 
The Array.Resize in loop is wasteful and risky if managed badly.
*/



//Test: parse a string of orders, sort the orders and tag possible errors
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderIDs = orderStream.Split(",");
Array.Sort(orderIDs);

foreach (string id in orderIDs)
{
    if (id.Length != 4)
        Console.WriteLine($"{id}\t- Error");
    else
        Console.WriteLine(id);
}