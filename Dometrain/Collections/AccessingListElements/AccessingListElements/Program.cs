//Accessing list elements


//Index access
List<string> fruits = new List<string> { "apple", "banana", "cherry" };

string first = fruits[0];   //"apple" - first item
string second = fruits[1];  //"banana" - second item
string third = fruits[2];   //"cherry" - third item


//The Count property tells you how many items are in the list.
List<string> fruits2 = new List<string> { "apple", "banana", "cherry", "orange", "melon" };

int total = fruits2.Count;        //5
string last = fruits2[total - 1]; //"melon" - last item



//Test: Write a method that prints the first and last items from a list of strings on different lines.
static void PrintFirstAndLast(List<string> items)
{
    Console.WriteLine(items[0]);
    Console.WriteLine(items[items.Count - 1]);
}