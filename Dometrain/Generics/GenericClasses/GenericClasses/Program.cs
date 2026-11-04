//Generic classes

//Generic classes allow you to create reusable containers that work with any type.
//Instead of writing separate classes for BoxOfInt, BoxOfString, etc., you write one Box<T> class.


//Using Generic Classes
Box<int> intBox = new Box<int>(42);                 //Create boxes for different types
Box<string> stringBox = new Box<string>("Hello");
Box<double> doubleBox = new Box<double>(3.14);

//Accessing the values (strongly typed)
int number = intBox.Value;      // 42
string text = stringBox.Value;  // "Hello"


//Benefits Over object
object box = 42;        //Without generics (using object): requires casting, not type-safe
int value = (int)box;   //Must cast, could throw at runtime

Box<int> box2 = new Box<int>(42);    //With generics: type-safe at compile time
int value2 = box2.Value;              //No cast needed, compiler ensures type safety


//Type Parameters
public class Box<T>     //T is a type parameter: a placeholder for any type
{
    public T Value { get; set; }

    public Box(T value)
    {
        Value = value;
    }
}



//Test: Complete the Box<T> class:
//          Add a Value property of type T
//          Add a constructor that accepts a T parameter and sets the Value
//      Implement two helper methods:
//          CreateBox<T>(T value): creates and returns a new Box<T>
//          GetBoxValue<T>(Box<T> box): returns the value stored in the box
public class Box2<T>
{
    public T Value { get; set; }

    public Box2(T value)
    {
        Value = value;
    }
}

public class Solution
{
    public static Box2<T> CreateBox<T>(T value)
    {
        return new Box2<T>(value);
    }

    public static T GetBoxValue<T>(Box2<T> box)
    {
        return box.Value;
    }
}