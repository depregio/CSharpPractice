//Property patterns

//Property patterns let you match objects based on their property values using { PropertyName: pattern } syntax.
//This is powerful for writing expressive conditions without accessing properties explicitly.
//They are null safe and best in switch expressions and multiple condition checks.

//Relational patterns in properties:
//      PATTERN             MEANING
//      { Age: 18 }         Exactly 18
//      { Age: < 18 }	    Less than 18
//      { Age: >= 65 }	    65 or older
//      { IsActive: true }  Boolean check

//Basic syntax
if (person is { Name: "Alice" })                    //Match exact property value
    Console.WriteLine("Found Alice!");

if (person is { Age: >= 18 })                       //Match with relational patterns
    Console.WriteLine("Adult");

if (person is { Age: >= 21, IsEmployed: true })     //Combine multiple properties
    Console.WriteLine("Employed adult 21+");


//Property patterns in switch
string result = order switch
{
    { Total: 0 } => "Empty order",
    { Total: < 50 } => "Small order",
    { Total: >= 50, IsPriority: true } => "Priority large order",
    { Total: >= 50 } => "Large order",
    _ => "Unknown"
};



//Test: classify a Person based on their properties:
//          If Age is less than 18, return "Minor"
//          If Age is 65 or greater, return "Senior"
//          If IsEmployed is true (and age is 18-64), return "Working Adult"
//          If IsEmployed is false (and age is 18-64), return "Unemployed Adult"
//      Use property patterns in a switch expression.
public class Solution
{
    public static string ClassifyPerson(Person person) => person switch
    {
        { Age: < 18 } => "Minor",
        { Age: >= 65 } => "Senior",
        { IsEmployed: true, Age: >= 18 and <= 64 } => "Working Adult",
        { IsEmployed: false, Age:  >= 18 and <= 64} => "Unemployed Adult",
    };
}
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsEmployed { get; set; }

    public Person(string name, int age, bool isEmployed)
    {
        Name = name;
        Age = age;
        IsEmployed = isEmployed;
    }
}