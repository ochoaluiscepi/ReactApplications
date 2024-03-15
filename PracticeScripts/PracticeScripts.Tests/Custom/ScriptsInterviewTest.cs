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
        [Test]
        [TestCase(new int[] { 4,5,2,4,5,9,9,4,4 }, 4,5, false)]
        [TestCase(new int[] { 4, 5, 2, 4, 5, 9, 9, 4, 4 }, 4, 4, true)]
        [TestCase(new int[] { 4, 5, 2, 4, 5, 9, 9, 4, 4 }, 4, 3, true)]
        [TestCase(new int[] { 4, 5, 2, 4, 5, 9, 9, 4, 4 }, 9, 2, true)]
        public void BluePeopleContieneInterviewTest(int[] array, int buscar, int minimo, bool expected)
        {
            //Arrange
            ScriptsInterview thej = new ScriptsInterview();
            //Act
            bool result = thej.contiene(array, buscar,minimo);

            //Assert
            Assert.IsTrue(result == expected);
        }
        [Test]
        [TestCase(new int[] { 1,1,4 }, 3)]
        [TestCase(new int[] { 9,8 }, 1)]
        [TestCase(new int[] { 6,22,16,29,23 },23)]
        [TestCase(new int[] { 28,16,28,11,14,26,23,25,17,3,22,23,23,10},25)]
        public void BluePeopleMayorDiferenciaInterviewTest(int[] array, int expected)
        {
            //Arrange
            ScriptsInterview thej = new ScriptsInterview();
            //Act
            int result = thej.mayorDiferencia(array);

            //Assert
            Assert.IsTrue(result == expected);
        }
        [Test]
        [TestCase(new int[] { 1,3,5 }, true)]
        [TestCase(new int[] { 194,54,23,7,3,6,8}, false)]
        [TestCase(new int[] { 44,37,30,23 }, true)]
        [TestCase(new int[] { 1,8 }, true)]
        [TestCase(new int[] { 3,2,1,2,3,4,3}, true)]
        public void BluePeopleMismaDiferenciaInterviewTest(int[] array, bool expected)
        {
            //Arrange
            ScriptsInterview thej = new ScriptsInterview();
            //Act
            bool result = thej.mismaDiferencia(array);

            //Assert
            Assert.IsTrue(result == expected);
        }
    }
}