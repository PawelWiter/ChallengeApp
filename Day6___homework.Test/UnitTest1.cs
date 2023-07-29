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
    }
}