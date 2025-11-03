using System;
using System.Text;
class ReverseString
{
    static void Main()
    {
        string str = "Ravi";
        StringBuilder revStr = new StringBuilder();
        for (int i = str.Length-1; i >= 0; i--)
        {
            revStr.Append(str[i]);
        }
        Console.WriteLine(revStr);
    }
}