//ThenBy for Secondary Sorting

//ThenBy() adds a secondary sort criteria after OrderBy().
//When multiple items have the same value for the primary sort key, ThenBy() determines their order using the secondary key.


//Basic Usage
using System.Linq;

var people = new List<Person>
{
    new Person("Carla", 22),
    new Person("Alice", 30),
    new Person("Bob", 22),
    new Person("Dan", 30),
    new Person("Eve", 18)
};

var sorted = people         //Sort by age, then by name
    .OrderBy(p => p.Age)
    .ThenBy(p => p.Name)
    .ToList();

var staff = new List<Employee>
{
    new Employee("Ann", "Sales", 3000),
    new Employee("Ben", "IT", 4500),
    new Employee("Cleo", "Sales", 3500),
    new Employee("Dave", "IT", 5200),
    new Employee("Elsa", "HR", 3100)
};

var employees = staff       //Sort by department, then by salary descending
    .OrderBy(e => e.Department)
    .ThenByDescending(e => e.Salary)
    .ToList();


//Multiple levels of sorting
var items = new List<Item>
{
    new Item("Fruit", "Citrus", "Orange"),
    new Item("Veg", "Root", "Carrot"),
    new Item("Fruit", "Berry", "Strawberry"),
    new Item("Fruit", "Citrus", "Lemon"),
    new Item("Fruit", "Berry", "Blueberry"),
    new Item("Veg", "Leaf", "Spinach")
};

var result = items          //You can chain multiple ThenBy() calls for more complex sorting
    .OrderBy(x => x.Category)      // Primary
    .ThenBy(x => x.Subcategory)    // Secondary
    .ThenBy(x => x.Name)           // Tertiary
    .ToList();


public record Person(string Name, int Age);
public record Employee(string Name, string Department, decimal Salary);
public record Item(string Category, string Subcategory, string Name);



//Test: given a list of full names in "FirstName LastName" format, sort them alphabetically by last name first,
//      then by first name when last names are the same.
public class Solution
{
    public static List<string> SortByLastNameThenFirstName(List<string> fullNames)
    {
        return fullNames
            .OrderBy(n => n.Split(" ")[1])
            .ThenBy(n => n.Split(" ")[0])
            .ToList();
    }
}