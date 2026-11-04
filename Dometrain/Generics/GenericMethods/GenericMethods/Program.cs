//Generic methods

//Generic methods are methods that define their own type parameters, independent of any class they belong to.
//Use them when you need type flexibility for a single operation without creating a generic class.


//Method syntax
static T Identity<T>(T input)   //Generic method declaration
{
    return input;
}

static void Display<S>(S item)   //The <T> after the method name declares the type parameter. You can change it but it's unusual.
{
    Console.WriteLine(item);
}


//Type inference                            //The compiler can often infer the type parameter from the arguments you pass
string result1 = Identity<string>("hello"); //Explicit type argument
int result2 = Identity(42);                 //Type inference: compiler figures out T is int


//Getting type information
static string GetTypeName<T>(T value)   //Inside a generic method, you can get information about the actual type
{                                       //typeof(T) gets the Type object for T
    return typeof(T).Name;              //Returns "Int32", "String", "Bool", etc.
}



//Test: create a generic Print method that takes any value and returns a formatted string showing both the value and its type name.
static string PrintTypeValueName<T>(T value)
{
    return $"Value: {value}, Type: {typeof(T).Name}";
}