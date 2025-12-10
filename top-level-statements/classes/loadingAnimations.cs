namespace Animations;

public static class LoadingAnimation
{
    public static async Task ShowConsoleAnimation()
    {
        for (int i = 0; i < 20; i++)
        {
            Console.Write("| -");
            await Task.Delay(50);
            Console.Write("\b\b\b");
            Console.Write("/ \\");
            await Task.Delay(50);
            Console.Write("\b\b\b");
            Console.Write("- |");
            await Task.Delay(50);
            Console.Write("\b\b\b");
            Console.Write("\\ /");
            await Task.Delay(20);
            Console.Write("\b\b\b");
        }
        Console.WriteLine();
    }
}
