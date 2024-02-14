using PracticeScripts.Arcade;

namespace PracticeScripts.Tests.Arcade
{
    public class TheJourneyBegginsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CenturyFromYearTest()
        {
            //Arrange
            int year = 1907;
            TheJourneyBeggins thej = new TheJourneyBeggins();
            //Act
            int result = thej.CenturyFromYear(year);
            //Assert
            Assert.IsTrue(result == 20);
        }
        [Test]
        public void AddTest()
        {
            //Arrange
            TheJourneyBeggins thej = new TheJourneyBeggins();
            //Act
            int result = thej.Add(10,15);
            //Assert
            Assert.IsTrue(result == 25);
        }
        [Test]
        public void CheckPalindromeTest()
        {
            //Arrange
            TheJourneyBeggins thej = new TheJourneyBeggins();
            //Act
            bool result = thej.CheckPalindrome("anitalavalatina");
            //Assert
            Assert.IsTrue(result);
        }
    }
}