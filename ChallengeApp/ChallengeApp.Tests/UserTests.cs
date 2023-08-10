using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {
//        [SetUp]
//        public void Setup()
//        {
//        }

        [Test]
        public void WhenUserCollectSixScores_ShouldCorrectResult()
        {
            //arrange
            var user = new Employee("Adam", "Rembowski", 37);
            user.AddScore(2);
            user.AddScore(3);
            user.AddScore(4);
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(-9);
            //act

            var result = user.Result;
            //assert

            Assert.AreEqual(11, result);
        }
    }
}