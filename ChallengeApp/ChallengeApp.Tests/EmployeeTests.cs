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
            worker.AddPoints("A");
            worker.AddPoints(30.5F);
            worker.AddPoints("50");
            worker.AddPoints("-a");
            Assert.AreEqual(worker.Result, 180.5F);
            
            worker.AddPoints("-30");
            Assert.AreEqual(worker.Result, 150.5F);

            worker.AddPoints('e');
            Assert.AreEqual(worker.Result, 170.5F);
        }
    }
}