string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(' ');
string[] reversedWords = new string[words.Length];
for (int i = 0; i < words.Length; i++)
{
    char[] alphabets = words[i].ToCharArray();
    Array.Reverse(alphabets);
    reversedWords[i] = new string(alphabets);
}

string combinedString = string.Join(" ", reversedWords);
Console.WriteLine(combinedString);
