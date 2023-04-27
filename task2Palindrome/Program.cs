using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.Write("InputString : ");
        string inputString = Console.ReadLine();
        Console.Write("TrashSymbolString : ");
        string trashSymbolString = Console.ReadLine();
        Console.WriteLine(IsPalindrome(inputString, trashSymbolString));
    }

    public static bool IsPalindrome(string inputString, string trashSymbolString)
    {
        // Convert input string to lowercase
        inputString = inputString.ToLower();

        // Iterate through each character of the string from both ends towards the middle
        for (int i = 0, j = inputString.Length - 1; i < j; i++, j--)
        {
            // If a character is found in the trash symbol string, ignore it and continue iterating
            while (i < j && trashSymbolString.Contains(inputString[i]))
            {
                i++;
            }
            while (i < j && trashSymbolString.Contains(inputString[j]))
            {
                j--;
            }

            // If two characters are found that do not match, then the string is not a palindrome
            if (inputString[i] != inputString[j])
            {
                return false;
            }
        }

        // If all characters are compared and match, then the string is a palindrome
        return true;
    }
}