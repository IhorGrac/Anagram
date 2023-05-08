namespace Anagrams.Tests;

public class AnagramTests
{
    private readonly Anagram _anagram;

    public AnagramTests()
    {
        _anagram = new Anagram();
    }

    [Theory(DisplayName = "The method takes a string and outputs it in reverse order")]
    [InlineData("AnagR4ms!", "smRga4nA!")]
    [InlineData("g*ing t0 *daw1*", "g*nig t0 *wad1*")]
    public void ReverseMethod(string word, string expected)
    {
        string actual = _anagram.Reverse(word);

        Assert.Equal(expected, actual);
    }

    [Fact(DisplayName = "Reversed method takes invalid data and throws an exception")]
    public void ReverseWrongDataThrowException() 
    {
        Assert.Throws<ArgumentException>(() => _anagram.Reverse(string.Empty));
        Assert.Throws<ArgumentNullException>(() => _anagram.Reverse(null));
    }
}
