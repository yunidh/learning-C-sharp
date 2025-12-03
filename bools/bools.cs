// Console.WriteLine("Check if this is greater than that:");
// Console.Write("this: ");
// int value1 = int.Parse(Console.ReadLine());
// Console.Write("that: ");
// int value2 = int.Parse(Console.ReadLine());
// bool greater = true ? value1 > value2 : false;
// if (greater)
// {
//     Console.WriteLine("yes");
// }
// else
// {
//     Console.WriteLine("no");
// }

int saleAmount = 1001;

// int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

//code blocks that are 1 line long can omit curly braces, testing that feature here with single line if blocks
int[] numbers = [4, 8, 15, 16, 23, 42];
bool found = false;
int total = 0;
foreach (int number in numbers)
{
    total += number;

    if (number == 42)
        found = true;
}
if (found)
    Console.WriteLine("Set contains 42");
Console.WriteLine($"Total: {total}");
