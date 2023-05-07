using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;

namespace Anagrams;

public class Program
{
    public static void Main(string[] args)
    {
        string input = string.Empty;

        while (string.IsNullOrEmpty(input))
        {          
            Console.WriteLine("Напиши щось:");
            input = Console.ReadLine();
        }

        Anagram reverse = new Anagram();
        var reversedInput = reverse.Reverse(input);

        Console.WriteLine(reversedInput);  
    }  
}


