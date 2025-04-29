namespace PlayingCardProject;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Instansiate an Ace of spades
        PlayingCard aCard = new PlayingCard("Spades", "Black&Yellow", 1);
        
        //Display our card
        Console.WriteLine(aCard);
    }
    
}