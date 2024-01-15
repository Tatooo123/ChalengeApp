namespace ChallengeApp.Tests
{
    internal class TypeTests
    {
        [Test]
        public void TestReferenceType()
        {
            // arrange
            var emp1 = new Employee("Piotr", "Kowalski", 21);
            var emp2 = new Employee("Piotr", "Piotrowski", 29);

            // assert
            Assert.AreNotEqual(emp1, emp2);
            Assert.AreEqual(emp1.FirstName, emp2.FirstName);
        }

        [Test]
        public void TestStringType()
        {
            // arrange
            var name1 = "Ala";
            var name2 = "Ala";

            // assert
            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void TestIntType()
        {
            // arrange
            int number1 = 1;
            int number2 = 2;

            // assert
            Assert.AreEqual(number1 + number2, 3);
        }

        [Test]
        public void TestFloatType()
        {
            // arrange
            float number1 = 1.11F;
            float number2 = 1.11F;

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void TestDoubleType()
        {
            // arrange
            double number1 = 2.222;
            double number2 = 2.222;

            // assert
            Assert.AreEqual(number1, number2);
        }
    }
}