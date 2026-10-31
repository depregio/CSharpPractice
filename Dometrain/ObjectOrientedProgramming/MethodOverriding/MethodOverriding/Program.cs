//MethodOverriding

//Method overriding allows a derived class to provide a specific implementation of a method that is already defined in its base class,
//replacing the inherited behavior entirely.

//When you override a method:
//  The base class method must be marked virtual.
//  The derived class method must use the override keyword.
//  The method signature must match exactly (same name, parameters, return type).

//A method with override is considered virtual, it is ovveridable by another method.


//The override keyword
Cat cat = new Cat();
cat.Speak();                //Returns "Meow"

Animal genericAnimal = new Animal();
genericAnimal.Speak();      //Returns "Some sound"

Animal animal = new Cat();  //This makes use of the override keyword: polymorphism in action.
animal.Speak();             //Still returns "Meow"

//So what’s the difference between Cat cat = new Cat() and Animal animal = new Cat()?
//  The objects in memory are both Cat, but in the second one it is held inside an Animal variable type container.
//  In Cat cat = new Cat() you can call any member of both classes. In Animal animal = new Cat() you can call only what Animal declares.
//  So Animal animal = new Cat() gives you less access. You give up access on purpose, in exchange for code that works with any animal.

//  Think of it like a sort of reversed inheritance. The son overrides the father's behavior, even when accessed through a father variable.

public class Animal
{
    public virtual string Speak()  //Must be virtual
    {
        return "Some sound";
    }
}

public class Cat : Animal
{
    public override string Speak()  //Use override keyword
    {
        return "Meow";
    }
}



//Test: create a Dog class that:
//          Inherits from Animal.
//          Overrides the Speak() method to return "Woof".
public class Animal2
{
    public string Name { get; set; }

    public virtual string Speak()
    {
        return "Some sound";
    }
}

public class Dog: Animal2
{
    public override string Speak()
    {
        return "Woof";
    }
}


public class Solution
{
    public static string TestDogSpeak()
    {
        Dog dog = new Dog();
        return dog.Speak();     //Woof
    }

    public static string TestAnimalSpeak()
    {
        Animal2 animal = new Animal2();
        return animal.Speak();  //Some sound
    }

    public static string TestPolymorphicSpeak()
    {
        Animal2 animal = new Dog();
        return animal.Speak();  //Woof
    }

    public static string TestDogName(string name)
    {
        Dog dog = new Dog();
        dog.Name = name;
        return dog.Name;
    }
}