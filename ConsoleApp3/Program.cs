using System.ComponentModel.DataAnnotations;

namespace ConsoleApp3
{
    class Anagram 
    {
        public string Reverse(string input) 
        { 
            string[]words = input.Split(' ');
            string[]reversedWords = new string[words.Length];

            for (int i = 0; i < words.Length; i++) 
            {
                reversedWords[i] = ReverseWord(words[i]);
            }
            return String.Join(" ",reversedWords);
        }
        public string ReverseWord(string word) 
        {
            char[]chars = word.ToCharArray();
            int i = 0;
            int j = chars.Length - 1;


            while (i < j) 
            {
                if (char.IsLetter(chars[i]) & char.IsLetter(chars[j]))
                {
                    char temp = chars[i];
                    chars[i] = chars[j];
                    chars[j] = temp;
                }
                else 
                {
                    i++;
                    j--;
                }
            }
            return new string(chars);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt = "FKJJJS4";

            Anagram reverse = new Anagram();

            Console.WriteLine(reverse.Reverse(txt));
        }
    }
}