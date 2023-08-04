using System.Threading.Tasks.Sources;

namespace ChallengeApp.Test
{
    public class EmployeeTests
    {
        [Test]
        public void WhenCheckAverageShouldBeNotEqualToMinAndMax()
        {
            //arrange
            var employee = new Employee("Piotr", "Kowalski");

            employee.AddScore(100);
            employee.AddScore(20);
            employee.AddScore(30);
           
            //act

            var statistics = employee.GetStatistics();
            var average = statistics.Average;
            var min = statistics.Min;
            var max = statistics.Max;
            var averageAsLetter = statistics.AverageLetter;

            //assert
            Assert.That(min, Is.Not.GreaterThanOrEqualTo(average));
            Assert.That(max, Is.GreaterThanOrEqualTo(average));
            Assert.That(Equals(average, 50f));
            Assert.That(Equals(averageAsLetter, 'C'));
        }
        [Test]
        public void WhenInputLetterShouldChangeToNumber()
        {
            //arrange
            var employee = new Employee("Piotr", "Kowalski");

            employee.AddScore('A');
            employee.AddScore('c');

            //act

            var statistics = employee.GetStatistics();
            var averageLetter = statistics.AverageLetter;
            var averageNumber = statistics.Average;

            //Assert

            Assert.That(Equals(averageNumber, 80f));
            Assert.That(Equals(averageLetter, 'A'));
        }
    }
}