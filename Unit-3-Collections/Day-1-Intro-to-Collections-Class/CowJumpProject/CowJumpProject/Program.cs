namespace CowJumpProject;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome fellow Tester,Please Enter a Sentence");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(" ");

        foreach (string word in words) 
        {
            Console.WriteLine(word);
        }
        
        Console.WriteLine("Would you like to continue? (y/n)");
        while (Console.ReadLine() != "y")
        {
           Console.WriteLine("Would you like to continue? (y/n)");
        }
        
    }
    
}