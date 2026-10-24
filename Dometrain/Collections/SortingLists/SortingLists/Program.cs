//Sorting lists


//The Sort() method arranges list elements in ascending order (smallest to largest).
List<int> numbers = new List<int> { 5, 2, 8, 1, 9 };
numbers.Sort();                 //{ 1, 2, 5, 8, 9 }

List<string> names = new List<string> { "Charlie", "Alice", "Bob" };
names.Sort();                       //{ "Alice", "Bob", "Charlie" }


//The Reverse() method flips the order of elements.
List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5 };
numbers2.Reverse();              //{ 5, 4, 3, 2, 1 }


//Combine Sort() and Reverse() for descending order
List<int> scores = new List<int> { 50, 90, 30 };
scores.Sort();
scores.Reverse();               //{ 90, 50, 30 }


//Both methods modify the original list.



//Test: Write a method that takes a list of integers and returns it sorted in ascending order (smallest to largest).
static List<int> SortAscendingNumbers(List<int> numbers)
{
    numbers.Sort();
    return numbers;
}

//This method's return results redundant since lists are passed by reference.

List<int> numbers3 = new List<int> { 2, 9, 3, 5, 0 };

Console.WriteLine(String.Join(" ", numbers3));  //2 9 3 5 0

SortAscendingNumbers2(numbers3); 

Console.WriteLine(String.Join(" ", numbers3));  //0 2 3 5 9

static void SortAscendingNumbers2(List<int> numbers)
{  
    numbers.Sort(); 
}