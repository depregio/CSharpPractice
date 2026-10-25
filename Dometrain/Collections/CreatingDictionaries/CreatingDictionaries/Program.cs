//Dictionaries in C#

//A Dictionary<TKey, TValue> stores key-value pairs where each key is unique and maps to exactly one value.
//Use dictionaries when you need to look up values by a specific key.


//Declaration and initialization
Dictionary<string, int> scores = new Dictionary<string, int>(); // Empty dictionary

Dictionary<string, int> ages = new Dictionary<string, int>      // Dictionary with initial values (collection initializer)
{
    { "Alice", 25 },
    { "Bob", 30 }
};

Dictionary<string, int> prices = new Dictionary<string, int>    // Alternative syntax (C# 6+)
{
    ["Apple"] = 1,
    ["Banana"] = 2
};

//The first value is the key. The second is the value itself.

//Keys must be unique. Duplicates are not allowed.

//Common key/value types
Dictionary<string, string> capitals;        // Country -> Capital
Dictionary<int, string> idToName;           // ID -> Name
Dictionary<string, double> productPrices;   // Product -> Price



//Test: create a dictionary that maps people's names to their ages with these exact entries:
/*
    "Alice"     → 25
    "Bob"       → 30
    "Charlie"   → 35
*/
Dictionary<string, int> peopleAges = new Dictionary<string, int>
{
    { "Alice", 25 },
    { "Bob", 30 },
    { "Charlie", 35 }
};