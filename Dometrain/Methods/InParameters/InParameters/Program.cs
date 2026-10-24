//The in keyword

//The in keyword passes arguments by reference as read-only.
//It allows less expensive passing of large value types while guaranteeing the method cannot modify the original value.


//Basic syntax
static void Process(in int number)
{
    //number = 10;      // ERROR: Cannot modify - it's read-only!
    double x = number;  // OK: Reading is allowed
}



//Test: create a method that calculates the distance from the origin (0, 0) to a given point using an in parameter.
static double DistanceFromPoint(in double x, in double y)
{
    return Math.Sqrt( (x*x) + (y*y) );
}