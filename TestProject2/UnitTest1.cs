namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        Anagram reverse = new Anagram();
        [TestMethod]
        public void TestMethodReverse()
        {
            string input = "пр1в3т €к спр4в1?!";
            string expected = "тв1р3п к€ врп4с1?!";         
            string actual = reverse.Reverse(input);

            Assert.AreEqual(expected, actual, "Reverse is not correct!");
        }
        [TestMethod]
        public void TestMethodReverseWord() 
        {
            string word = "ќст3р1г*!с9!";
            string expected = "сгр3т1с*!ќ9!";
            string actual = reverse.ReverseWord(word);

            Assert.AreEqual(expected, actual, "ReverseWord is not correct!");
        }
    }
}