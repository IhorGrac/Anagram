namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        Anagram reverse = new Anagram();
        [TestMethod]
        public void TestMethodReverse()
        {
            string input = "��1�3� �� ���4�1?!";
            string expected = "��1�3� �� ���4�1?!";         
            string actual = reverse.Reverse(input);

            Assert.AreEqual(expected, actual, "Reverse is not correct!");
        }
        [TestMethod]
        public void TestMethodReverseWord() 
        {
            string word = "���3�1�*!�9!";
            string expected = "���3�1�*!�9!";
            string actual = reverse.ReverseWord(word);

            Assert.AreEqual(expected, actual, "ReverseWord is not correct!");
        }
    }
}