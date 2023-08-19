using NUnit.Framework.Internal;
using NUnit.Framework;
using System;

namespace ChallengeApp.Tests
{
    public class StatisticsTests
    {

        [Test]
        public void TestEmployeeAddLetterGrade()
        {
            //arrange
            var employee = new Employee("Adam", "Rembowski");
            //act
            string input = "A";
            char inputChar = Convert.ToChar(input);
            employee.AddGrade(inputChar);
            var grade_A = employee.grades[0];
            var indexer = input.ToCharArray().Length;
            var statistics_A = employee.GetStatistics().AverageLetter;
            //assert
            Assert.AreEqual(grade_A, 100);
            Assert.AreEqual(statistics_A, 'A');
            Assert.AreEqual(inputChar, 'A');
            Assert.AreEqual(indexer, 1);
        }
        [Test]
        public void TestEmployeeGetStatistics()
        {
            //arrange
            var employee = new Employee("Adam", "Rembowski");
            //act
            employee.AddGrade(100);
            employee.AddGrade(15);
            employee.AddGrade(43);
            var statistics_AVG_L = employee.GetStatistics().AverageLetter;
            var statistics_AVG = employee.GetStatistics().Average;
            var statistics_Min = employee.GetStatistics().Min;
            var statistics_Max = employee.GetStatistics().Max;
            //assert
            Assert.AreEqual(statistics_AVG_L, 'C');
            Assert.AreEqual(statistics_AVG, 52.6666679f);
            Assert.AreEqual(statistics_Min, 15);
            Assert.AreEqual(statistics_Max, 100);
        }
    }
}
