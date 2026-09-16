string[] fraudulentOrderIds = new string[3];    //Declaring a new array of strings that can hold three elements
int[] howManyFlags = new int[3];                //Declaring a new array of ints that can hold three elements

fraudulentOrderIds[0] = "A123";     //Assigning Order ID values to array
fraudulentOrderIds[1] = "B456";
fraudulentOrderIds[2] = "C789";

//fraudulentOrderIDs[3] = "D000";   //Index outside the bounds of the array

Console.WriteLine($"First: {fraudulentOrderIds[0]}");
Console.WriteLine($"Second: {fraudulentOrderIds[1]}");
Console.WriteLine($"Third: {fraudulentOrderIds[2]}");

fraudulentOrderIds[0] = "F000";     //Reassigning another value

Console.WriteLine($"Reassign First: {fraudulentOrderIds[0]}");

string[] correctOrderIDs = ["A123", "B456", "C789"];            //Initializing an array
//string[] fraudulentOrderIds = { "A123", "B456", "C789" };     //This syntax {} with is also valid

Console.WriteLine($"There are {fraudulentOrderIds.Length} fraudulent orders to process.");  //Length property (int) of an array 


//Foreach statement
string[] names = { "Rowena", "Robin", "Bao" };
foreach(string name in names)   //name is a temporary value used inside the statement
{                               //At every n iteration name = names[n-1]
    Console.WriteLine(name);    //Will execute once for each element of the names array.
}

//Test: Inventory reporting
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");

//Test: Complete a challenge activity for nested iteration and selection statements
string[] orderIds = ["B123","C234","A345","C15","B177","G3003","C235","B179"]; 
foreach(string orderId in orderIds)
{
    if (orderId.StartsWith("B") || orderId.StartsWith("b"))
    {
        Console.WriteLine(orderId);
    }
}