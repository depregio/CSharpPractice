//Creating custom attributes

//Custom attributes let you define your own metadata that can be attached to code elements and read at runtime using reflection.
using System.Reflection;


//Defining a custom attribute
public class DescriptionAttribute : Attribute   //Create a class that inherits from System.Attribute
{
    public string Text { get; }

    public DescriptionAttribute(string text)
    {
        Text = text;
    }
}


//Using AttributeUsage
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]  //[AttributeUsage] controls where your custom attribute can be applied
public class LoggableAttribute : Attribute { }  //AttributeTargets options: class, method, property, field, parameter, all, etc.

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]     //You can also control if the attribute can be applied multiple times
public class SingletonAttribute : Attribute { }


//Adding properties
[AttributeUsage(AttributeTargets.Class)]    //Attributes can have constructor parameters and named properties
public class TableAttribute : Attribute
{
    public string TableName { get; }            //Required (constructor)
    public string Schema { get; set; } = "dbo"; //Optional (property)

    public TableAttribute(string tableName)
    {
        TableName = tableName;
    }
}

[Table("Users", Schema = "app")]    //Usage //Named arguments (Schema = value) are assigned to public properties after the constructor runs.
public class User { }                       //It's like writing: var attr = new TableAttribute("Users"); attr.Schema = "app";


//Reading custom attributes
var attr = typeof(User).GetCustomAttribute<TableAttribute>();   //Use reflection to read attributes at runtime. Needs using System.Reflection;
Console.WriteLine(attr.TableName);  //"Users"                   //Reflection = inspecting types (properties, methods, attributes) at runtime via typeof(X)



//Test: complete the AuthorAttribute class, it should:
//          - Inherit from System.Attribute
//          - Have a Name property (string)
//          - Have a Version property (string, default to "1.0")
//          - Only be applicable to classes
//          - Not allow multiple applications on the same class
//      Apply [Author] to the Calculator class with name "John Smith" and version "2.0".
//      Apply [Author] to the StringHelper class with name "Jane Doe" (default version).
//      Implement GetAuthorInfo to read the attribute and return the formatted string.
public class Solution
{
    public static string GetAuthorInfo(Type type)
    {
        var author = type.GetCustomAttribute<AuthorAttribute>();    //"give me its [AuthorAttribute] label, or null if it has none."
        return author != null 
            ? $"Author: {author.Name}, Version: {author.Version}" 
            : "No author information";
    }
}   

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class AuthorAttribute : Attribute
{
    public string Name { get; }
    public string Version { get; set; } = "1.0";

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

[AuthorAttribute("John Smith", Version = "2.0")]
public class Calculator
{
    public int Add(int a, int b) => a + b;
}

[AuthorAttribute("Jane Doe")]   //[Author] and [AuthorAttribute] are the same: the "Attribute" suffix is optional inside [ ].
public class StringHelper       //In normal code, GetCustomAttribute<AuthorAttribute>() needs the full name.
{
    public string Reverse(string s) => new string(s.ToCharArray().Reverse().ToArray());
}