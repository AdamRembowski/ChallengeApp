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
            var employee_2 = new Employee("Agnieszka", "Sobczak");
            //act
            employee_1.AddGrade(10); employee_1.AddGrade(7); employee_1.AddGrade(3); employee_1.AddGrade(8); employee_1.AddGrade(6);
            employee_2.AddGrade(8);  employee_2.AddGrade(6); employee_2.AddGrade(5); employee_2.AddGrade(9); employee_2.AddGrade(9);
            //assert
            Assert.AreEqual(employee_1.GetStatistics().Max, 10);
            Assert.AreEqual(employee_1.GetStatistics().Min, 3);
            Assert.AreEqual(employee_1.GetStatistics().Average, 6.80000019f);

            Assert.AreEqual(employee_2.GetStatistics().Max, 9);
            Assert.AreEqual(employee_2.GetStatistics().Min, 5);
            Assert.AreEqual(employee_2.GetStatistics().Average, 7.4000001f);
        }
    }
}
