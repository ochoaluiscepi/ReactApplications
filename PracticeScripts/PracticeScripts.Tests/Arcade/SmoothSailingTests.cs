using PracticeScripts.Arcade;

namespace PracticeScripts.Tests.Arcade
{
    public class SmothSailingTest
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void AllLongestStringsTest()
        {
            //Arrange
            string[] arr = new string[] { "aba", "aa", "ad", "vcd", "aba" };
            SmoothSailing thej = new SmoothSailing();
            //Act
            string[] result = thej.AllLongestStrings(arr);
            //Assert
            Assert.IsTrue(result.Length == 3);
        }
        [Test]
        public void CommonCharacterTest()
        {
            //Arrange
            string arr = "aabcc", arr2 = "adcaa";
            SmoothSailing thej = new SmoothSailing();
            //Act
            int result = thej.CommonCharacterCount(arr,arr2);
            //Assert
            Assert.IsTrue(result == 3);
        }
        [Test]
        public void IsLuckyTest()
        {
            //Arrange
            int arr = 1230;
            SmoothSailing thej = new SmoothSailing();
            //Act
            bool result = thej.IsLucky(arr);
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void SortByHeightTest()
        {
            //Arrange
            int[] arr = new int[] { -1, 150, 190, 170, -1, -1, 160, 180 };
            SmoothSailing thej = new SmoothSailing();
            //Act
            int[] result = thej.SortByHeight(arr);
            //Assert
            Assert.IsTrue(result[result.Length-1] == 190);
        }
        [Test]
        public void ReverseInParenthesesTest()
        {
            //Arrange
            string arr = "foo(bar)baz(blim)";
            SmoothSailing thej = new SmoothSailing();
            //Act
            string result = thej.ReverseInParentheses(arr);
            //Assert
            Assert.IsTrue(result == "foorabbazmilb");
        }
    }
}
