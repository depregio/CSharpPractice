//Switch Expressions

//Switch expressions are a concise, expression-based alternative to switch statements.
//They return a value directly and use the => arrow syntax.


// Switch expression (concise) syntax
var value = 0;
var result = value switch
{
    0 => "zero",            //You can't do multiple instructions inside switch expressions cases.
    1 => "one",             //However, you can call a method that returns a value.
    _ => "outside binary"   // discard pattern (default)
};

//A switch expression must include all possible scenarios (risking a SwitchExpressionException), whereas a switch statement doesn’t have to be.

// Traditional switch statement (verbose)
switch (value)
{
    case 0:
        result = "zero";
        break;
    case 1:
        result = "one";
        break;
    default:
        result = "outside binary";
        break;
}


//Change a method syntax with switch expressions
//Traditional method body syntax with block body.
string GetGrade(int score)
{
    switch (score)
    {
        case 10:
            return "A+";
        case 9:
            return "A";
        default:
            return "B";
    }
}

//Expression-bodied member syntax.
//The => signifies that the entire body of the method is a single expression (in this case, a switch expression).
string GetGrade2(int score) => score switch     //An expression-bodied member (=>) returns the value of its expression, no return keyword is needed.
{
    10 => "A+",
    9 => "A",
    _ => "B"
};

//It's the same as writing this
string GetGrade3(int score)
{
    return score switch
    {
        10 => "A+",
        9 => "A",
        _ => "B"
    };
}



//Test: Create a method that converts a day number (1-7) to the corresponding day name using a switch expression.
/*
    1 = "Monday"
    2 = "Tuesday"
    3 = "Wednesday"
    4 = "Thursday"
    5 = "Friday"
    6 = "Saturday"
    7 = "Sunday"
    Any other number = "Invalid day" 
*/
static string GetDayName(int dayNumber) => dayNumber switch
{
    1 => "Monday",
    2 => "Tuesday",
    3 => "Wednesday",
    4 => "Thursday",
    5 => "Friday",
    6 => "Saturday",
    7 => "Sunday",
    _ => "Invalid day"
};
//or
static string GetDayName2(int dayNumber)
{
    return dayNumber switch
    {
        1 => "Monday",
        2 => "Tuesday",
        3 => "Wednesday",
        4 => "Thursday",
        5 => "Friday",
        6 => "Saturday",
        7 => "Sunday",
        _ => "Invalid day"
    };
}