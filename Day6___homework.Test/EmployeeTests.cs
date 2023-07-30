using ChallengeApp;

namespace ChallengeApp.Test
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmploeeCollectTwoScores_ShouldCorectResult()
        {
            //arrange
            var employee = new Employee("Piotr", "Kowalski", 33);
            employee.AddScore(5);
            employee.AddScore(7);

            //act
            var result = employee.Result;

            //assert
            Assert.That(result, Is.EqualTo(12));
        }

        [Test]
        public void WhenEmploeeGetAnnulScores_ShouldCorectResult()
        {
            var employee = new Employee("Piotr", "Kowalski", 33);
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddAnnualScore(30);

            var result = employee.Result;

            Assert.That(result, Is.EqualTo(42));
        }

        [Test]
        public void WhenEmploeeGetPenaltyScores_ShouldCorectResult()
        {
            var employee = new Employee("Piotr", "Kowalski", 33);
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddAnnualScore(30);
            employee.AddPenaltyScore(-42);

            var result = employee.Result;

            Assert.That(result, Is.EqualTo(0));
        }
    }
}