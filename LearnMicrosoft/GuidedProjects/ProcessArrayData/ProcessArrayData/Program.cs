
//---------------------------CHALLENGE PROJECT---------------------------

int examAssignments = 5;

int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];

string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan",];

int[] studentScores = new int[10];      //5+5 (possible extra credits)

Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else
        continue;

    int currentScoreSum = 0;
    int currentExtraSum = 0;

    decimal currentStudentGrade = 0;
    decimal currentExtraGrade = 0;
    decimal currentExamGrade = 0;
    int averageExtra = 0;

    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            currentScoreSum += score;

        else
            currentExtraSum += score;
    }

    currentExamGrade = (decimal)currentScoreSum/examAssignments;
    currentExtraGrade = ((decimal)currentExtraSum/10)/examAssignments;
    currentStudentGrade = (currentScoreSum + (decimal)currentExtraSum / 10) / examAssignments;  //Casting applied before the 10% is calculated

    int gradedExtra = gradedAssignments-examAssignments;
    if (gradedExtra > 0)
        averageExtra = currentExtraSum / gradedExtra;

    string currentStudentLetterGrade = "";

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentExamGrade}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{averageExtra} ({currentExtraGrade} pts)");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();         //Console.ReadLine() pauses the application so that the user can review the output.


//---------------------------GUIDED PROJECT---------------------------

/*
int examAssignments = 5;

int[] sophiaScores = [90,86,87,98,100,94,90];     //Guide uses int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = [92,89,81,96,90,89];
int[] emmaScores = [90,85,87,98,68,89,89,89];
int[] loganScores = [90,95,87,88,96,96];
int[] beckyScores = [92,91,90,91,92,92,92];
int[] chrisScores = [84,86,88,90,92,94,96,98];
int[] ericScores = [80,90,100,80,90,100,80,90];
int[] gregorScores = [91,91,91,91,91,91,91];

string[] studentNames = ["Sophia","Andrew","Emma","Logan","Becky","Chris","Eric","Gregor"];

int[] studentScores = new int[10];      //5+5 (possible extra credits)

Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames) 
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;

    int currentScoreSum = 0;
    decimal currentStudentGrade = 0;
    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            currentScoreSum += score;

        else
            currentScoreSum += score / 10;
    }

    currentStudentGrade = (decimal)(currentScoreSum) / examAssignments;

    string currentStudentLetterGrade = "";

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    
    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();         //Console.ReadLine() pauses the application so that the user can review the output.
*/