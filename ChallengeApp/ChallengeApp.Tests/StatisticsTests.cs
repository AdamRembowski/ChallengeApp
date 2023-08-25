using NUnit.Framework;
namespace ChallengeApp.Tests
{
    public class StatisticsTests
    {
        [Test]
        public void TestEmployeeInFileGetStatisticsAndWriteToFile()
        {
            //arrange
            var employee = new EmployeeInFile("Adam", "Rembowski");
            //act
            var statistics = employee.GetStatistics();
            var AVG_L = statistics.AverageLetter;
            var AVG = statistics.Average;
            var Min = statistics.Min;
            var Max = statistics.Max;

            //assert
            Assert.AreEqual(AVG_L, 'C');
            Assert.AreEqual(AVG, 52.6666679f);
            Assert.AreEqual(Min, 15);
            Assert.AreEqual(Max, 100);
        }
        [Test]
        public void TestEmployeeInMemoryAddLetterGrade()
        {
            //arrange
            var employee = new EmployeeInMemory("Adam", "Rembowski");
            //act
            string input = "A";
            char inputChar = Convert.ToChar(input);
            employee.AddGrade(inputChar);
            var grade_A = employee.grades.First();
            var indexer = input.ToCharArray().Length;
            var statistics_A = employee.GetStatistics().AverageLetter;
            //assert
            Assert.AreEqual(grade_A, 100);
            Assert.AreEqual(statistics_A, 'A');
            Assert.AreEqual(inputChar, 'A');
            Assert.AreEqual(indexer, 1);
        }
        [Test]
        public void TestEmployeeInFileGetStatisticsWithReadFromFile()
        {
            //arrange
            var employee = new EmployeeInFile("Adam", "Rembowski");
            //act
            var statistics_AVG_L = employee.GetStatistics().AverageLetter;
            var statistics_AVG = employee.GetStatistics().Average;
            var statistics_Min = employee.GetStatistics().Min;
            var statistics_Max = employee.GetStatistics().Max;
            Assert.AreEqual(statistics_AVG_L, 'C');
            Assert.AreEqual(statistics_AVG, 52.6666679f);
            Assert.AreEqual(statistics_Min, 15);
            Assert.AreEqual(statistics_Max, 100);
        }
    }
}
