namespace Day6___homework.Test
{
    public class Tests
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
            Assert.AreEqual(12, result);
        }

        [Test]
        public void WhenEmploeeGetAnnulScores_ShouldCorectResult()
        {
            var employee = new Employee("Piotr", "Kowalski", 33);
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddAnnualScore(30);

            var result = employee.Result;

            Assert.AreEqual(42, result);
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

            Assert.AreEqual(0, result);
        }
    }
}