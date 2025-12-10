// string? number;
// bool loop = true;
// do
// {
//     Console.Write("Enter a number: ");
//     number = Console.ReadLine();
//     if (number == null || number.Length == 0)
//     {
//         Console.WriteLine("\nNo input detected");
//     }
//     else
//     {
//         loop = false;
//     }
// } while (loop);

// Console.WriteLine(
//     $"Readline() method returns a string, so your number {number}'s type is {number.GetType()}"
// );
// Console.WriteLine("\nWe can convert datatypes using Convert.To<datatype>()");
// int numberAsInt = Convert.ToInt32(number);
// Console.WriteLine($"Now {number} is {numberAsInt.GetType()}");

// Console.WriteLine("\nEvery object in Csharp can be converted to string using .ToString()");
// string numberAsString = numberAsInt.ToString();
// Console.WriteLine($"Now {number} is {numberAsString.GetType()}");

// // "widening conversion"->where more data is added, or a "narrowing conversion"->where data is lost
// Console.WriteLine("\nExample of widening conversion:\n");
// var value = 1.123456789123456789123456789;
// float valueAsF = (float)value;
// decimal valueAsD = (decimal)value;
// int valueI = (int)value;

// Console.WriteLine(
//     @$"{value} is of type {value.GetType()}
// It can be converted to,
// (float){valueAsF}
// (decimal){valueAsD}
// (int){valueI}
// using (<datatype>) as prefix"
// );

// Console.WriteLine("\nExample of narrowing conversion:\n");
// float value2 = 1.123123123F;
// double value2AsD = (double)value2;
// Console.WriteLine(
//     $"{value2} of type {value2.GetType()} becomes {value2AsD} of type {value2AsD.GetType()} "
// );

// Console.WriteLine("\nParse can convert string to number types");
// string first = "5";
// string second = "7";
// string sumAsString = first + second;
// Console.WriteLine($"Sum of two numbers {first} and {second} as strings: {sumAsString}");
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine($"Sum of two numbers {first} and {second} as ints, parsed: {sum}");

// Console.WriteLine("\nCasting vs Convert:\n");
// int castedInt = (int)1.5m;
// Console.WriteLine($"Casting 1.5 with (int) truncates it->" + castedInt);

// int convertedInt = Convert.ToInt32(1.5m);
// Console.WriteLine($"Convert.ToInt32(1.5) rounds it up->" + convertedInt);

Console.WriteLine(
    "\nUsing TryParse for string which might not always be in a valid format for conversion, example:\n"
);

string? measurement;
int result = 0;
do
{
    Console.Write("Enter measurements (valid number only): ");
    measurement = Console.ReadLine();
} while (!int.TryParse(measurement, out result));

Console.WriteLine($"Measurement: {result}");
if (result > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");
