//Attributes in C#

//Attributes add metadata to your code: extra information that the compiler, runtime, or other tools
//can use without changing how the code executes.

//Attributes are placed in square brackets [] above declarations like classes, methods, properties, or parameters.

//Common built-in attributes:
//      ATTRIBUTE       PURPOSE                                 EXAMPLE
//      [Obsolete]	    Mark deprecated code	                [Obsolete("Use X instead")]
//      [Serializable]  Allow object serialization              [Serializable] class Data
//      [Conditional]   Compile method only if symbol defined	[Conditional("DEBUG")]
//      [Flags]         Enable bitwise enum operations          [Flags]enum Permissions


//Attributes example
[AttributeName]
public void MyMethod()
{ }

[AttributeName("parameter")]
public class MyClass { }


//The [Obsolete] attribute
[Obsolete]              //Marks code as deprecated. The compiler generates a warning when obsolete code is used.
public void OldMethod() //Warning: 'OldMethod' is obsolete
{ }

[Obsolete("Use NewMethod instead.")]
public void OldMethod() //Warning includes your message
{ }

[Obsolete("Removed in v2.0", true)]  //Second parameter = error instead of warning
public void OldMethod()
{ }



//Test: Add the [Obsolete] attribute to the OldCalculation method
//      Include a custom message: "Use NewCalculation instead. This method will be removed in version 2.0."
//      In GetObsoleteMessage, call OldCalculation(5, 3) and return its result
public class Solution
{
    [Obsolete("Use NewCalculation instead. This method will be removed in version 2.0.")]
    public static string OldCalculation(int x, int y)
    {
        return $"Result: {x + y}";
    }

    public static string GetObsoleteMessage()
    {
        return OldCalculation(5,3);     //The compiler will show a warning, but the code still works.
    }
}