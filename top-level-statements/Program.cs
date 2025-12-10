using Animations;
using FakeAnimations;

if (args == null || args.Length == 0)
{
    Console.WriteLine("Error: No arguments provided, please provide text as argument");
    Environment.Exit(0);
}
foreach (var s in args)
{
    Console.Write(s);
    Console.Write(' ');
}
string[] answers =
[
    "It is certain.",
    "Reply hazy, try again.",
    "Don’t count on it.",
    "It is decidedly so.",
    "Ask again later.",
    "My reply is no.",
    "Without a doubt.",
    "Better not tell you now.",
    "My sources say no.",
    "Yes – definitely.",
    "Cannot predict now.",
    "Outlook not so good.",
    "You may rely on it.",
    "Concentrate and ask again.",
    "Very doubtful.",
    "As I see it, yes.",
    "Most likely.",
    "Outlook good.",
    "Yes.",
    "Signs point to yes.",
];

int index = new Random().Next(answers.Length - 1);

await Animations.LoadingAnimation.ShowConsoleAnimation();
FakeAnimations.LoadingAnimation.ShowConsoleAnimation();

Console.WriteLine(answers[index]);
