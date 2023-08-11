namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestReferenceAndStringType()
        {
            //arrange
            var user = new Employee("Adam", "Rembowski", 37);
            string data = "Adam Rembowski";

            //act

            //assert
            Assert.AreEqual(user.Name+" "+user.Surname, data);
        }
        public void TestValueType()
        {
            //arrange
            int integer = 5;
            long longint = 5;
            float floatint = 5;
            List<int> ints = new List<int>();

            //act
            ints.Add(5);

            //assert
            Assert.AreEqual(integer, longint);
            Assert.AreEqual(longint, floatint);
            Assert.AreEqual(integer, floatint);
            Assert.AreEqual(ints[0], integer);

        }
    }
}
