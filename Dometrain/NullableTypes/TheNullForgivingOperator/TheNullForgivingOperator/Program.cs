//The null-forgiving operator

//The null-forgiving operator (!) tells the compiler "I know this value is not null, trust me."
//It suppresses nullable warnings when you have knowledge the compiler doesn't.

//The null-forgiving operator does NOT change behavior
//The ! operator is purely a compile-time hint. It does not add any null checking at runtime.
//          CODE            EFFECT
//          text!	        Suppresses warning only
//          text ?? ""	    Actually provides fallback
//          text?.Length	Actually prevents crash


//When to use it
string? name = GetName();
int length = name.Length;   //Compiler warns: possible null reference (Warning CS8602)

int length2 = name!.Length; //Tell the compiler you KNOW it's not null (no warning)


//Common Scenarios
if (IsValidUser(user))      //After your own null check that compiler doesn't recognize
{
    Console.WriteLine(user.Name!.ToUpper());            //You know user.Name is set, but compiler doesn't
}

string[] args = GetCommandLineArgs();   //Never null    //When data comes from a trusted source
string firstArg = args[0]!;


//Warning: use with caution!
string? maybeNull = null;       //DANGEROUS: if you're wrong, you get NullReferenceException
int len = maybeNull!.Length;    //Compiles, but CRASHES at runtime!



//Test: implement a method that returns the length of a string. The method receives:
//              text:                   a nullable string
//              isGuaranteedNotNull:    a boolean flag indicating if the caller guarantees the text is not null
//      When isGuaranteedNotNull is true, use the null-forgiving operator to access the string's length directly (trusting the caller).
//      When isGuaranteedNotNull is false, return -1 if the text is null, otherwise return its length.
public class Solution
{
    public static int GetStringLength(string? text, bool isGuaranteedNotNull)
    {
        if (isGuaranteedNotNull)
            return text!.Length;
        else
            return text?.Length ?? -1;  //text.Length ?? -1  is wrong: if text is null, .Length crashes before ?? runs.
                                        //Use ?. to reach into something that might be null, then ?? for the fallback.
    }
}
