// See https://aka.ms/new-console-template for more information
namespace Assignment2.Classes{
    class Program{
        static void Main(string[] args) {
            buyCar();
        }
        static void buyCar(){
            Console.WriteLine("Welcome, are you looking to buy a car?");
            string answer = Console.ReadLine();
            if(answer == "yes"){
             Console.WriteLine("What car are you looking for?");
             string car = Console.ReadLine();
             if(car == "mclaren"){
             Console.WriteLine("What kind of paint job are you looking for?");
             string carPaint = Console.ReadLine();
            
            Mclaren car1 = new Mclaren(){
                carModel = car,
                Paint = carPaint,
            };
                car1.bestCar();
                Console.WriteLine($"I'll be right back grabbing your: {car1.carModel}");
                Console.WriteLine($"Please just wait a little longer im now painting your {car1.carModel}: {car1.Paint}...");
                car1.openPaintShop();
                Console.WriteLine($"Here's Your {car1.Paint} colored {car1.carModel}");
                }
            else if(car == "lambo"){
             Console.WriteLine("What kind of paint job are you looking for?");
             string carPaint = Console.ReadLine();
            
            Lambo car2 = new Lambo(){
                carModel = car,
                Paint = carPaint,
            };
                Console.WriteLine($"I'll be right back grabbing your: {car2.carModel}");
                Console.WriteLine($"Please just wait a little longer im now painting your {car2.carModel}: {car2.Paint}...");
                car2.openPaintShop();
                Console.WriteLine($"Here's Your {car2.Paint} colored {car2.carModel}");
                }
            else if(car == "ferrari"){
             Console.WriteLine("What kind of paint job are you looking for?");
             string carPaint = Console.ReadLine();
            
            Ferrari car3 = new Ferrari(){
                carModel = car,
                Paint = carPaint,
            };
                Console.WriteLine($"I'll be right back grabbing your: {car3.carModel}");
                Console.WriteLine($"Please just wait a little longer im now painting your {car3.carModel}: {car3.Paint}...");
                car3.openPaintShop();
                Console.WriteLine($"Here's Your {car3.Paint} colored {car3.carModel}");
                }
             }
             
            }
            
        }
    }

