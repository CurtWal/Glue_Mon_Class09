namespace Movies.Classes{
    public abstract class Movie{
        public abstract string Name { get; set;}
        public abstract decimal Rating { get; set; }
        public abstract int Released { get; set; }
        public abstract decimal budget { get; set; }
        public abstract decimal Income { get; set; }

        public abstract void FavMoiveRelease();
        public abstract void MoneyMade();
        public abstract void MovieRating();
    }
}