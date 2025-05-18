// this is a simple example of polymorphism in C#
class vechicle
{
    public virtual void Start()
    {
        Console.WriteLine("Vehicle started");
    }

}


// runtime polymorphism example Virtual/Override
class car : vechicle
{
    public override void Start()
    {
        Console.WriteLine("Car started");
    }
}

class truck : vechicle
{
    public override void Start()
    {
        Console.WriteLine("Truck started");
    }
}

// This is an example of method overloading in C#.
// Method overloading is a feature that allows a class to have multiple methods with the same name but different parameters.
//compile polymorphism example
class calulator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }
    public string Add(string a, string b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        vechicle myVechicle = new vechicle(); // Create a vechicle object
        myVechicle.Start(); // Call the Start method (from the Vechicle class)
        car myCar = new car(); // Create a car object
        myCar.Start(); // Call the Start method (from the Car class)

        calulator calulator = new calulator(); // Create a calulator object
        int sumInt = calulator.Add(5, 10); // Call the Add method for integers
        double sumDouble = calulator.Add(5.5, 10.5); // Call the Add method for doubles
        Console.WriteLine(sumDouble);
        Console.ReadLine(); 
    }
}