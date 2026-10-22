//Logical Patterns with is, and, or, not

//These make your code more readable when comparing against compile-time constants.
//Compile-Time Constants Only: Pattern matching with is only works with values known at compile time


//The is Pattern Combinator
int number = 1;
if (number is 0 or 1) { }  // Works - 0 and 1 are compile-time constants

int min = 0;
int max = 10;
//if (number is > min and < max) { }  // Error! // Does NOT compile - variables are not constants

// For variables, use traditional operators
if (number > min && number < max) { }  // Works!


//The or Pattern Combinator
// Match if number equals any of these constant values
if (number is 1 or 2 or 3)
{
    Console.WriteLine("One, two, or three");
}

// Works with constant relational patterns
if (number is < 0 or > 100)
{
    Console.WriteLine("Out of range");
}


//The and Pattern Combinator
// Match if number is in a range (constant boundaries)
if (number is > 0 and < 10)
{
    Console.WriteLine("Between 1 and 9");
}

// Combine multiple constant conditions
if (number is >= 1 and <= 100 and not 50)
{
    Console.WriteLine("1-100, but not 50");
}


//The not Pattern Combinator
// Match if NOT equal to a constant value
if (number is not 0)
{
    Console.WriteLine("Not zero");
}

// Negate a relational pattern
if (number is not > 0)
{
    Console.WriteLine("Zero or negative");
}



//Test: Write a method that classifies an integer based on these rules using pattern matching where appropriate.
/*
    -Return "edge" if the number is 0 or 1 (use is with or)
    -Return "small positive" if the number is between 2 and 9 inclusive (use is with and)
    -Return "non-positive" if the number is not greater than 0 (use is with not)
    -Return "medium" if the number is between 10 and 100 inclusive
    -Return "large" for all other numbers 
*/
static string ClassifyNumber(int number)
{
    if (number is not >= 0)
        return "non-positive";
    else if (number is 0 or 1)
        return "edge";
    else if (number is >= 2 and <= 9)
        return "small positive";
    else if (number is >= 10 and <= 100)
        return "medium";
    else
        return "large";
}