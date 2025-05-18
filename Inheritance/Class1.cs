namespace Inheritance
{
    public class Vechile // base class
    {
        public string brand = "ford"; // field

        public Vechile()
        {
            Console.WriteLine("Vechile constructor called.");
        }

        public void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }

        public void brandName()
        {
            Console.WriteLine("The brand is: " + brand);
        }


    }



    public class Car : Vechile // derived class
    {
        public string name = "Wolkswangan";
        public string brand = "BMW"; // field
        public Car()
        {
            Console.WriteLine("Car constructor called.");
        }

        public void brandName()
        {
            Console.WriteLine("The brand is: " + brand);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(); // Create a myCar object
           myCar.brandName(); // Call the brandName method (from the Car class)
            Vechile vechile = new Vechile(); // Create a vechile object
            vechile.brandName(); // Call the brandName method (from the Vechile class)
            //myCar.honk(); // Call the honk method (from the Vechile class)
            myCar.honk(); // Call the honk method (from the Vechile class)
            Console.ReadKey();
        }
    }

}
