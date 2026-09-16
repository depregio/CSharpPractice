Console.WriteLine("Hello, World.");     //WriteLine=Write+enter(\n)

//Test: Console.Write
Console.Write("Programmed to work ");
Console.Write("and ");
Console.Write("not to feel.\n");

//Print literal (hard-coded) values
Console.WriteLine('b');         //This '' is for char literal. One character literal. "" is for strings.
Console.WriteLine(2);           //int literal
Console.WriteLine(0.25F);       //float literal       ~6-9 digits. The F is called a literal suffix. f works as well. 
Console.WriteLine(2.625);       //double literal    ~15-17 digits. Use float and double for approx fractions.
Console.WriteLine(12.39816m);   //decimal literal    28-29 digits. Literal suffix m. M works too. Use this for calculations.

Console.Write(true);            //bool literal
Console.Write(' ');
Console.WriteLine(false);

//Variables
string firstName;               //Declare a variable
firstName = "Bob";              //Assign (set) the variable
Console.Write(firstName);       //Retrieve the variable's value

string lastName = "Ross";       //Initialize a variable
Console.Write(' ');
Console.WriteLine(lastName);

firstName = "Liem";             //Reassign the variable
Console.WriteLine(firstName);   
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);

//Implicitly typed local variables
var message = "...Not even sure that this is real.";    //var tells the compiler that the data type is implied by the assigned value.
                                                        //It is locked in at the time of declaration and treated as the implied type.
                                                        //Therefore it must be initialized.

//Test: Display literal and variable values
string name = "William";
int messages = 3;
float temperature = 34.4f;

Console.Write("Hello ");
Console.Write(name);
Console.Write(". You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.\n");

//Escape character sequences
Console.WriteLine("Hello,\nWorld.");    //\n sequence adds a new line.
Console.WriteLine("Find\tmy voice.");   //\t sequence adds a new tab.
Console.WriteLine("Although it sounds like \"bits\" and \"bytes\".");   //\" sequence adds double quotation marks.
Console.WriteLine("My circuitry is filled with \\mites\\.");            //\\ sequence adds a backslash.

//Verbatim string literal
Console.WriteLine(@"    C:\source\repos
        (this is where your code goes)");       //A verbatim string literal will keep all whitespace and characters. Verbatim.

//Unicode escape characters
//Konnichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");     //\u sequence + its character code adds encoded characters.
                                                                //This is with UTF-16. Won't work with Win cmd.
                                                                //Different codes are needed in different applications.

//String concatenation
string username = "Bob";
string intro = "Hello";
Console.WriteLine(intro + " " + username + ".");    //Combining two or more string values into a new string value.
                                                    //Avoid intermediate variables, like this one ->
                                                    //string message = "Hello " + username; Console.WriteLine(message);

//String interpolation
Console.WriteLine($"{intro} {username}.");      //It combines string values using a template and interpolation expressions {}.

string projectName = "First-Project";
Console.WriteLine($@"    C:\Output\{projectName}\Data");    //It can be combined with verbatim literals.@$ works too.

//Test: Format and display instructions
string projectTitle = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine(@$"View English output:
  c:\Exercise\{projectTitle}\data.txt

{russianMessage}:
  c:\Exercise\{projectTitle}\ru-RU\data.txt");

//Basic operations
int sum = 7 + 5;                //Addition
int difference = 7 - 5;         //Subtraction
int product = 7 * 5;            //Multiplication
int quotient = 7 / 5;           //Division
int remainder = 7 % 5;          //Modulus

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
Console.WriteLine("Remainder: " + remainder);

int widgetsSold = 7;
Console.WriteLine("Bob sold " + widgetsSold + 7 + " widgets.");    //Numeric values here are implicitly converted to strings.
Console.WriteLine("Bob sold " + (widgetsSold + 7) + " widgets.");  //() Defines the order of operations. Add ints, then print strings.
                                                                   //It uses the PEMDAS rules for math operations except for exponents.

decimal decimalQuotient = 7m/5; //This allows the full result. The quotient and at least one of the 2 numbers must be a decimal type.
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

//Data type casting
int first = 7;
int second = 5;
decimal castedQuotient = (decimal)first / (decimal)second;  //The compiler temporarily treats the 2 values as a different data type.
Console.WriteLine(castedQuotient);

//Compound assignment operators
int value = 0;      //value is 0
value = value + 5;  //value is 5
value += 5;         //value is 10       //Addition
                            
value = 0;          //value is 0
value =value + 1;   //value is 1
value++;            //value is 2        //Increment
                            
value = 10;         //value is 10
value = value - 5;  //value is 5
value-=5;           //value is 0        //Subtraction
                            
value = 2;          //value is 2
value = value - 1;  //value is 1
value--;            //value is 0        //Decrement

value = 10;         //value is 10
value = value * 5;  //value is 50
value *= 5;         //value is 250      //Multiplication 

value = 10;         //value is 10
value = value / 5;  //value is 2
value /= 5;         //value is 1        //Division

value = 10;         //value is 10
value = value % 7;  //value is 3
value %= 2;         //value is 1        //Modulus

//Position of increment and decrement operators
int counter = 1;
counter++;
Console.WriteLine($"First: {counter}");
Console.WriteLine($"Second: {counter++}");  //counter++ retireves and uses the variable, then increments.
Console.WriteLine($"Third: {counter}");
Console.WriteLine($"Fourth: {++counter}");  //++counter increments, then retrieves and uses the variable.

//Test: Calculate Celsius given the current temperature in Fahrenheit
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32) * (5m/9m);  //Casting not needed as the second operator is a decimal already
Console.WriteLine($"The temperature is: {celsius} Celsius.");




/*
var whatType1 = (fahrenheit - 32);                //(fahrenheit - 32)                returns an int. 
var whatType1 = (fahrenheit - 32) * (5m / 9m);    //(fahrenheit - 32) * (5m / 9m)    returns a decimal.
Console.WriteLine(whatType1.GetType());
Console.WriteLine(whatType2.GetType());
*/