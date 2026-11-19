//Spread operator in collections

//The spread operator .. (C# 12+) allows you to "spread" or expand the elements of a collection into another collection.
//This is incredibly useful for combining arrays, lists, or any enumerable.

//In comparison, the traditional "arr1.Concat(arr2).ToArray()" requires LINQ and results more verbose.


//Basic syntax
int[] numbers1 = [1, 2, 3];
int[] numbers2 = [4, 5, 6];

int[] combined = [.. numbers1, .. numbers2];    //[1, 2, 3, 4, 5, 6]    //Combine arrays using spread


//Adding elements while spreading
int[] original = [2, 3, 4];

int[] withPrefix = [1, .. original];           //[1, 2, 3, 4]           //Add elements before, between, or after
int[] withSuffix = [.. original, 5];           //[2, 3, 4, 5]
int[] withBoth = [0, .. original, 5, 6];       //[0, 2, 3, 4, 5, 6]


//Combining multiple collections
int[] a = [1, 2];
int[] b = [3, 4];
int[] c = [5, 6];

int[] all = [.. a, .. b, .. c];     //[1, 2, 3, 4, 5, 6]



//Test: implement a method that merges two integer arrays into a single array using the spread operator.
//      The elements from the first array should appear before the elements from the second array.
public class Solution
{
    public static int[] MergeArrays(int[] first, int[] second)
    {
        int[] mergedArray = [..first, ..second];
        return mergedArray;
    }
}