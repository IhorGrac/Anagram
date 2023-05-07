namespace Anagrams.Tests
{
    public class AnagramTests
    {
        private readonly Anagram _anagram;

        public AnagramTests()
        {
            _anagram = new Anagram();
        }

        [Fact(DisplayName = "Reverse Method")]
        public void Reverse()
        {
            string input = "пр1в3т €к спр4в1?!";
            string expected = "тв1р3п к€ врп4с1?!";
            string actual = _anagram.Reverse(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MethodReverseWord()
        {
            string word = "ќст3р1г*!с9!";
            string expected = "сгр3т1с*!ќ9!";
            string actual = _anagram.ReverseWord(word);

            Assert.Equal(expected, actual);
        }
    }
}