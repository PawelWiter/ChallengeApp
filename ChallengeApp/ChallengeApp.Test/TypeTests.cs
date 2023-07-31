namespace ChallengeApp.Test
{
    public class TypeTests
    {
        //test dla INT
        [Test]
        public void WhenComparingDifferentNumbers_ShouldOneOfThemBeGreater()
        {
            //arrange
            var employee1 = GetEmployee("Piotr", "Kowalski", 33);
            var employee2 = GetEmployee("Anna", "Lewandowska", 22);
            var employee3 = GetEmployee("Zenon", "Nowak", 55);
            var employee4 = GetEmployee("Piotr", "Nowak", 66);

            //act

            //assert
            Assert.That(employee1.Age, Is.GreaterThan(employee2.Age));
            Assert.That(employee3.Age, Is.Not.GreaterThan(employee4.Age));
        }

        //Test dla typów referencyjnych
        [Test]
        public void WhenGetUserShoulReturnDifferentObject()
        {
            //arrange
            var employee1 = GetEmployee("Piotr", "Kowalski", 33);
            var employee2 = GetEmployee("Anna", "Lewandowska", 22);
            var employee3 = GetEmployee("Zenon", "Nowak", 55);
            var employee4 = GetEmployee("Piotr", "Nowak", 66);

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
            var employee1 = GetEmployee("Piotr", "Kowalski", 33);
            var employee2 = GetEmployee("Anna", "Lewandowska", 22);
            var employee3 = GetEmployee("Zenon", "Nowak", 55);
            var employee4 = GetEmployee("Piotr", "Nowak", 66);

            //act

            //assert
            Assert.That(employee1.Name, Is.EqualTo(employee4.Name));
            Assert.That(employee3.Surname, Is.EqualTo(employee4.Surname));
            Assert.That(employee2.Surname.Length, Is.GreaterThan(employee4.Surname.Length));
        }

        //test dla float
        [Test]
        public void WhenTakeMaxAndMinInFloatCouldNotBeTheSame()
        {
            //arrange

            //act

            //assert

        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}