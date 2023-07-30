
namespace Day6
{
    public class User
    {
        public static string GameName = "Diablo";

        private List<int> score = new List<int>();


        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;

        }


        public string Login { get; private set; }
        public string Password { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }

        }

        public void AddScore(int number)  //metoda
    {
        this.score.Add(number);
    }
}
    //metoda to fragment kodu, który można uruchomić zarówno w klasie jak i z zewnątrz, można sterować za pomoca modyfikatorów. Może być publiczna lub  prywatne

    //KAŻDA KLASA W ODRĘBNYM PLIKU

}
