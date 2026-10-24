//Creating Lists

//A List<T> is a dynamic collection that can grow or shrink.
//Unlike arrays, you don't need to specify a fixed size upfront.


//Declaration and initalizaion
List<int> numbers = new List<int>();                                    //Empty list

List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" }; //List with initial values using collection initializer

var colors = new List<string> { "Red", "Green", "Blue" };               //Using var for cleaner syntax


//Iterating over a list
List<string> names = new List<string> { "Alice", "Bob" };

foreach (string name in names)          //With foreach
{
    Console.WriteLine(name);
}

for (int i = 0; i < names.Count; i++)   //With for loop with Count property
{
    Console.WriteLine(names[i]);
}



//Test: create a List<string> containing exactly three names: "Alice", "Bob", and "Charlie". Then print each name on its own line.
List<string> classmatesNames = new List<string> { "Alice", "Bob", "Charlie" };

for(int i=0; i<classmatesNames.Count; i++)
{
    Console.WriteLine(classmatesNames[i]);
}