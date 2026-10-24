//Checking List Contents


//Contains() returns a boolean indicating whether the item is in the list.
List<string> fruits = new List<string> { "apple", "banana", "orange" };

bool hasApple = fruits.Contains("apple");    // True
bool hasGrape = fruits.Contains("grape");    // False

if (fruits.Contains("banana"))
{
    Console.WriteLine("We have bananas!");
}


//IndexOf() returns the zero-based index of the first occurrence of an item, or -1 if not found.
List<string> colors = new List<string> { "red", "green", "blue", "green" };

int redIndex = colors.IndexOf("red");       // 0
int greenIndex = colors.IndexOf("green");   // 1 (first occurrence)
int yellowIndex = colors.IndexOf("yellow"); // -1 (not found)



//Test: write a method that searches for an item in a list.
//      If it exists, return "Found at index X" where X is the item's position, if not return "Not found".
static string FindItem(List<string> items, string searchItem)
{
    if (items.Contains(searchItem))
    {
        return "Found at index " + items.IndexOf(searchItem);
    }
    else
    {
        return "Not found";
    }
}

//or

static string FindItem2(List<string> items, string searchItem) => items.IndexOf(searchItem) switch
{
    -1 => "Not found",
    int itemIndex => "Found at index " + itemIndex  //int itemIndex captures the value being switched on, instead of _
};

//or

static string FindItem3(List<string> items, string searchItem)
{
    int itemIndex = items.IndexOf(searchItem);
    return itemIndex is -1 ? "Not found" : "Found at index " + itemIndex;
}