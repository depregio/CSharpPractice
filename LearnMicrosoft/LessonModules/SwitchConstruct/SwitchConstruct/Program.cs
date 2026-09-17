//The switch is best used when:
    //You have a single value (variable or expression) that you want to match against many possible values.
    //For any given match, you need to execute a couple of lines of code at most.

int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:                           //If (employeeLevel==100)
        title = "Junior Associate";
        break;                          //break is one of several ways to exit the switch before it gets to the next section.
    case 200:                           //If (employeeLevel==200)
        title = "Senior Associate";
        break;
    case 300:                           //If (employeeLevel==300)
        title = "Manager";
        break;
    case 400:                           //If (employeeLevel==400) or (employeeLevel==500)
    case 500:                           //Assigning multiple labels to a switch section
        title = "Senior Manager";
        break;
    default:                        //If none of the labels are a match, the statement list for the default case will be executed.
        title = "Associate";
        break;
}
Console.WriteLine($"{employeeName}, {title}");


//Test: rewrite if-elseif-else using a switch statement

/*
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
}
else if (product[0] == "02")
{
    type = "T-Shirt";
}
else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
}
else if (product[1] == "MN")
{
    color = "Maroon";
}
else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
}
else if (product[2] == "M")
{
    size = "Medium";
}
else if (product[2] == "L")
{
    size = "Large";
}
else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");
*/


//Becomes
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");