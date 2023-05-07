using System.ComponentModel.Design;

public class Anagram
{
    public string Reverse(string input)
    {
        while (string.IsNullOrEmpty(input)) 
        {
            Console.WriteLine("Напиши щось:");
            input = Console.ReadLine();

            if (string.IsNullOrEmpty(input)) 
            {
                Console.WriteLine("Напиши щось:");
                input = Console.ReadLine();
                
            }     
            
        }
        
        
        const string separator = " ";
        string[] words = input.Split(separator);
        string[] reverseWords = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
            reverseWords[i] = ReverseWord(words[i]);

        return string.Join(separator, reverseWords);
    }


    public string ReverseWord(string input)
    {
        char[] chars = input.ToCharArray();

        int i = 0;
        int j = chars.Length - 1;

        while (i < j)
        {
            if (char.IsLetter(chars[i]) is false)
                i++;
            else if (char.IsLetter(chars[j]) is false)
                j--;
            else
                (chars[i], chars[j]) = (chars[j--], chars[i++]);
        }

        return new string(chars);
    }
}


