//Read-only properties

//Read-only properties use { get; } without a setter, meaning they can only be assigned a value in the constructor and never changed afterward.


//Declaration syntax
public class Product
{
    public string ProductId { get; }
    public decimal Price { get; }

    public Product(string id, decimal price)
    {
        ProductId = id;
        Price = price;
    }

    public void UpdatePrice(decimal newPrice)
    {
        //Price = newPrice;     //Error: cannot assign after construction.
    }
}



//Test: Create a Person class with two read-only properties:
//          Name(string) - the person's name
//          BirthYear (int) - the year they were born
//      Both properties should only be settable through the constructor.
public class Person
{
    public string Name { get; }
    public int BirthYear { get; }

    public Person(string name, int birthYear)
    {
        Name = name;
        BirthYear = birthYear;
    }
}