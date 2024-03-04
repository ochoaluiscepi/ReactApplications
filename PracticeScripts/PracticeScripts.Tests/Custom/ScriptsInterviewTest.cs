using PracticeScripts.Custom;

namespace PracticeScripts.Tests.Custom
{
    public class ScriptsInterviewTest
    {


        [Test]
        public void GetGroupTest()
        {
            //Arrange
            int[] array = new int[] { 2, 4, 5, 3, 2, 6, 5, 2 };

            Dictionary<int, int> expected = new Dictionary<int, int>();
            expected[2] = 3;
            expected[4] = 1;
            expected[5] = 2;
            expected[3] = 1;
            expected[6] = 1;
            ScriptsInterview thej = new ScriptsInterview();
            //Act
            var result = thej.GetGroup(array);

            bool areEqual = result.OrderBy(kv => kv.Key).SequenceEqual(expected.OrderBy(kv => kv.Key));
            //Assert
            Assert.IsTrue(areEqual);
        }
        [Test]
        public void MostCommonTest()
        {
            //Arrange
            int[] array = new int[] { 5, 4, 3, 2, 1, 5, 4, 3, 2, 5, 4, 3, 5, 4, 5 };
            int k = 2;

            ScriptsInterview thej = new ScriptsInterview();
            //Act
            int result = thej.MostCommon(array, k);

            //Assert
            Assert.IsTrue(result == 4);
        }


        [Test]
        [TestCase(new string[] { "--Name", "nnn", "--count","9" }, -1)]
        [TestCase(new string[] { "--Name", "Luis", "--count", "101" }, -1)]
        [TestCase(new string[] { "--Name", "Ochoa","--count", "11" }, 0)]
        [TestCase(new string[] { "--help", "--Name", "SOME_NAME" }, 1)]
        [TestCase(new string[] { "--help", "--Name", "SOME_NAME","--count","15" }, 1)]
        [TestCase(new string[] { "--count", "10" }, 0)]
        [TestCase(new string[] { "--name", "luis", "--count","15", "--help" }, 1)]

        public void SparqInterviewTest(string[] array, int expected)
        {
            //Arrange
            ScriptsInterview thej = new ScriptsInterview();
            //Act
            int result = thej.SpartInterview(array);

            //Assert
            Assert.IsTrue(result == expected);
        }
    }
}