//Properties and encapsulation

//Properties are a core mechanism for implementing encapsulation in C#.
//Encapsulation is one of the four pillars of object-oriented programming.
//It means hiding the internal details of how data is stored while providing controlled access through a public interface.
//Without encapsulation, anyone could directly modify your object's data in invalid ways.


//Without encapsulation (dangerous)
Product p = new Product();
p.price = -100;             //No protection. Anyone could directly modify your object's data in invalid ways.

public class Product
{
    public decimal price;   //Public field: anyone can change it to -100.
}

//With encapsulation (safe)
public class ProductSafe
{
    private decimal _price; //The backing field is private—it cannot be accessed directly from outside the class.
                            //Microsoft’s own C# coding conventions say to use _camelCase for private and internal fields.
    public decimal Price    //A property, a controlled public access point. From the outside the syntax is identical (dot notation).
    {
        get                 //Get is used to get access to the private field.
        { 
            return _price; 
        }
        set                 //Set is used to change the private field.
        {
            if (value > 0)  //Inside the setter, value represents the incoming data being assigned.
                _price = value;
        }
    }
}


//Adding validation logic
public class Person
{
    private int _age;
    public int Age
    {
        get { return _age; }
        set
        {
            if (value >= 0 && value <= 150)  // Validation!
            {
                _age = value;
            }
            //If invalid, the value is simply ignored
        }
    }
}



//Test: create a Product class that demonstrates encapsulation:
//          A private backing field _name and a public Name property
//          A private backing field _price and a public Price property
//          The Price setter should only accept positive values (greater than 0)—this protects the object from invalid data
public class ProductEncapsulated
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    private decimal _price;
    public decimal Price
    {
        get { return _price; }
        set
        {
            if (value > 0)
                _price = value;
        }
    }
}