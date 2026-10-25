//Looping through dictionaries


//Using KeyValuePair<TKey, TValue>
Dictionary<string, int> ages = new Dictionary<string, int>
{
    { "Alice", 25 },
    { "Bob", 30 }
};

foreach (KeyValuePair<string, int> pair in ages)    //Dictionary<TKey, TValue> is the collection. KeyValuePair<TKey, TValue> is a single entry inside it.
{
    Console.WriteLine(pair.Key);   // "Alice", then "Bob"
    Console.WriteLine(pair.Value); // 25, then 30
}


//Using var to avoid typing the full generic type
foreach (var pair in ages)
{
    Console.WriteLine($"{pair.Key} is {pair.Value} years old");
}


//Alternative: Deconstruction (C# 7+)
foreach (var (name, age) in ages)
{
    Console.WriteLine($"{name}: {age}");
}



//Test: Write a method that takes a Dictionary<string, int> and prints each key-value pair on its own line in the format Key: Value.
static void PrintDictionary(Dictionary<string, int> dictionary)
{
    foreach(var entry in dictionary)
    {
        Console.WriteLine($"{entry.Key}: {entry.Value}");
    }
}

//or

static void PrintDictionary2(Dictionary<string, int> dictionary)
{
    foreach (var (name, number) in dictionary)
    {
        Console.WriteLine($"{name}: {number}");
    }
}