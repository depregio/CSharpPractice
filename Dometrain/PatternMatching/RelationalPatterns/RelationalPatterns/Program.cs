//Relational patterns

//Relational patterns allow you to compare values against constants,
//using <, >, <=, and >= operators directly within pattern matching expressions.
//This creates clean, readable range-based logic.

//Relational Operators in Patterns
//      OPERATOR    MEANING                 EXAMPLE
//      <           Less than	            < 10 matches 9, 0, -5
//      >	        Greater than	        > 10 matches 11, 100
//      <=	        Less than or equal	    <= 10 matches 10, 5, -3
//      >=	        Greater than or equal	>= 10 matches 10, 15, 100


//Basic syntax
string result = number switch   //Using relational patterns in a switch expression
{
    < 0 => "Negative",
    0 => "Zero",
    > 0 => "Positive"
};

string grade = score switch     //Comparing against specific values
{
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    >= 60 => "D",
    < 60 => "F"
};


//Pattern Evaluation Order
string temp = celsius switch    //Patterns are evaluated top-to-bottom, so place more specific patterns first.
{                               //Order matters. More restrictive patterns first.
    < -40 => "Extreme Cold",
    < 0 => "Freezing",
    < 20 => "Cool",
    < 30 => "Warm",
    >= 30 => "Hot"
};



//Test: create a method that categorizes a person's age into life stages using relational patterns in a switch expression.
//      Age Categories:
//          Negative ages → "Invalid"
//          0-1 (under 2) → "Infant"
//          2-12 (under 13) → "Child"
//          13-19 (under 20) → "Teenager"
//          20-64 (under 65) → "Adult"
//          65 and above → "Senior"
public class Solution
{
    public static string CategorizeAge(int age) => age switch   //I can avoid repeating condition boundaries, it is evalued top to bottom.
    {                                                           //Every case inherits the exclusions of the cases above it.
        < 0 => "Invalid",
        < 2 => "Infant",
        < 13 => "Child",
        < 20 => "Teenager",
        < 65 => "Adult",
        >= 65 => "Senior"
    };
}