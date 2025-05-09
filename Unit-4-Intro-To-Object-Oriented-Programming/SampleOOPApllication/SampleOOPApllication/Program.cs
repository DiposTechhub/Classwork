namespace SampleOOPApllication;

class Program
{
    //Application Program will define and manipulate objects
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World CUP Drunk!");
        Person aPerson = new Person("Denzel", "95", "243.5", "50", "Male", "Green");
        Console.WriteLine(aPerson);
    }
}