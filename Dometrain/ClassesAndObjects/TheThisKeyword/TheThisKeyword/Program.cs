//The this keyword

//The this keyword refers to the current instance of a class.
//It's commonly used to distinguish between class fields and constructor/method parameters that have the same name.

//When a parameter has the same name as a field, the parameter "shadows" the field within that scope.
//Using this explicitly refers to the instance field.

using System.Xml.Linq;

public class Example
{
    private int value;          //This is a field

    public Example(int value)   //This is a parameter with the same name
    {
        //value = value;        //Without 'this', 'value' refers to the parameter. value = value assigns the parameter to itself.
        this.value = value;     //this.value = field, value = parameter
    }
}


//Common uses of this
// 1. Distinguishing fields from parameters
this.name = name;

// 2. Passing the current instance to another method
SomeMethod(this);

// 3. Calling another constructor (constructor chaining)
public Person() : this("Unknown", 0) { }



//Test: complete the Person constructor to assign the parameters to the corresponding private fields using the this keyword.
public class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string Describe()
    {
        return $"{name} is {age} years old";
    }
}