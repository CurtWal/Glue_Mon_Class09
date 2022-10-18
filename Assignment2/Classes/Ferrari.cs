namespace Assignment2.Classes{
    public class Ferrari : CarPaint{
        // Polymorphism changine the properties from what they were originally
        public override string carModel { get; set;}
        public override int topSpeed { get; set; } = 211;
        public override string Paint { get; set; } 

        public void openPaintShop(){
            Console.WriteLine("Painting your car");
        }

    }
}