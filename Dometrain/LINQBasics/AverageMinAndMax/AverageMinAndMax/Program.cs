//Average, min, and max aggregation methods

//Average(), Min(), and Max() are LINQ aggregation methods that calculate statistical values from a collection.
//They're essential for analyzing numeric data.

//These methods throw an InvalidOperationException if the collection is empty
//Average() returns double for integer collections
//For nullable types, use Average(), Min(), Max() which ignore null values


//Average()
using System.Linq;

var numbers = new List<int> { 10, 20, 30 }; //Returns the arithmetic mean of all elements in a collection.  
double avg = numbers.Average();             //20.0

var prices = new List<double> { 9.99, 19.99, 29.99 };
double avgPrice = prices.Average();         //19.99


//Min() and Max()
var scores = new List<int> { 85, 92, 78, 95, 88 };  //Return the smallest and largest values in a collection.
int lowest = scores.Min();      //78
int highest = scores.Max();     //95

var temps = new List<double> { -5.2, 12.8, 3.1 };
double coldest = temps.Min();   //-5.2
double warmest = temps.Max();   //12.8


//Using with Select
var students = new List<Student> {      //You can combine these with Select() to work with specific properties
    new ("Carla",22),
    new ("Dan", 17)
};

double avgAge = students.Select(s => s.Age).Average();
int youngestAge = students.Select(s => s.Age).Min();

public record Student (string Name, int Age);



//Test: implement three methods to analyze a list of test scores:
//          GetAverageScore - returns the average of all scores
//          GetMinimumScore - returns the lowest score
//          GetMaximumScore - returns the highest score
public class Solution
{
    public static double GetAverageScore(List<int> scores)
    {
        return scores.Average();
    }

    public static int GetMinimumScore(List<int> scores)
    {
        return scores.Min();
    }

    public static int GetMaximumScore(List<int> scores)
    {
        return scores.Max();
    }
}