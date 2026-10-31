//Virtual Methods

//The virtual keyword marks a method that can be overridden by derived classes.
//This enables polymorphism, the ability for different types to respond differently to the same method call.


//Polymorphism in acton
Animal myPet = new Dog();       //Variable is Animal type
string sound = myPet.Speak();   //Calls Dog.Speak() -> "Woof!"

myPet = new Cat();              //Same variable, different object
sound = myPet.Speak();          //Calls Cat.Speak() -> "Meow!"


//Declaring and overriding virtual methods
public class Animal
{
    public virtual string Speak()   //Virtual allows derived classes to override this
    {
        return "Some sound";
    }
}

public class Dog : Animal
{
    public override string Speak()  //Override provides a new implementation
    {
        return "Woof!";
    }
}

public class Cat : Animal
{
    public override string Speak()  //Override provides a new implementation
    {
        return "Meow!";
    }
}


//Test: Create a class hierarchy with virtual methods:
//          Animal base class with a virtual method Speak() that returns "Some sound"
//          Dog class that inherits from Animal and overrides Speak() to return "Woof!"
//          Cat class that inherits from Animal and overrides Speak() to return "Meow!"
//          Complete TestAnimalSpeak() to create the appropriate animal and return its Speak() result
public class Animal2
{
    public virtual string Speak()
    {
        return "Some sound";
    }
}

public class Dog2: Animal2
{
    public override string Speak()
    {
        return "Woof!";
    }
}

public class Cat2: Animal2
{
    public override string Speak()
    {
        return "Meow!";
    }
}

public class Solution
{
    public static string TestAnimalSpeak(string animalType)
    {
        // Create the appropriate animal based on animalType
        // and return the result of calling Speak()
        // animalType can be: "animal", "dog", or "cat"
        Animal2 myAnimal;

        switch (animalType.ToLower())
        {
            case "dog":
                myAnimal = new Dog2();
                return myAnimal.Speak();

            case "cat":
                myAnimal = new Cat2();
                return myAnimal.Speak();

            case "animal":
            default:
                myAnimal = new Animal2();
                return myAnimal.Speak();
        }       
    }
}