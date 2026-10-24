//Removing items from lists


//The Remove() method. It removes the first occurrence of the same value inserted. it can return true if item is found (and removed), false if not.
List<string> fruits = new List<string> { "apple", "banana", "cherry" };

fruits.Remove("banana");  // List now: ["apple", "cherry"]

bool wasRemoved = fruits.Remove("mango");  // Returns false (not in list)


//The RemoveAt() method. It removes by index position.
List<string> colors = new List<string> { "red", "green", "blue" };

colors.RemoveAt(0);  // Removes "red",  List now: ["green", "blue"]
colors.RemoveAt(1);  // Removes "blue", List now: ["green"]

//Throws exception if index is out of range.



//Test: Write a method that uses Remove() to remove a specific item from a list of strings and returns the modified list.
static List<string> RemoveItem(List<string> items, string itemToRemove)
{
    items.Remove(itemToRemove);
    return items;
}