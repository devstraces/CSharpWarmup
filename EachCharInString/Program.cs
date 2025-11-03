using System;
class EachCharInString
{
    static void Main()
    {
        string str = "ABBCEDABBFCC";

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in str)
        {
            if (charCount.Keys.Contains(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount.Add(c, 1);
            }
        }
        foreach(var a in charCount)
        {
            Console.WriteLine($"Char: {a.Key} occured {a.Value} times");
        }
    }
}