﻿

public interface Ivechicle
{
    void StartEngine();
    void StopEngine();
    //int x;
}





class car : Ivechicle
{
    public void StartEngine()
    {
        Console.WriteLine("Car engine started.");
    }
    public void StopEngine()
    {
        Console.WriteLine("Car engine stopped.");
    }
}

class truck : Ivechicle
{
    public void StartEngine()
    {
        Console.WriteLine("Truck engine started.");
    }
    public void StopEngine()
    {
        Console.WriteLine("Truck engine stopped.");
    }
}


interface ITestInterface1
{
    void Add(int num1, int num2);
}
interface ITestInterface2 : ITestInterface1
{
    void Sub(int num1, int num2);
}

public class ImplementationClass1 : ITestInterface1
{
    //Implement only the Add method
    public void Add(int num1, int num2)
    {
        Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
    }
}

public class ImplementationClass2 : ITestInterface2
{
    //Implement Both Add and Sub method
    public void Add(int num1, int num2)
    {
        Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
    }

    public void Sub(int num1, int num2)
    {
        Console.WriteLine($"Divison of {num1} and {num2} is {num1 - num2}");
    }
}

