namespace Movies.Classes{
    public class Django : MovieInfo{
        public override string Name { get; set;} = "Django Unchained";
        public override decimal Rating { get; set; } = 8.4m;
        public override decimal budget { get; set; } = 100000000m;
        public override decimal Income { get; set; } = 425400000m;

        public override void MoneyMade(){
            decimal amount  = Income - budget;
            Console.WriteLine($"This movie made: {amount} million dollars");
        }
        public override void MovieRating(){
            Console.WriteLine($"This movie rating was: {Rating} stars");
        }
    }
}