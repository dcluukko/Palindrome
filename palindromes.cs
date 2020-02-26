using System;
using System.Collections.Generic;

public class Palindrome
{
    
}


public class Program 
{
    public static void Palindrome(string userWord)
    {   
        char[] userWordArray = userWord.ToCharArray();
    
        if (userWordArray == Array.Reverse(userWordArray)) 
        {
            Console.WriteLine("Palindrome");
        }
        else 
        {
            Console.WriteLine("Not a palindrome!");
        }
    }

    public static void Main()
    {
        Console.WriteLine("Enter a word: ");
        string userWord = Console.ReadLine();
        Palindrome(userWord);
    }
}