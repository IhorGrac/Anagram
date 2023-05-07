using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        Anagram anagram = new Anagram();
        string reversed = anagram.Reverse(input);

        Console.WriteLine($"Результат: {reversed}");
    }
}

class Anagram
{
    public string Reverse(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return input;
        }

        string[] words = input.Split(' ');
        string[] reversedWords = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            reversedWords[i] = ReverseWord(words[i]);
        }

        return string.Join(" ", reversedWords);
    }

    private string ReverseWord(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
        {
            return word;
        }

        char[] chars = word.ToCharArray();
        int start = 0;
        int end = word.Length - 1;

        while (start < end)
        {
            if (!char.IsLetter(chars[start]))
            {
                start++;
            }
            else if (!char.IsLetter(chars[end]))
            {
                end--;
            }
            else
            {
                char temp = chars[start];
                chars[start] = chars[end];
                chars[end] = temp;
                start++;
                end--;
            }
        }

        return new string(chars);
    }
}
