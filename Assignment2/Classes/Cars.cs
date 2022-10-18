namespace Assignment2.Classes{
    // Encapsulation because set the class/properties as public 
    public abstract class Cars{
        // Abstraction used as templates that will be derived and overriden later
        public abstract string carModel { get; set;}
        public abstract int carWheels { get; set; }
        public abstract int topSpeed { get; set; }
    }
}