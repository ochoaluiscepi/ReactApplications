using PracticeScripts.Arcade;

namespace PracticeScripts.Tests.Arcade
{
    public class ExploringTheWatersTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ArrayChangeTest()
        {
            //Arrange
            int[] arr = new int[] { 1, 1, 1};
            ExploringTheWaters thej = new ExploringTheWaters();
            //Act
            int result = thej.ArrayChange(arr);
            //Assert
            Assert.IsTrue(result == 3);
        }
        
    }
}