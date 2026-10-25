//Accessing and adding dictionary items


//Accessing values by key
Dictionary<string, int> ages = new Dictionary<string, int>
{
    ["Alice"] = 25,
    ["Bob"] = 30
};

int aliceAge = ages["Alice"];  // Returns 25
int bobAge = ages["Bob"];      // Returns 30

// Warning: throws KeyNotFoundException if key doesn't exist


//Adding Items with Add()
Dictionary<string, int> ages2 = new Dictionary<string, int>();

ages2.Add("Alice", 25);
ages2.Add("Bob", 30);
ages2.Add("Charlie", 35);


//Add() vs Indexer for Adding
ages2.Add("Alice", 26); //Add() throws an exception if key already exists

ages2["John"] = 32;     // Indexer adds OR updates
ages2["Alice"] = 26;    // Updates value related to existing key
ages2["David"] = 40;    // Adds new key



//Test: Create a dictionary that maps fruit names to their colors, add the specified items using Add(), then return the color for the requested fruit.
/*
    Add these fruit-color pairs:

        "apple" → "red"
        "banana" → "yellow"
        "grape" → "purple"
*/
static string BuildAndRetrieveColor(string requestedFruitColor)
{
    Dictionary<string, string> fruitColorMap = new Dictionary<string, string>();

    fruitColorMap.Add("apple", "red");
    fruitColorMap.Add("banana", "yellow");
    fruitColorMap.Add("grape", "purple");

    return fruitColorMap[requestedFruitColor];  //Check if key exists or throw exception.
}