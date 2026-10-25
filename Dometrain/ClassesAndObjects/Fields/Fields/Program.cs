//Fields in classes

//Fields are variables that belong to a class and store the data (state) of an object.
//They define what information an object can hold.


//Accessing Fields with dot notation
Car myCar = new Car();    //Creates an object
myCar.Brand = "Toyota";   //Sets the Brand field
myCar.Year = 2023;        //Sets the Year field

string carBrand = myCar.Brand;  // Read the Brand field


//Declaring public fields
public class Car
{
    public string Brand;      //The car brand
    public int Year;          //The manufacturing year
    public double Price;      //The price
}

//Fields are automatically initialized to default values if not set.



//Test: define a Person class by adding two public fields, in this order:
//          Name (string) - stores the person's name
//          Age(int) - stores the person's age
    
//      Then create a CreatePerson method to:
//          Set the Name and Age fields on the person object using the provided parameters
//          Return the person object itself

//      The tests check the Name and Age fields on the object you return, so make sure both are set.
Person CreatePerson(string name, int age)
{
    Person person = new Person();
    person.Name = name;
    person.Age = age;
    return person; 
}
public class Person
{
    public string Name;
    public int Age;
}