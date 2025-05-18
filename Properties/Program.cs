//Encapulation
public class Person
{

    private string name; // field


    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}



class Program 
{
    static void Main(string[] args)
    {
        Person person = new Person();
       person.Name = "John Doe"; // set the name property
        Console.WriteLine(person.Name); // get the name property
        Console.ReadKey();
    }
}