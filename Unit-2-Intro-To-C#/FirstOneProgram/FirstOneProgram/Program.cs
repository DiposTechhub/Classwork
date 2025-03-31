namespace FirstOneProgram;

//This Program will ask for tghree numbers
//Add they together and display the total

//Programming Solution - Human thinking
//Identify the detailed steps

//Ask for the numbers one at a time
//Write down each numers as its given
//Add the number together create a sum/total
//Tell the rtequester the total (display)

//Now that we have the steps in our solution
//Identify any data you need for the steps 
//
//1. A place to write down each number - a variable in a program
//2. A place to hold the sum/total  - a variable in a program
//3. A way to receive the numbers  - a method in a program (object.method())
//4. A way to ask for numbers  -  a method in a program   (object.method())
//5. A way to report the sum/total - a method in a program  (object.method())

//Place the steps in the order and provide more detail if neccessary
//we need to solve the problem

//1.Ask for the numbers one at a time
//  a.Tell whomever is giving us the numbers to give us he first number
//  b. Receive the first numbber from sender
//  c. Write down the first number
//  d. Tell whatever is giving us the numbers to give me the second number
//  e. Receive the Second number
//  f. Write down the second number
//  g. Tell whatever is giving us the numbers to give me the third number
//  h. Receive the third number from sender
//  i. Write down the third number
//  
//2.Add the numbers together to create a sum/total
//  a. Add the first number to sum/total
//  b. Add the second number to sum/total
//  c. Add the third number to a sum/total

// 3.  Tell the requester the sum/total


class Program
{
    static void Main(string[] args)
    {
        /*********************************************
         * Define new data the program needs at the top of the program
         *
         * Data may be defined anywhere before its used, its easier to find
         * at top of the program
         * To define a variable: data type name = inital-value;
         *commonly used data types in C#
         *
         * int  - Numeric data that is a whole number between +/- 2 billion
         * long  - A whole number greater than +/- 2 billion
         * double - Numeric value with decimal places
         * char  - A single alpha-numeric character
         * string  - A series of alpha-numeric character  (words or sentences)
         * bool  - True or False value for condtions
         *
         * examples: 10 - int (or long)
         *           1.0  - doulbe
         *            'a' - char ( note it is enclosed in '')
         *            "some words" - string  (note it si enclosed in "")
         *
         * Variable name C# are usually spelled in camelCase
         * (camelCase means the first lettter is in lowercase all other
         * words start with upper case letter)
         *
        
         * *********************************************/
         
        // Define the variables that holds the numbers we need to add
        int number1 = 0;
        int number2= 0; 
        int number3 = 0; 
        
        
        
        
        
        
        
           
        Console.WriteLine("---Starting program---");
        // Ask for thr niumber one at time using the C# Console object
        // Which  represents the keyboard and screen
        // Console.Readline() returns a string-- cannot store in an int
        Console.WriteLine("Please enter a number:");// Asking for the number 
        string aline;   // String to hold the line of input from the keyboard
        aline = Console.ReadLine();           // Get a line from the keyboard
        // We need an int value to store our numbers
        // Console.Readline() only returns string
        // So we need to convert the string from Console.Readline() to an int
        // int.parse (string) will convert a string to an int
        number1 = int.Parse(aline);
        
        // Verify  that i got the data i expected
        // Display some words and the value recieved
        // "string" + something is called concatenation ( it sticks them together)
        Console.WriteLine("You entered: " + number1);
        
        Console.WriteLine("----Ending program---");
    }
}