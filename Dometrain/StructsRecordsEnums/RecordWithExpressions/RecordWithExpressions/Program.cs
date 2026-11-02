//Record with expressions

//The with expression creates a copy of a record with one or more properties changed.
//Since records are immutable by default, with is the idiomatic way to create modified versions.


//Basic Syntax
var alice = new Person("Alice", 30);
var olderAlice = alice with { Age = 31 };  //New record, Name (Alice) unchanged

record Person(string Name, int Age);


//Changing Multiple Properties
var home = new Address("123 Main St", "London", "UK");
var newHome = home with { Street = "456 Oak Ave", City = "Manchester" };    //Country stays "UK", only Street and City changed

record Address(string Street, string City, string Country);



//Test: implement three methods using with expressions:
//          UpdateAge:      Return a new Person with the specified age
//          ApplyDiscount:  Return a new Product with the specified price
//          Promote:        Return a new Employee with updated title AND salary (add the increase to current salary)
public class Solution
{
    public static Person2 UpdateAge(Person2 person, int newAge)
    {
        return person with { Age = newAge };
    }

    public static Product ApplyDiscount(Product product, decimal newPrice)
    {
        return product with { Price = newPrice };
    }

    public static Employee Promote(Employee employee, string newTitle, int salaryIncrease)
    {
        return employee with { Title = newTitle, Salary = employee.Salary + salaryIncrease };
    }
}

public record Person2(string Name, int Age);

public record Product(string Name, decimal Price, int Stock);

public record Employee(string Name, string Title, int Salary);