//Checking dictionary keys


//ContainsKey() checks if a key exists and returns a boolean.
var ages = new Dictionary<string, int> { { "Alice", 25 }, { "Bob", 30 } };

bool hasAlice = ages.ContainsKey("Alice");  // true
bool hasCarol = ages.ContainsKey("Carol");  // false

//Common pattern: check then access
if (ages.ContainsKey("Alice"))
{
    int age = ages["Alice"];
}
else
{
    //throw exception;
}


//TryGetValue() checks for the key and retrieves the value in one operation.
var ages2 = new Dictionary<string, int> { { "Alice", 25 }, { "Bob", 30 } };

if (ages2.TryGetValue("Alice", out int age2))       //true
{
    Console.WriteLine($"Alice is {age2}");  // Alice is 25
}

if (ages2.TryGetValue("Carol", out int carolAge))   //false //If not found, 'age' will be set to default (0 for int)
{
    // This won't execute
}


//Test: create a method that safely checks if an item exists in an inventory dictionary.
//      If found, return "{item}: {quantity} in stock". If not found, return "{item}: not found".
static string SearchItem(Dictionary<string, int> inventory, string item)
{
    return inventory.TryGetValue(item, out int quantity) ? $"{item}: {quantity} in stock" : $"{item}: not found";
}