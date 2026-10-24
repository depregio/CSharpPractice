//Adding Items to Lists

//The Add() method appends a single item to the end of a list.
//This is one of the most common operations when working with collections.


//Basic syntax
List<int> numbers = new List<int>();
numbers.Add(10);    // List now contains: [10]
numbers.Add(20);    // List now contains: [10, 20]
numbers.Add(30);    // List now contains: [10, 20, 30]



//Test: create an empty list of strings, then use the Add() method to add three fruits: "Apple", "Banana", and "Cherry". Print each item on a separate line.
List<string> fruits = new List<string>();

AddItemsToList(fruits,"Apple","Banana","Cherry");

foreach(string fruit in fruits)
{
    Console.WriteLine(fruit);
}

static void AddItemsToList(List<string> list, params string[] itemsToAdd)
{
    foreach(string item in itemsToAdd)
    {
        list.Add(item);
    }
}