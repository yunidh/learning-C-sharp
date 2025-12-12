using System.Diagnostics.CodeAnalysis;

var fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

//If uncomment this, error (Out of bounds)
// fraudulentOrderIDs[3] = "D000";
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Length of array: {fraudulentOrderIDs.Length}");

int[] values = [1, 2, 3, 4, 5, 6];
Console.WriteLine("\nChecking odd and even with foreach loop over array:");
foreach (int value in values)
{
    if (value % 2 == 0)
    {
        Console.WriteLine($"{value} is even");
    }
    else
    {
        Console.WriteLine($"{value} is odd");
    }
}

string[] IDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
Console.WriteLine("\nDetecting fraud IDs:");
foreach (string ID in IDs)
{
    if (ID.StartsWith('B'))
    {
        Console.WriteLine(ID);
    }
}

//Array methods:

//Creating a reversed string by string->char array->reverse array->new string()
Console.WriteLine("Reversing strings");
string random = "abc123";
char[] randomArray = random.ToCharArray();
char[] reversedRandomArray = randomArray.Reverse().ToArray();

var result = new string(reversedRandomArray);

string originString = new(randomArray);
Console.WriteLine(originString);

string resultCommas = string.Join("", reversedRandomArray);
Console.WriteLine(result);
Console.WriteLine(resultCommas);

// Splitting strings
string unsplitString = "this is unsplit";
string[] splitString = unsplitString.Split(" ");
foreach (var item in splitString)
{
    Console.WriteLine(item);
}

Console.WriteLine(string.Join(" mmhmmm ", splitString));
