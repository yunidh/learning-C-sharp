// for (int i = 1; i <= 100; i++)
// {
//     string result = "";
//     if (i % 3 == 0)
//     {
//         result += "Fizz";
//     }
//     if (i % 5 == 0)
//     {
//         result += "Buzz";
//     }
//     Console.WriteLine(i + "-" + result);
// }

//good for user input (do-while)

string? readResult;

do
{
    Console.Write("Enter a string: ");
    readResult = Console.ReadLine();
} while (string.IsNullOrEmpty(readResult));
Console.WriteLine("You entered " + readResult);
