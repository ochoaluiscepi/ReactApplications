using PracticeScripts.Arcade;

namespace PracticeScripts.Tests.Arcade
{
    public class IslandOfKnowledgeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AvoidObstaclesTest()
        {
            //Arrange
            int[] arr = new int[] { 5, 3, 6, 7, 9 };
            IslandOfKnowledge thej = new IslandOfKnowledge();
            //Act
            int result = thej.AvoidObsdtacles(arr);
            //Assert
            Assert.IsTrue(result == 4);
        }
        [Test]
        public void IsIPV4AddressTest()
        {
            //Arrange
            string arr = "192.168.1.1";
            IslandOfKnowledge thej = new IslandOfKnowledge();
            //Act
            bool result = thej.isIPV4Address(arr);
            //Assert
            Assert.IsTrue(result);
        }

    }
}
