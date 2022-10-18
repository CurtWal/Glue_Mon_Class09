// See https://aka.ms/new-console-template for more information
namespace Movies.Classes{
    class Program{
        public static void Main(string[] args) {
            getMovies();
    }
    public static void getMovies(){
        Console.WriteLine("Hey you! Whats is your favorite movie?");

            string movieName = Console.ReadLine(); 

            if (movieName == "The Dark Knight Rises")
            {
                Console.WriteLine("Wow I like that movie too!!!");
                Console.WriteLine("Would you like to learn something new about your movie?");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Batman movie1 = new Batman();
                    movie1.FavMoiveRelease();
                    movie1.MoneyMade();
                    movie1.MovieRating();
                }
                else if(answer == "no")
                {
                    Console.WriteLine("Ok, GoodBye");
                }
    }else if (movieName == "Django Unchained")
            {
                Console.WriteLine("Wow I like that movie too!!!");
                Console.WriteLine("Would you like to learn something new about your movie?");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Django movie2 = new Django();
                    movie2.FavMoiveRelease();
                    movie2.MoneyMade();
                    movie2.MovieRating();
                }
                else if(answer == "no")
                {
                    Console.WriteLine("Ok, GoodBye");
                }
    }else if (movieName == "The Hunt")
            {
                Console.WriteLine("Wow I like that movie too!!!");
                Console.WriteLine("Would you like to learn something new about your movie?");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Hunt movie3 = new Hunt();
                    movie3.FavMoiveRelease();
                    movie3.MoneyMade();
                    movie3.MovieRating();
                }
                else if(answer == "no")
                {
                    Console.WriteLine("Ok, GoodBye");
                }
    }else{
        Console.WriteLine("Can't Find that Movie");
    }
    }
    }
}
