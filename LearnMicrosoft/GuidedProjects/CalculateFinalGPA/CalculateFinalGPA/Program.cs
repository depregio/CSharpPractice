string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1CreditHours = 3;
int course2CreditHours = 3;
int course3CreditHours = 4;
int course4CreditHours = 4;
int course5CreditHours = 3;

//End of setup

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = course1CreditHours + course2CreditHours + course3CreditHours + course4CreditHours + course5CreditHours;

int totalGrade = 0;

totalGrade += course1Grade * course1CreditHours;
totalGrade += course2Grade * course2CreditHours;
totalGrade += course3Grade * course3CreditHours;
totalGrade += course4Grade * course4CreditHours;
totalGrade += course5Grade * course5CreditHours;

decimal GPA = (decimal) totalGrade / totalCreditHours;

int leadingDigit = (int)GPA;    //Casting a fractional value will never round up the result. A 2,99 GPA will become 2.
int firstDigit = (int)(GPA * 10) % 10;
int secondDigit = (int)(GPA * 100) % 10;

/*int gpaHundreds = (int)(GPA * 100);       //This is how I would have done it. Much simpler.
GPA = (decimal)gpaHundreds / 100;*/         //Value is stored in one variable instead, ready to be used.

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t{course1Grade}\t{course1CreditHours}");
Console.WriteLine($"{course2Name}\t\t{course2Grade}\t{course2CreditHours}");
Console.WriteLine($"{course3Name}\t\t{course3Grade}\t{course3CreditHours}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t{course4CreditHours}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t{course5CreditHours}");

Console.WriteLine($"\nFinal GPA:\t\t{leadingDigit}.{firstDigit}{secondDigit}");     //Eww
//Console.WriteLine($"\nFinal GPA:\t\t{GPA}");
