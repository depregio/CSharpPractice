//The ref keyword

//The ref keyword allows you to pass arguments by reference, so the method can modify the original variable.


//Without ref
void Double(int x) { x = x * 2; }  //Value is copied, original unchanged.

//With ref
void DoubleRef(ref int x) { x = x * 2; }  //Reference to original variabl, the original is modified

int number = 1;

Double(number);
Console.WriteLine(number);  //1

DoubleRef(ref number);  //Call must also use ref keyword with its argument.
Console.WriteLine(number);  //2


//Classic swap pattern
static void SwapRef(ref int a, ref int b)
{
    int temp = a;  // Store first value
    a = b;         // Overwrite first with second
    b = temp;      // Set second to stored value
}

int x = 10, y = 20;
Swap(ref x, ref y);         //From here x=20, y=10
Console.WriteLine(x+" "+y); //20 10



//Test: call a swap method and return the swapped values as strings "a=n, b=m"
static string SwapAndReturn(int a, int b)
{
    Swap(ref a, ref b);
    return "a=" + a.ToString() + ", b=" + b.ToString();
}

static void Swap(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}

Console.WriteLine(SwapAndReturn(5,10));