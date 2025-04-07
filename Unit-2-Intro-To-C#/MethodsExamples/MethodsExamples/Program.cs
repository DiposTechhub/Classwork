using System.Runtime.InteropServices.Marshalling;

namespace MethodsExamples;

class Program
{
    
    /****************************************************************************
     * Demsonstrate the use of programmer defined methods
     * 
     * A method is a program that processes data and usually returns a value
     *
     * a method starts with a method signature identifies the name of the method
     *                                                   what type of data it returns
     *                                                   what type of data it will accept for proccessing
     * 
     * Method signature :  return- tyoe Name( data-it-will-accept)
     *
     *  retrun-type - the type of data returned from the method
     *                use vid if the method does not return data
     *
     *     Name() - name of the method - method names are in pascalCase
     *                                    PascalCase - the first letter of eery word is Capitalized
     * 
     *     (data-it-will-accept) - data-typr and name of any parameters
     *
     *     parameter is a piece of data passed/given to a method for its processing 
     *****************************************************************************************************/
    //Every application has on and only one method called Main()
    //
    //
    //
    //  Main() method signature 
    // 
    //  static - indicated there can be one of this is an application
    //
    //
    //  return
    //  type  name(parameters-it-may-accept)
    //
    static void Main(string[] args) // Main is a method that reutrns nothing and receives a string[]
    {
        Console.WriteLine("Hello, World!");
        
      int mySum = Addem(4, 5);  // Send the number s 4 and 5 to addem to get the sum
      //                       Addem(0 will be executed with the numbers 4 and 5
      //                       It will return the sum
      //                        whoich will be stored in a variabe call mySum

          int yoda = 97;
          int obiWon = 420;
      //
      Console.WriteLine("The sum of 4 and 5 is: " + mySum);
      Console.WriteLine("The sum of 3 + 4and 5 is: " + Addem(3,4)); 
      Console.WriteLine("The sum of yoda and obiWon is: " + Addem(yoda,obiWon));
      Console.WriteLine("The sum of 3 and 4 is: " + Addem(3.1, 4.5));
      Console.WriteLine("The sum of 6.7 and 4.9 is: " + Addem(67, 4.9));
      
      
}   //  End of Main()
    

    //  After a method you may define other methods that method can use
    //  "Helper methods" - help a method to do perform a specific task
    //
    // Define a method to receive two numbers and return to sum
    // 
    //  If a method will be used by Main() must be static because Main() is static
    //  Any method used by main()
    //
    //  return 
    //  type name (parameters)
    //
    // Addem is a method that receives
    //
    static int Addem(int num1, int num2)
    {
        Console.WriteLine("Addem(int, int) was called with " + num1 + " " + num2);
        
        return num1 + num2; //Add the two parameters and return the sum
    }
    // return a double
   static double Addem(double num1, double num2)
    {
        Console.WriteLine("Addem(double, double) was called with " + num1 + " " + num2);
        
        return num1 + num2; //Add the two parameters and return the sum
      }
    }
    