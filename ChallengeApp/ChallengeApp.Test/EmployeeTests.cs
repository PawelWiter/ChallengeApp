namespace ChallengeApp.Test
{
    public class EmployeeTests
    {
        [Test]
        public void WhenCheckAverageShouldBeGreaterThen0()
        {
            //arrange
            var employee1 = new Employee("Piotr", "Kowalski", 33);
            employee1.AddScore(5);
            employee1.AddScore(7);

            var statistics1 = employee1.GetStatistics();

            //act
            var Average1 = statistics1.Average;
            var Min1 = statistics1.Min;
            var Max1 = statistics1.Max;

            //assert
            Assert.That(Min1, Is.Not.GreaterThanOrEqualTo(Average1));
            Assert.That(Max1, Is.GreaterThanOrEqualTo(Average1));
        }
    }
}