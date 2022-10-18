namespace Assignment2.Classes{
    // Inheritance inheriating the properties from the cars and CarPaint class
    public class Mclaren : CarPaint{
        // Polymorphism changine the properties from what they were originally
        public override string carModel { get; set;}
        public override int topSpeed { get; set; } = 212;
        public override string Paint { get; set; } 

        public void openPaintShop(){
            Console.WriteLine("Painting your car");
        }
        public void bestCar(){
            Console.WriteLine("Good choice, Thats the best car ever.");
        }
    }
}