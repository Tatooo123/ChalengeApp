namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenWorkerCollectPoints_ShouldReturnResult()
        {
            // arrange
            var worker = new Employee("Mark", "Twain", 99);

            // act & assert
            worker.AddPoints(11);
            worker.AddPoints(12);
            worker.AddPoints(13);
            Assert.AreEqual(worker.Result, 36);
            
            worker.AddPoints(-3);
            Assert.AreEqual(worker.Result, 33);

            worker.AddPoints(10);
            Assert.AreEqual(worker.Result, 43);

            worker.AddPoints(-10);
            Assert.AreEqual(worker.Result, 33);

            worker.AddPoints(-40);
            Assert.AreEqual(worker.Result, -7);
        }
    }
}