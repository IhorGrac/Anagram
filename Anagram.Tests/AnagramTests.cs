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
            string input = "��1�3� �� ���4�1?!";
            string expected = "��1�3� �� ���4�1?!";
            string actual = _anagram.Reverse(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MethodReverseWord()
        {
            string word = "���3�1�*!�9!";
            string expected = "���3�1�*!�9!";
            string actual = _anagram.ReverseWord(word);

            Assert.Equal(expected, actual);
        }
    }
}