//Composite formatting
string first = "Hello";
string second = "World";

string result = string.Format("{0} {1}!", first, second);   //Hello World!
Console.WriteLine(result);      //Composite formatting uses numbered placeholders within a string following a template.

Console.WriteLine("{1} {0}!", first, second);               //World Hello!
Console.WriteLine("{0} {0} {0}!", first, second);           //Hello Hello Hello!


//String interpolation
Console.WriteLine($"{first} {second}!");            //Hello World!
Console.WriteLine($"{second} {first}!");            //World Hello!
Console.WriteLine($"{first} {first} {first}!");     //Hello Hello Hello!


//Formatting currency
decimal price = 123.45m;
int discount = 50;                  //The :C format specifier prints the user currency, based on their set default language and position.
Console.WriteLine($"Price: {price:C} (Save {discount:C})");     //Price: €123,45 (Save €50,00)


//Formatting numbers
decimal measurement = 123456.78912m;//The :N format specifier prints the user standard number format, based on their set default language and position.
Console.WriteLine($"Measurement: {measurement:N} units");       //Measurement: 123.456,79 units
                                    //For more or less precision, you can add a number after the specifier. The default is 2.         
Console.WriteLine($"Measurement: {measurement:N4} units");      //Measurement: 123.456,7891 units


//Formatting percentages
decimal tax = .36785m;          //The P format specifier to format percentages and rounds to 2 decimal places. This is also based on the user's culture.
Console.WriteLine($"Tax rate: {tax:P}");   //Tax rate: 36,79%      


decimal price2 = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price2 - salePrice), price2);
yourDiscount += $"A discount of {((price2 - salePrice) / price2):P2}!";     //+= is another way of performing a string concatenation.
Console.WriteLine(yourDiscount);    //You saved €7,56 off the regular €67,55 price. A discount of 11,19%!


//Invoice number using string interpolation
int invoiceNumber = 1201;
decimal productShares = 25.4568m;   //Display the product shares with one thousandth of a share (0.001) precision
decimal subtotal = 2750.00m;        //Display the subtotal that you charge the customer formatted as currency
decimal taxPercentage = .15825m;    //Display the tax charged on the sale formatted as a percentage
decimal total = 3185.19m;           //Finalize the receipt with the total amount due formatted as currency

Console.WriteLine($"Invoice Number: {invoiceNumber}");          //Invoice Number: 1201
Console.WriteLine($"   Shares: {productShares:N3} Product");    //   Shares: 25,457 Product
Console.WriteLine($"     Sub Total: {subtotal:C}");             //     Sub Total: €2.750,00
Console.WriteLine($"           Tax: {taxPercentage:P2}");       //           Tax: 15,83%
Console.WriteLine($"     Total Billed: {total:C}");             //     Total Billed: €3.185,19


//Padding and alignment
string input = "Pad this";  
Console.WriteLine(input.PadLeft(12));   //PadLeft() adds blank spaces to the left side of the string.
                                        //The inserted number is the total amout of characters counted included the padding spaces.
Console.WriteLine(input.PadRight(12));  //PadRight() does the same but to the right.
                                        //The total string is counted, not the total of characters in a line. Keep in mind for chained paddings.

Console.WriteLine(input.PadLeft(12, '-'));  //You can overload these methods and add a filler character.
Console.WriteLine(input.PadRight(12, '-'));


string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");  //Used to show the characters' position.
Console.WriteLine(formattedLine);   // 769C  Mr. Stephen Ortega       $5,000.00



//Test: apply string interpolation to a form letter
/*
Desired output:

Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75%.

Our new product, Glorious Future offers a return of 13.13%.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75%   $55,000,000.00      
Glorious Future     13.13%   $63,000,000.00
*/
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($@"Dear {customerName},
As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.

Our new product, {newProduct} offers a return of {newReturn:P}. Given your current volume, your potential profit would be {newProfit:C}.
");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage += currentProduct.PadRight(20);       //PadRight is easier to count given the change in formatting.
comparisonMessage += $"{currentReturn:P}".PadRight(10); //\t is environment dependent
comparisonMessage += $"{currentProfit:C}\n";

comparisonMessage += newProduct.PadRight(20);
comparisonMessage += $"{newReturn:P}".PadRight(10);
comparisonMessage += $"{newProfit:C}";

Console.WriteLine(comparisonMessage);

//Official solution:
/*
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);
*/