//Default constructors

//A default constructor is a parameterless constructor that initializes an object with default values.
//It runs automatically when you create a new instance using new ClassName().

//Without a constructor, fields get their type's default values (null for strings, 0 for numbers, false for booleans).
//A default constructor lets you set meaningful initial values instead.


//Using a default constructor
Person person = new Person();
Console.WriteLine(person.Name);  //Guest
Console.WriteLine(person.Age);   //0


//Constructor syntax
public class Person
{
    public string Name;
    public int Age;

    public Person() //Default constructor. Same name as the class, no parameters.
    {
        Name = "Guest";
        Age = 0;
    }
}



//Test: create a default constructor for the Book class that initializes all fields with these default values:
//          Title = "Untitled"
//          Author = "Unknown"
//          PageCount = 0
//          IsAvailable = true
public class Book
{
    public string Title;
    public string Author;
    public int PageCount;
    public bool IsAvailable = false; //Field initializers: assign a default value right where the field is declared.
                                    //Use for simple, constant defaults, when no parameters or logic are needed.
    public Book()                   //The constructor will overwrite field initializers. IsAvailable will result as true here.
    {
        Title = "Untitled";
        Author = "Unknown";
        PageCount = 0;
        IsAvailable = true;
    }
}

//Use field initializers for simple defaults that are the same for every object.
//Use a constructor when values depend on parameters or logic.