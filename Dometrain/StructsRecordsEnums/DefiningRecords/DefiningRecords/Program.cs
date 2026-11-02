//Records in C#

//Records are reference types designed for immutable data.
//They provide built-in value-based equality, making them perfect for data transfer objects and models.

//They’re a shortcut for writing a class that holds values, with the boilerplate generated for you.


//Accessing Properties
var person = new Person("Bob", 25);
Console.WriteLine(person.Name);     //"Bob"
Console.WriteLine(person.Age);      //25


//Value based equality
var person1 = new Person("Alice", 30);  //Records compare by their property values, not by reference.
var person2 = new Person("Alice", 30);

bool isEqual = person1 == person2;      //True. Same values. (Same for strings but they are exceptions)


//Defining a Record
public record Person(string Name, int Age);     //Positional record syntax (most concise)

// This automatically creates:
//      Properties: Name and Age
//      A constructor: new Person("Alice", 30)
//      Value-based equality
//      ToString() method


//Records vs Classes
public class PersonClass
{
    public string Name { get; init; }
    public int Age { get; init; }
    //Plus override Equals, GetHashCode, ToString... (it's quite long)
}

public record PersonRecord(string Name, int Age);   //With a record you only need one line.



//Test: 
//      Define a Person record with Name (string) and Age (int) properties
//      Implement CreatePerson to create and return a Person record
//      Implement GetPersonInfo to return formatted info
//      Implement ArePeopleEqual to compare two Person records
public record Person2(string Name, int Age);

public class Solution
{
    public static Person2 CreatePerson(string name, int age)
    {
        return new Person2(name, age);
    }

    public static string GetPersonInfo(Person2 person)
    {
        return $"Name: {person.Name}, Age: {person.Age}";
    }

    public static bool ArePeopleEqual(Person2 person1, Person2 person2)
    {
        return person1 == person2;
    }
}