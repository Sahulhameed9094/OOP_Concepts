public class MyClass
{
    string color;
    public MyClass()
    {
        color = "red";
    }


    public class car
    {
        public string color = "red";
        public car(string setColor)
        {
            color = setColor;
        }
    }

    static void Main(string[] args)
    {
        /*
        MyClass myClass = new MyClass();
        Console.WriteLine(myClass.color);
        MyClass myClass2 = new MyClass();
        myClass2.color = "blue";
        Console.WriteLine(myClass2.color);*/

        car myCar = new car("white");
        Console.WriteLine(myCar.color);

        Console.ReadKey();
    }
}