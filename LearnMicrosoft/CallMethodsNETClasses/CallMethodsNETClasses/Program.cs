//Calling a method
Console.WriteLine("Hello, World."); //Console is the class name.
                                    //. is the member access operator.
                                    //WriteLine is the method's name.
                                    //() is the method invocation operator.
                                    //"Hello, World." is the (string) argument passed to the method.
                                    //This method has no return value.


//Stateless vs stateful methods

//Stateless (static) methods work without referencing or changing any values already stored in memory.
//Console.WriteLine() is a stateless method.

//Stateful (instance) methods must access the state of the application to work properly. They rely on values stored in memory.
//Stateful methods keep track of their state in fields, which are the class variables.

//When you need to call stateful methods, you must first create an instance of the class so that the method can access state.
//An instance of a class is called as an object.

Random die = new Random();      //new creates an instance of the Random class.
int roll = die.Next(1,7);       //Next method uses the state stored in the die object to generate a random number.
Console.WriteLine(roll);


//Return values

//Some methods are designed to return a value upon completion. It can be any data type.
//Methods that don't return a value are called void methods.

//The Random.Next() method returns an int value.


//Method parameters and arguments

//Arguments are the values passed when the method is called.
//Parameters are variables that are used inside the method.

//Usually the arguments are used to assign values to the parameters.


//Overloaded methods

//An overloaded method is defined with multiple method signatures. They accept different groups of arguments to be called.

int number = 7;
string text = "seven";

Console.WriteLine(number);  //Uses a method signature that defines an int parameter.
Console.WriteLine();        //Uses a method signature that defines zero parameters.
Console.WriteLine(text);    //Uses a method signature that defines a string parameter.

Random dieOverloader = new Random();
int roll1 = dieOverloader.Next();           //Doesn't set boundaries, the method will return values from 0 to 2,147,483,647 (max int).
int roll2 = dieOverloader.Next(101);        //Specifies the maximum upper boundary, expect a random value between 0 and 100.
int roll3 = dieOverloader.Next(50, 101);    //Specifies minimum and maximum values, expect a random value between 50 and 100.

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");


//Test: Implement a method of the Math class that returns the larger of two numbers
int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue=System.Math.Max(firstValue,secondValue);

Console.WriteLine(largerValue);
