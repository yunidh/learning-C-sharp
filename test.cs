Console.WriteLine("use `dotnet run test.cs` to run this in root dir");

string name = "54321";
Console.WriteLine(name[^3..^1]);

int[] arr = [5, 4, 3, 2, 1];

Array.Sort(arr);
Array.Resize(ref arr, 3);
foreach (var element in arr)
{
    Console.WriteLine(element);
}
