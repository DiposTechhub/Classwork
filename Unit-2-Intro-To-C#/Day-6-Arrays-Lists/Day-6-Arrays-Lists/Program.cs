namespace Day_6_Arrays_Lists;

// This program will ask for three numbers
//      add them together and display the total

class Program
{
    static void Main(string[] args)
    {
        // Define an list to  that holds 3 numbers
        // List <datatype> name = new List<datatype>();  //Don't forget the ()
        List<int> numbers = new List<int>();   //Empty list
       // int[] number= new int[4]; // numbers.length=5; 4 is the largest allowable index
        

        // Define a variable to hold the sum of the numbers
        int sum = 0;

        Console.WriteLine("--- Starting program ---");
        
        //Normally we process a list from begining to end
        //(from the first element to last element, one at a time)
        
        //a for loop will loop through a process counting as it does so
        // a for loop is an excellent tool for processing a list from start to end
        //
        // listName.length represents the numbers of elements in the list
        //
        // index      loop as
        // start      long as the index      increment the 
        //  at 0      is not outside array   index for each loop
        // for (int i=0; i , numbers.Lenght;  i==)
        //Since our list starts of empty - we cant use .count to control our loop
        for (int i=0; i < 7;  i++) // i = 0, 0,1,2 inside loop and 3 when exit loop
        {
            Console.WriteLine("Please enter a number:  "); // Asking for the number 
            // numbers[i] = int.parse(console.Readline()))
            numbers.Add(int.Parse(Console.ReadLine()));    // get a string from keyboard
      
        }                                                  // convert it toan int  
                                                           // store iti in numbers [i]
        // Verify the array recieved the numbers correctly
        //  GO through the array one element at a time and display the element
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine("Element# " + i + numbers[i]);  //Asking for the number
                 // get a string from keyboard
                 sum = sum + numbers[i];                                                
            
        }                                                    //convert it to an int
        
        
        

        // Add the numbers together create a sum/total
        
       
        //  Tell the requester the sum/total (display)
        Console.WriteLine("The average of the numbers is: " + (double) sum / numbers.Count);

        //  Sum  / numbers.length
        //  int / int ----> intger arithemetic - divde gives two parts quotient and remainder
        //  int                                     7 / 3 - quotient=2 remainder=1 
        //  
        //  (double) sum / numbers.length
        //  convert sum
        //  to double  / int -----> floating point arithmetic
        //
        //                / convert int to double  (C# does this automatically)
        //    double    /double  ------->  floating point arithemetic
        // double (2.333333)
        //
        Console.WriteLine("--- Ending program ---");
        
    }
}