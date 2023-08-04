namespace ChallengeApp.Test
{
    public class TypeTests
    {
        //Test dla typów referencyjnych
        [Test]
        public void WhenGetUserShoulReturnDifferentObject()
        {
            //arrange
            var employee1 = GetEmployee("Piotr", "Kowalski");
            var employee2 = GetEmployee("Anna", "Lewandowska");
            var employee3 = GetEmployee("Zenon", "Nowak");
            var employee4 = GetEmployee("Piotr", "Nowak");

            //act

            //assert
            Assert.That(employee2, Is.Not.EqualTo(employee1));
            Assert.That(employee4, Is.Not.EqualTo(employee3));
        }

        //test dla String
        [Test]
        public void WhenTakeDetailOfUserInStringCouldBeTheSame()
        {
            //arrange
            var employee1 = GetEmployee("Piotr", "Kowalski");
            var employee2 = GetEmployee("Anna", "Lewandowska");
            var employee3 = GetEmployee("Zenon", "Nowak");
            var employee4 = GetEmployee("Piotr", "Nowak");

            //act

            //assert
            Assert.That(employee1.Name, Is.EqualTo(employee4.Name));
            Assert.That(employee3.Surname, Is.EqualTo(employee4.Surname));
            Assert.That(employee2.Surname.Length, Is.GreaterThan(employee4.Surname.Length));
        }

        //test dla float
        [Test]
        public void WhenTypeNumbersShoudGetLetterAverage()
        {
            //arrange
            var employee = new Employee("Piotr", "Kowalski");
            employee.AddScore('B');
            employee.AddScore('b');

            var statistics = employee.GetStatistics();
  
            //act
            float average = statistics.Average;
            float min = statistics.Min;
            float max = statistics.Max;

            //assert
            Assert.That(Equals(average, 80f));
        }

        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
}