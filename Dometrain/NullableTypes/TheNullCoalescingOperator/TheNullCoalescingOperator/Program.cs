//The null-coalescing operator

//The null-coalescing operator (??) provides a concise way to return a default value when a nullable expression is null.
//It's cleaner than writing if-else checks for null.

//The value before ?? is considered unless it is null. In that case use the value after ?? is taken into consideration instead.


//Basic usage
int? maybeNumber = null;
int result = maybeNumber ?? 10;     //result is 10

int? hasValue = 42;
int result2 = hasValue ?? 10;       //result2 is 42


//Without vs with ??
int result3;                             //Without ?? (verbose)
if (number.HasValue)
    result3 = number.Value;
else
    result3 = defaultValue;

int result4 = number ?? defaultValue;    //With ?? (concise)


//Chaining multiple defaults
int? first = null;
int? second = null;
int? third = 100;

int result5 = first ?? second ?? third ?? 0;     //result is 100    //Keeps checking for values until it finds one.



//Test: implement a method that takes a nullable integer and a default value.
//Use the null-coalescing operator (??) to return the number if it has a value, or the default value if it's null.
public class Solution
{
    public static int GetValueOrDefault(int? number, int defaultValue)
    {
        return number ?? defaultValue;
    }
}