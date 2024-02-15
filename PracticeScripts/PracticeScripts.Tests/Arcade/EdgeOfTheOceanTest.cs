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
        [Test]
        public void ShapeAreaTest()
        {
            //Arrange
            int area = 3;
            EdgeOfTheOcean thej = new EdgeOfTheOcean();
            //Act
            int result = thej.ShapeArea(area);
            //Assert
            Assert.IsTrue(result == 13);
        }
        [Test]
        public void MakeArrayConsecutiveTest()
        {
            //Arrange
            int[] arr = new int[] { 6, 2, 3, 8 };
            EdgeOfTheOcean thej = new EdgeOfTheOcean();
            //Act
            int result = thej.MakeArrayConsecutive(arr);
            //Assert
            Assert.IsTrue(result == 3);
        }
        [Test]
        public void AlmostIncreasingSequenceTest()
        {
            //Arrange
            int[] arr = new int[] { 1, 3, 2 };
            EdgeOfTheOcean thej = new EdgeOfTheOcean();
            //Act
            bool result = thej.AlmostIncreasingSequence(arr);
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void MatrixElementSumTest()
        {
            //Arrange
            int[][] arr = new int[][] { new int[] { 0, 1, 1, 2 },
                                        new int[] { 2, 5, 0, 0 },
                                        new int[] { 2, 1, 3, 3 } };
            EdgeOfTheOcean thej = new EdgeOfTheOcean();
            //Act
            int result = thej.MatrixElementsSum(arr);
            //Assert
            Assert.IsTrue(result ==10);
        }
    }
}
