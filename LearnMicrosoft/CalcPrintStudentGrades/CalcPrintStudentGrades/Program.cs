// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;


decimal sophiaScore = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / (decimal)currentAssignments;
decimal nicolasScore = (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5) / (decimal)currentAssignments;
decimal zahirahScore = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5) / (decimal)currentAssignments;
decimal jeongScore = (jeong1 + jeong2 + jeong3 + jeong4 + jeong5) / (decimal)currentAssignments;

Console.WriteLine($@"Student    Grade

Sophia:     {sophiaScore}   A 
Nicolas:    {nicolasScore}   B
Zahirah:    {zahirahScore}   B
Jeong:      {jeongScore}   A");

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine($"Sophia:\t\t{sophiaScore}\tA");
Console.WriteLine($"Nicolas:\t{nicolasScore}\tB");
Console.WriteLine($"Zahirah:\t{zahirahScore}\tB");
Console.WriteLine($"Jeong:\t\t{jeongScore}\tA");