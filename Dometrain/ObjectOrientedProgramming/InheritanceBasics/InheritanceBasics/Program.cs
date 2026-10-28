//Inheritance basics

//Inheritance allows a class to inherit properties and methods from another class,
//promoting code reuse and establishing an "is-a" relationship between types.

//What Gets Inherited:
//      All public and protected members (properties, methods, fields).
//      The derived class can access inherited members directly.
//      Constructors are NOT inherited: you must call the base constructor.


//The : syntax
Car myCar = new Car("Toyota", 4);
string brand = myCar.Brand;     //Inherited property
string sound = myCar.Honk();    //Inherited method

public class Vehicle            //Base classe (parent)
{
    public string Brand { get; set; }

    public Vehicle(string brand)
    {
        Brand = brand;
    }

    public string Honk()
    {
        return "Beep!";
    }
}

public class Car : Vehicle      //Derived class (child) - inherits from Vehicle
{
    public int Doors { get; set; }

    public Car(string brand, int doors) : base(brand)   //Call base constructor using : base()
    {
        Doors = doors;
    }
}


//Calling the base constructor
public class Animal
{
    public string name;
    public int age;

    public Animal(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}
public class Dog : Animal
{
    public Dog(string name, int age) : base(name, age)  //Use : base(args) to pass values to the parent constructor that will be used
    {
        //Additional Dog-specific initialization here
    }
}



//Test: create a Dog class that inherits from the FarmAnimal base class:
//          Use the : FarmAnimal syntax to declare inheritance.
//          Create a constructor that takes name and age, passing them to the base class using : base(name, age).
//          Add a Speak() method that returns "Woof! My name is {Name}".
public class FarmAnimal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public FarmAnimal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Speak()
    {
        return "Some sound";
    }

    public string GetInfo()
    {
        return $"{Name} is {Age} years old";
    }
}

public class FarmDog : FarmAnimal
{
    public FarmDog(string name, int age) : base (name, age)
    {

    }

    public string Speak()
    {
        return $"Woof! My name is {Name}";
    }
}