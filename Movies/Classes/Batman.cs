namespace Movies.Classes{
    public class Batman : MovieInfo{
        public override string Name { get; set;} = "The Dark Knight Rises";
        public override decimal Rating { get; set; } = 8.3m;
        public override decimal budget { get; set; } = 250000000m;
        public override decimal Income { get; set; } = 1000000000m;

        public override void MoneyMade(){
            decimal amount  = Income - budget;
            Console.WriteLine($"This movie made: {amount} million dollars");
        }
        public override void MovieRating(){
            Console.WriteLine($"This movie rating was: {Rating} stars");
        }
        
    }
}