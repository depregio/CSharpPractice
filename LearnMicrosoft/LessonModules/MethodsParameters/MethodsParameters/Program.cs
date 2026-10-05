//The terms 'parameter' and 'argument' are often used interchangeably.

//However, 'parameter' refers to the variable in the method signature.
//The 'argument' is the value passed when the method is called.

CountTo(5);             //Argument
Console.WriteLine();

void CountTo(int max)   //Parameter
{
    for (int i = 0; i < max; i++)
    {
        Console.Write($"{i}, ");
    }
}


//Multiple parameters of different types
int[] schedule = { 800, 1200, 1600, 2000 };
DisplayAdjustedTimes(schedule, 6, -6, "All times adjusted.");
Console.WriteLine();

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT, string endingMessage)
{
    int diff = 0;

    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for (int i = 0; i < times.Length; i++)
    {
        int newTime = (times[i] + diff) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }

    Console.WriteLine(endingMessage);
}


//Method scope
string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };  //This array is global, its scope is everywhere within this program.

DisplayStudents(students);                                  //Output:Jenna, Ayesha, Carlos, Viktor,   
DisplayStudents(new string[] { "Robert", "Vanya" });        //Output:Robert, Vanya,

void DisplayStudents(string[] students)     //The method parameter student takes precedence over the global student array.
{
    foreach (string student in students)
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}


PrintCircleArea(12);
//double circumference = 2 * pi * radius; //Variables declared inside of a method are only accessible to that method. They are limited by their scope.
PrintCircleCircumference(12);

void PrintCircleArea(int radius)
{
    double pi = 3.14159;
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}
            //Methods don't have access to variables defined within different methods. the 2 pi variables are separate entities.
void PrintCircleCircumference(int radius)
{
    double pi = 3.14159;
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

//Since the variable both pi are set to the same fixed value and used in both methods, this value is a good candidate for a global variable.
//The same can't be said for radius. It isn't a global variable, you can call the methods with different values without updating the variable each time.
double pi = 3.14159;        //Note how this pi doesn't enter in conflict with the others variable with the same name but different scope.
PrintCircleArea2(12);
PrintCircleCircumference2(24);

void PrintCircleArea2(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference2(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

//In addition, methods can call other methods
PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleInfo(int radius)
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}
Console.WriteLine();


//Passing parameters by value and by reference

//When passed, value type variables have their values copied into the method's parameters, so the original variable isn't modified.
//With reference types, the address of the value is passed into the method, so operations on that variable affect the original value.

//Remember that string is a reference type, but it is immutable, it can't be altered.
//In C#, when methods and operators modify a string, the result returned is an address to a new string object.

//Test pass by value
int a = 3;  
int b = 4;  
int c = 0;                      
                                
Multiply(a, b, c);  //c=12
Console.WriteLine($"global statement: {a} x {b} = {c}");    //c=0

void Multiply(int a, int b, int c)
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}

//Test pass by reference
int[] array = { 1, 2, 3, 4, 5 };

PrintArray(array);  //0 1 2 3 4 5
Clear(array);
PrintArray(array);  //0 0 0 0 0 0

void PrintArray(int[] array)
{
    foreach (int a in array)
    {
        Console.Write($"{a} ");
    }
    Console.WriteLine();
}

void Clear(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;       //Modifies the array directly, not the address.
    }
}

//Test with strings
string status = "Healthy";

Console.WriteLine($"Start: {status}");  //Start: Healthy
SetHealth(status, false);               //Middle: Unhealthy
Console.WriteLine($"End: {status}");    //End: Healthy

void SetHealth(string status, bool isHealthy)
{
    status = (isHealthy ? "Healthy" : "Unhealthy"); //A new string with the value "Unhealthy" is created.
    Console.WriteLine($"Middle: {status}");         //The address is lost in the method scope.
}

//To correct this, change SetHealth to use the global status variable instead.
string status2 = "Healthy";

Console.WriteLine($"Start: {status2}"); //Start: Healthy
SetHealth2(false);                      //Middle: Unhealthy
Console.WriteLine($"End: {status2}");   //End: Unhealthy

void SetHealth2(bool isHealthy)
{
    status2 = (isHealthy ? "Healthy" : "Unhealthy");    //Here you overwrite the global status variable with the new string value.
    Console.WriteLine($"Middle: {status2}");
}

/*
    Try to think of strings having the same behaviour of value types.
    
    If strings are treated like value types in this case, the value being the address, it is copied and then lost. 
    In the case of an int array the address is copied and lost too but it doesnt matter since the it isn't modified, the object itself is.
    You can't do that with strings because they are immutable.

    Methods that perform changes on a string parameter don't affect the original string.
*/


//Optional parameters
string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca", 1, "none", true);                                       //Here you may not know what "none" is referring to.
RSVP("Nadia", 2, "Nuts", true);                                         //Using named arguments can improve the readability of your code.
RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false); //Specify the parameter name followed by the argument value.
RSVP("Tony", inviteOnly: true, allergies: "Jackfruit", partySize: 1);   //Named arguments don't have to appear in the original order, unlike unnamed ones.
RSVP("Noor", 4, inviteOnly: false);         //Here optional arguments are omitted.
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

//(Répondez S'il Vous Plaît)
void RSVP(string name, int partySize, string allergies = "none", bool inviteOnly = true)   //Allergies is optional.
{                                       //By giving allergies a default value the method can use that when none are passed.
    if (inviteOnly)                     //inviteOnly is not optional but you can't write non optional parameters after declaring optional ones.
    {
        // search guestList before adding rsvp
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name))
            {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}



//Test: add a method to display email addresses
string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    // display internal email addresses
    PrintEmailAddress(firstName: corporate[i, 0], lastName: corporate[i, 1]);

}

for (int i = 0; i < external.GetLength(0); i++)
{
    // display external email addresses
    PrintEmailAddress(firstName: external[i, 0], lastName: external[i, 1], externalDomain);
}
void PrintEmailAddress(string firstName, string lastName, string domain = "contoso.com")
{
    string email = (firstName.Remove(2) + lastName).ToLower();          //Use .Remove(2) or .Substring(0, 2)
    Console.WriteLine($"{email}@{domain}");
}