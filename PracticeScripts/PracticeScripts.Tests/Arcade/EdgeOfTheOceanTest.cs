using PracticeScripts.Arcade;

namespace PracticeScripts.Tests.Arcade
{
    public class EdgeOfTheOceanTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CenturyFromYearTest()
        {
            //Arrange

            int[] arr = new int[]{5, 6, -4, 2, 3, 2, -23};
            EdgeOfTheOcean thej = new EdgeOfTheOcean();
            //Act
            int result = thej.AdjacentElementsProduct(arr);
            //Assert
            Assert.IsTrue(result == 30);
        }
    }
}
