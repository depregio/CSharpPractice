//The null-conditional operator

//The null-conditional operator (?.) allows you to safely access members of an object that might be null,
//short-circuiting the evaluation and returning null instead of throwing a NullReferenceException.

//You can chain multiple ?. operators to safely navigate through nested properties.


//Basic usage
Person? person = null;

int length = person.Name.Length;    //Crashes                   //Without null-conditional (throws NullReferenceException)

int? length2 = person?.Name?.Length; //Returns null, no crash   //With null-conditional (returns null safely)


//Chaining Null-Conditional Operators
int? result = person?.Name?.Length; //If person is null, returns null. If person.Name is null, returns null. Otherwise, returns the length


//Combining with null-coalescing
int length3 = person?.Name?.Length ?? 0; //Returns 0 if person is null OR if Name is null. Returns the actual length otherwise (if that isn't null too).
                                         //Combine?.with ?? to provide a default value when the chain results in null.




//Test: implement a method that safely returns the length of a person's name.
//      The Person object might be null, and even if it exists, the Name property might be null.
//      Return 0 if either the person or their name is null.
public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

public class Solution
{
    public static int GetNameLength(Person? person)
    {
        return person?.Name?.Length ?? 0;
    }
}