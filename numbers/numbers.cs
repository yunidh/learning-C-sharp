//Type casting to different variable type
int first = 7;
int second = 5;
Console.WriteLine($"Casting ints to decimal:{(decimal)first / (decimal)second}");

int value = 1;
Console.WriteLine($"Incrementing after:{value++}");
Console.WriteLine("Value becomes:" + value);
Console.WriteLine($"Incrementing before:{++value}");
Console.WriteLine("\nOutput for `1+1+\"Windows\"` " + 1 + 1 + " Windows");
Console.WriteLine("Output for `\"Windows\" + 1 + 1 ` + Windows " + 1 + 1);
Console.WriteLine(
    @"
This happens due to operator precedence.
Left -> Right. Num + Num = Num, String + Num = String."
);
Console.WriteLine("But we can use parenthesis to override precedence: Windows " + (1 + 1));

// Challenge: graded assignments
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

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;
Console.WriteLine("\nGraded assignments, total:");
Console.WriteLine("Sophia: " + sophiaSum);
Console.WriteLine("Nicolas: " + nicolasSum);
Console.WriteLine("Zahirah: " + zahirahSum);
Console.WriteLine("Jeong: " + jeongSum);

//Despite storing in decimal, division of ints will result in int value
decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
decimal jeongScore = (decimal)jeongSum / currentAssignments;

Console.WriteLine("\nStudent\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");
