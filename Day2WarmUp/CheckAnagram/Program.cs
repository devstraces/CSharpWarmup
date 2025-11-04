using System;
class CheckAnagram
{
    static void Main()
    {
        string str1 = "listen", str2 = "silent";
        bool isAnagram = false;
        if (str1.Length != str2.Length)
        {
            Console.WriteLine("Not Anagram");
            return;
        }
        for (int i = 0; i < str1.Length - 1; i++)
        {
            for (int j = 0; j < str1.Length; j++)
            {
                char ch = str1[j];
                for (int k = 0; k < str2.Length; k++)
                {
                    if (ch != str2[k])
                    {
                        isAnagram = false;
                    }
                    else
                    {
                        isAnagram = true;
                        continue;
                    }
                }
            }
        }
        Console.WriteLine(isAnagram);
    }
}