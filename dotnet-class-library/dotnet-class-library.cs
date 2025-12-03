// Stateful methods require creating an instance of class (object) to be called
Random dice = new();
int roll = dice.Next(1, 7);
Console.WriteLine("Dice roll:" + roll);

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine("larger value:" + largerValue);

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.Write($"Triple Dice roll: {roll1} + {roll2} + {roll3} = {total}, ");
if (total >= 15)
{
    Console.WriteLine("Wow so hero");
}
else
{
    Console.WriteLine("Poopoo zero");
}
