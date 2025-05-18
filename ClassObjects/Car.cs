namespace ClassObjects
{
    public class Car
    {
        string color = "red"; // feild

        public static void Main(string[] args)
        {
            Car myCar = new Car();
            Console.WriteLine(myCar.color);
            Car myCar2 = new Car();
            myCar2.color = "blue";
            Console.WriteLine(myCar2.color);
            Console.ReadKey();
        }

    }
}
