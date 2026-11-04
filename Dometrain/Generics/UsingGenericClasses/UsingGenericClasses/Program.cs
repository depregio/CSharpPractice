//Instantiating generic classes

//When you use a generic class, you must specify the actual type that replaces the type parameter T.
//This creates a concrete, type-safe version of the class.


//Creating instances with specified argument types
Box<int> intBox = new Box<int>(42);                 //T becomes int
Box<string> stringBox = new Box<string>("hello");   //T becomes string
Box<double> doubleBox = new Box<double>(3.14);


//Type safety
Box<int> numbers = new Box<int>(100);   //Once you specify the type, the compiler enforces it
int value = numbers.Value;              //No casting needed
//numbers.Value = "text";               //Compile error. Can't assign string to int

Box<string> words = new Box<string>("C#");
string text = words.Value;              //Type-safe access


//Different types, same class
Box<int> box1 = new Box<int>(5);            //Each instantiation creates a distinct type:
Box<string> box2 = new Box<string>("five"); //box1 and box2 are completely different types but share the same underlying generic definition


//Returning two values at once
static (int, string) GetPair()  //The return type lists both types, in order
{
    return (42, "hello");
}

var pair = GetPair();           //Read them back with Item1, Item2, and so on
int number = pair.Item1;        //42            //This grouping is called a tuple.
string text2 = pair.Item2;      //"hello"       //You get a full chapter on tuples later in the course; the syntax above is all you need here.


public class Box<T>
{
    public T Value { get; set; }

    public Box(T value)
    {
        Value = value;
    }
}



//Test: Create instances of the generic Box<T> class with two different type arguments:
//          Create a Box<int> containing the given number
//          Create a Box<string> containing the given text
//          Return both boxes as a tuple
public class Solution {
    public static (Box<int>, Box<string>) CreateBoxes(int number, string text)
    {
        Box<int> numberBox = new Box<int>(number);
        Box<string> textBox = new Box<string>(text);

        return (numberBox, textBox);
    }
}