namespace Assignment2.Classes{
    // Inheritance inheriating the properties from the cars class
    public abstract class CarPaint : Cars{
        // Polymorphism changine the properties from what they were originally
        public abstract string Paint { get; set;}
        public override int carWheels { get; set; } = 4;

    }
}