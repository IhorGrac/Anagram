using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;

namespace Chinazes;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();

        Anagram reverse = new Anagram();
        var reversedInput = reverse.Reverse(input);

        Console.WriteLine(reversedInput);  
    }  
}


