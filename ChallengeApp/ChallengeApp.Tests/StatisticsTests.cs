namespace ChallengeApp.Tests
{
    public class StatisticsTests
    {
        [Test]
        public void CalculateStatistics()
        {
            // arrange
            var worker = new Employee("", "", 0);

            // act
            worker.AddPoints("A");
            worker.AddPoints(30);
            worker.AddPoints("50");
            worker.AddPoints('e');

            // assert
            var statistics = worker.GetStatistics();
            Assert.AreEqual(statistics.Minimum, 20);
            Assert.AreEqual(statistics.Maximum, 100);
            Assert.AreEqual(statistics.Average, 50);
            Assert.AreEqual(statistics.AverageLetter, 'C');
        }
    }
}
