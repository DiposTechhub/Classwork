namespace Day_2_For_Each_Example;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to an Example of a For-Each Loop");
        //Ask the user to enter a sentence (series of words separated by whitespace - space, tab, something you can;t see)
        //Display each word in the sentence

        Console.WriteLine("Enter Sentence");
        string sentence = Console.ReadLine(); // Get what type and put it in a string

        // .split() will extract parts of a string into an array based on characters inside ()
        string[] splitSentence = sentence.Split(" "); // Split the sentence into words

        List<string> splitSentenceList = sentence.Split("").ToList(); //Coveryt the Array to a list
        
        //Display each word in the sentence - arrayName.Length returns the number of elements
        for (int i = 0; i < splitSentence.Count; i++)
        {
            //Note: To add 1 to i and use in the string we have to put it in ()
            //    +for a string mean concatentate
            //    + for a numeric means add
            //    i+1 in the output for Writeline,
            //     it thinks I want to take the value of i and stick a 1 after it
            //    (i+1) - () indicate do this first - add 1 to i and then use it in WriteLine Output

            Console.WriteLine("Word #: " + (i + 1) + " = is:" + splitSentence[i]);
        }

        Console.WriteLine("-----foreach example result  follows -----");
// For-each loop cna also process arrays and lists
        //
        // syntax: foreach(datatype variable- name in array-or-list)
        // use the variable name inside the foreach loop to access an element in the array 
        //
        // For each goes through the array or list from start to end assisgning each element to variable
        // For -loop vs for-each
        //Both can process an array or list from begining to end
        //for-loop can start and end at any element by setting int i = and changing the condition
        //for- each  Always process from the begining to end
        //for - loop you know which element you re process by using the calue in i
        //for each you do not know what element number you are processing

        foreach (string aword in splitSentence)
        {
            Console.WriteLine(aword);
        }
        // Display all then words using a do-while loop
        //
        // do
        // {
        //   loop processing
        //  }while(condition)  // loop while the condtion is true
        //
        // We always do the loop process at least once
        //  because the condition is checked at the end of the loop process

        // Define a variable to keep track the element in the array or list we are processing 
        int currentElementNumber = 0; // In a for loop this is i

        do
        {
            Console.WriteLine("Word #: " + (currentElementNumber++) + " is " + splitSentence[currentElementNumber]);
            currentElementNumber++; // increment our index variable to move through the array or list
        } while (currentElementNumber < splitSentence.Length); // loop until we process all elements numbers
        // }  
    }
}
