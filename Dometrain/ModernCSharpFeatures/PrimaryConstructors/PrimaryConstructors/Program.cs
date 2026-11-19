//Primary constructors

//Primary constructors (C# 12+) let you declare constructor parameters directly in the class declaration,
//eliminating boilerplate code for simple classes.


//Traditional constructor vs primary constructor
public class Person
{
    private string _name;

    public Person(string name)      //Traditional approach
    {
        _name = name;
    }

    public string Name => _name;
}

public class Person2(string name)   //Primary constructor
{
    public string Name => name;     //You don't write a private field, but if a member uses the parameter,
}                                   //the compiler stores it in a hidden one.


//Using primary constructor parameters
public class Rectangle(double width, double height)     //Parameters are available throughout the class
{
    public double Width => width;
    public double Height => height;
    public double Area => width * height;

    public string Describe() => $"{width} x {height}";
}



//Test: convert the Employee class to use a primary constructor. The class should:
//          Take name, department, and yearsOfService as primary constructor parameters
//          Expose them as read-only properties
//          Keep the GetDescription() method working
public class Employee(string name, string department, int yearsOfService)
{
    public string Name => name;
    public string Department => department;
    public int YearsOfService => yearsOfService;

    public string GetDescription()
    {
        return $"{name} works in {department} for {yearsOfService} years";
    }
}

public class Solution
{
    public static string DescribeEmployee(string name, string department, int yearsOfService)
    {
        var employee = new Employee(name, department, yearsOfService);
        return employee.GetDescription();
    }
}