//User user1 = new User("");
//User user2 = new User("Piotr", "");
//User user3 = new User("Marek");
//User user4 = new User("Ola");

//user3.login = "Ola";

//class User
//{
//    private string login;
//    private string password;
//    private string name;

//    public User()
//    {
//        this.login = "-";
//        this.password = "-";
//        this.name = "-";
//    }
//    public User(string login)
//    {
//        this.login = "login";
//        this.password = "-";
//        this.name = "-";
//    }
//    public User(string login, string password)
//    {
//        this.login = "login";
//        this.password = "password";
//        this.name = "-";
//    }

//    //wykorzystany będzie taki konstruktor, który będzie odpowiadał temu, który będziemy ustawiać jako new
//}


//---------------------------------------------------------


//using System.Diagnostics.Contracts;

//User user1 = new User("Adam", "42352523rwd");
//User user2 = new User("Piotr", "erwwty435345");
//User user3 = new User("Marek", "32423fdfd");
//User user4 = new User("Ola", "323234sadaf");


//var name = user1.Login;

//user1.AddScore(5);

//class User
//{
//    //private string login;
//    //private string password; //usuwamy bo jest to ustawione w property

//    private int score;

//    public User(string login, string password)
//    {
//        this.Login = login;
//        this.Password = password;
//        this.score = 0;
//    }

//    //wykorzystany będzie taki konstruktor, który będzie odpowiadał temu, który będziemy ustawiać jako new

//    public string Login { get; private set; }
//        public string Password { get; private set; }


//    public void AddScore(int number)
//    {
//        //this.score = this.score + 1; to samo co poniżej
//        this.score += number;
//    }

//}
////metoda to fragment kodu, który można uruchomić zarówno w klasie jak i z zewnątrz, można sterować za pomoca modyfikatorów. Może być publiczna lub  prywatne


//---------------------------------------------------------


using Day6;

User user1 = new User("Adam", "42352523rwd");
User user2 = new User("Piotr", "erwwty435345");
User user3 = new User("Marek", "32423fdfd");
User user4 = new User("Ola", "323234sadaf");


user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);
var name = User.GameName;
var pi = Math.PI;


