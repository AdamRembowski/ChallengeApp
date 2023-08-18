using NUnit.Framework.Internal;
using NUnit.Framework;

namespace ChallengeApp.Tests
{
    public class StatisticsTests
    {
        [Test]
        public void TestEmployeeStatistics()
        {
            //arrange
            var employee_1 = new Employee("Adam", "Rembowski");            
            //act
            employee_1.AddGrade(10); employee_1.AddGrade(7); employee_1.AddGrade(3); employee_1.AddGrade(8); employee_1.AddGrade(6);

            //assert
            Assert.AreEqual(employee_1.GetStatisticsWithForeach().Max, 10);
            Assert.AreEqual(employee_1.GetStatisticsWithForeach().Min, 3);
            Assert.AreEqual(employee_1.GetStatisticsWithForeach().Average, 6.80000019f);

            Assert.AreEqual(employee_1.GetStatisticsWtihFor().Max, 10);
            Assert.AreEqual(employee_1.GetStatisticsWtihFor().Min, 3);
            Assert.AreEqual(employee_1.GetStatisticsWtihFor().Average, 6.80000019f);

            Assert.AreEqual(employee_1.GetStatisticsWtihDoWhile().Max, 10);
            Assert.AreEqual(employee_1.GetStatisticsWtihDoWhile().Min, 3);
            Assert.AreEqual(employee_1.GetStatisticsWtihDoWhile().Average, 6.80000019f);

            Assert.AreEqual(employee_1.GetStatisticsWithWhile().Max, 10);
            Assert.AreEqual(employee_1.GetStatisticsWithWhile().Min, 3);
            Assert.AreEqual(employee_1.GetStatisticsWithWhile().Average, 6.80000019f);

        }
    }
}
