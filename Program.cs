using System;
using System.Text;

class Program
{
    static void Main()
    {
        string trollComment = "This website is for losers LOL!";
        string cleanedComment = RemoveVowels(trollComment);
        Console.WriteLine(cleanedComment);
        Console.ReadKey(); 
    }

    static string RemoveVowels(string input)
    {
        StringBuilder result = new StringBuilder();

        foreach (char c in input)
        {
            if (!IsVowel(c))
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }

    static bool IsVowel(char c)
    {
        return "aeiouAEIOU".IndexOf(c) != -1;
    }
}
