//Collection expression syntax

//Collection expressions (C# 12+) provide a concise way to create arrays, lists, and other collections using the [...] syntax.

//Collection expressions are shorter and more readable than traditional approaches.


//Basic usage
int[] numbers = [1, 2, 3, 4, 5];                    //Creating an array with collection expression

List<string> names = ["Alice", "Bob", "Charlie"];   //Creating a List with collection expression

int[] empty = [];                                   //Empty collection


//Vs traditional syntax
int[] oldWay = new int[] { 1, 2, 3 };           //Traditional array initialization

int[] newWay = [1, 2, 3];                       //Collection expression (C# 12+)

List<int> oldList = new List<int> { 1, 2, 3 };  //Traditional List initialization

List<int> newList = [1, 2, 3];                  //Collection expression for List


//Using variables in collection expressions
int x = 10;                         //You can use variables and expressions inside collection expressions.
int y = 20;
int[] values = [x, y, x + y, 100];  //Result: [10, 20, 30, 100]



//Test: create a method that takes five integer parameters and returns an array containing all five numbers using collection expression syntax.
public class Solution
{
    public static int[] CreateNumberArray(int first, int second, int third, int fourth, int fifth)
    {
        int[] numberArray = [first, second, third, fourth, fifth];
        return numberArray;
    }
}