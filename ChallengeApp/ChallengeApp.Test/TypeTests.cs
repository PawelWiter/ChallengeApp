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
        public void WhenCheckAverageShouldBeGreaterThen0()
        {
            //arrange
            var employee1 = new Employee("Piotr", "Kowalski");
            employee1.AddScore(5);
            employee1.AddScore(7);

            var statistics1 = employee1.GetStatistics();

            //act
            float Average1 = statistics1.Average;
            float Min1 = statistics1.Min;
            float Max1 = statistics1.Max;

            //assert
            Assert.That(Min1, Is.Not.GreaterThanOrEqualTo(Average1));
            Assert.That(Max1, Is.GreaterThanOrEqualTo(Average1));

        }

        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
}