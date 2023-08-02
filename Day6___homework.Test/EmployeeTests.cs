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

            var statistics = employee1.GetStatistics();
            var emp1 = employee1.GetStatistics();

            //act
            var t = emp1.Average;


            //assert
            Assert.That(0, Is.Not.GreaterThan(t));
         }
    }
}