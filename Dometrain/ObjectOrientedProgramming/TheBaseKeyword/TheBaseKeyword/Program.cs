//The base keyword

//The base keyword allows a derived class to access members of its base class, including constructors and methods.
//This is essential for proper initialization and code reuse in inheritance hierarchies.

//The base keyword only reaches one level up: the immediate parent.
//You can’t write base.base.Method(); and you can’t pick a specific grandparent with it.
//You can either make it work as a chain or redesign so you don’t need to (this is often a sign the hierarchy is off).


//Calling base constructors
public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }
}

public class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, string breed) : base(name)  //Use : base(name) to call the parent constructor
    {
        Breed = breed;
    }
}


//Calling base methods
public class Vehicle
{
    public virtual string GetDescription()
    {
        return "This is a vehicle";
    }
}

public class Car : Vehicle
{
    public override string GetDescription()
    {
        return base.GetDescription() + " with four wheels"; //Calls the base class method and extends it
    }
}



//Test: complete the Employee class that inherits from Person:
//          Implement the constructor to call the base class constructor with the name parameter using : base(name).
//          Override GetInfo() to call base.GetInfo() and append the department information.
public class Person         //Private field: accessible only inside the class that declares it. Not even derived classes can touch it.
{                           //Protected field: accessible inside the declaring class and in any class that inherits from it. Still hidden from outside code.
    public string Name { get; protected set; }

    public Person(string name)
    {
        Name = name;
    }

    public virtual string GetInfo()     //virtual marks a method (or property) in a base class as overridable.
    {                                   //A derived class can then replace its behavior with override.
        return $"Name: {Name}";
    }
}

public class Employee : Person
{
    public string Department { get; private set; }

    public Employee(string name, string department) : base(name)
    {
        Department = department;
    }

    public override string GetInfo()    //ovveride lets methods override the parent's class virtual method with the same name.      
    {                                   //override makes the method automatically virtual for other child classes.
        return base.GetInfo() + $", Department: {Department}";
    }
}