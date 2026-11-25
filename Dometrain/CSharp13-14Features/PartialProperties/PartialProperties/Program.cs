//Partial properties

//C# 13 introduces partial properties,
//allowing you to split property declarations and implementations across multiple files in a partial class.
//This is useful for code generators and separating concerns.

//The split is declaration = what the property looks like to the rest of the code, implementation = how it works.
//It's the same idea as an interface and its implementing class, except both halves belong to the same class.

//Rules for partial properties
//      ASPECT              REQUIREMENT
//      Modifier	        Both parts must use partial keyword
//      Signature	        Must match exactly (type, name, accessors)
//      Accessors	        Declaration uses ;, implementation uses body
//      One implementation	Only one part can have the body


//Declaration vs implementation
public partial class Product        //File1.cs (declaration)
{
    public partial string Name { get; }     //Declaration only
}

public partial class Product        //File2.cs (implementation)
{
    private string _name = "";

    public partial string Name              //Implementation
    {
        get => _name;
    }
}

public class Product                //The merged equivalent is this
{
    public string Name { get; } = "";       //_name field is still there, but behind the Name property
}


//Get-only vs get/set
public partial string ReadOnly { get; }                 //Declaration       //Get-only partial property
public partial string ReadOnly { get => "value"; }      //Implementation

public partial int Count { get; set; }      //Declaration                   //Get and set partial property
public partial int Count                    //Implementation
{
    get => _count;
    set => _count = value;
}



//Test: complete the partial property implementations in Main.cs.
//      The property declarations are in PersonProperties.cs (read-only file):
//          FullName: Return FirstName +" " + LastName
//          Age: Calculate age as 2024 - BirthYear

//Main.cs
public class Solution
{
    public static string GetPersonInfo(string firstName, string lastName, int birthYear)
    {
        var person = new Person
        {
            FirstName = firstName,
            LastName = lastName,
            BirthYear = birthYear
        };

        return person.Summary;
    }
}

// Complete the partial property implementation
public partial class Person
{
    public partial string FullName
    {
        get
        {
            return FirstName + " " + LastName;      //get => FirstName + " " + LastName; would have been ok too.
        }
    }

    public partial int Age
    {
        get
        {
            return 2024 - BirthYear;                //get => 2024 - BirthYear; would have been ok too.
        }
    }
}

//PersonProperties.cs
//This file contains the partial property declarations
//You need to implement the property bodies in Main.cs

public partial class Person
{
    //Auto-implemented properties (no partial needed)
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public int BirthYear { get; set; }

    //Partial property declarations. Implementation is in Main.cs
    public partial string FullName { get; }
    public partial int Age { get; }

    //Computed property that uses the partial properties
    public string Summary => $"{FullName} is {Age} years old";
}