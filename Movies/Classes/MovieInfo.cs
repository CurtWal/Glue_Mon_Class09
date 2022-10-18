namespace Movies.Classes{
    public abstract class MovieInfo : Movie{
        public override int Released { get; set; } = 2012;

        public override void FavMoiveRelease(){
            Console.WriteLine($"It was released in {Released}");
        }
    }
}