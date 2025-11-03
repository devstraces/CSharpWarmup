using System;
using System.Text;
class CheckPalindrome
{
    static void Main()
    {
        string num = "123454321";
        StringBuilder revNum = new StringBuilder();
        for (int i = num.Length - 1; i >= 0; i--)
        {
            revNum.Append(num[i]);
        }
        if (num == revNum.ToString())
        {
            Console.WriteLine($"num: {num} is palindrome");
        }
        else
        {
            Console.WriteLine($"num: {num} is not palindrome.");
        }
    }
}