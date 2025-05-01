namespace RedoAssessment01;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C# Assessment1");
        // To test/verify a method does what it should
        // We call it with various options
        // Call it and display what it returns
        Console.WriteLine("Calling IsTheSame(5,5) expecting true, it returns: "  + IsTheSame(5, 5));
        // Console.WriteLine("Calling IsTheSame(4,5) expecting false, it returns: " + IsTheSame(4, 5));
       
        // Test whether Subtract can handle negative, positive and zero value results
        //      as well as numbers with decimal places
        
       Console.WriteLine("Calling Subtract(4,5) expecting -1, it returns: " + Subtract(4, 5));
      // Console.WriteLine("Calling Subtract(5,4) expecting 1,  it returns: " + Subtract(5, 4));
       // Console.WriteLine("Calling Subtract(5,5) expecting 0,  it returns: " + Subtract(5, 5));
        Console.WriteLine("Calling Subtract(4.1,1.3) expecting 2.8,  it returns: " + Subtract(4.1, 1.3));
        //Console.WriteLine("Calling Subtract(5,1.5) expecting 3.5,    it returns: " + Subtract(5, 1.5));
       // Console.WriteLine("Calling Subtract(1.5, 1) expecting .5,    it returns: " + Subtract(1.5, 1));
        
        /* Test FindBuildingType using multiple values testing boundaries and between the boundaries
         
         house - 3 - max value
                 1 - min value (assumed)
                 2 - between the ranges
         office - 10 - max value
                  4  - min value 
                  8 - between the ranges    
         skyscraper - 49 - max value
                      11 - min value 
                      32 - between the ranges   
         super - 100 - max value
                  50 - min value                       
        */
        
        Console.WriteLine("Calling FindBuildingType(3) expecting house, it returns: " + FindBuildingType(3));
        Console.WriteLine("Calling FindBuildingType(1) expecting house, it returns: " + FindBuildingType(1));
        Console.WriteLine("Calling FindBuildingType(2) expecting house, it returns: " + FindBuildingType(2));
        
        Console.WriteLine("Calling FindBuildingType(10) expecting office, it returns: " + FindBuildingType(10));
        Console.WriteLine("Calling FindBuildingType(4) expecting office, it returns: " + FindBuildingType(4));
        Console.WriteLine("Calling FindBuildingType(8) expecting office, it returns: " + FindBuildingType(4));
        
       Console.WriteLine("Calling FindBuildingType(11) expecting skyscraper, it returns: " + FindBuildingType(11));
        Console.WriteLine("Calling FindBuildingType(49) expecting skyscraper, it returns: " + FindBuildingType(49));
        Console.WriteLine("Calling FindBuildingType(32) expecting skyscraper, it returns: " + FindBuildingType(32));
        
        Console.WriteLine("Calling FindBuildingType(50) expecting super, it returns: "  + FindBuildingType(50));
       Console.WriteLine("Calling FindBuildingType(100) expecting super, it returns: " + FindBuildingType(100));
        
    }  // End of Main()
    // Any methods used by Main() are defined after Main() method and before the end of the class
    
    // 1. Create a static method named IsTheSame() that returns a bool and takes in two numbers (int) as parameters.
    //
    //   To create a static method - code the word static at the start of the method
    //   Since the method will be used by Main() and Main() is static any method it uses must be static
    
    // method signature identifies the method name, what it returns and what it accepts
    //
    //     return
    //     type name(what-it-accepts) - parameters: data-type name 

        static bool IsThesame(double num)
        {
            if (num >= 65)
            {
                return true;
            }
            else if (num <= 65)
            {
                return false;
            }
       



        
        }
 //End of IsPassing

   //Create a static method named AverageGrades() that takes in 3 parameter, all double
   // grade1, grade2, grade3.
   // a This method should return the average of all grades.
     
   //  static double AverageGrades(int num1, int num2, int num3)
     
     //    List<double> AverageGrades = new List<double>(int num1, int num2, int num3);

       //  listofGrades = grade.Tolist();
         //listofGrades.Reverse;
     
}






     // static string OddOrEvenAndPassing(double num1)
      // convert the grade to an int and run it through the following conditions
      // Note: You need to reuse the IsPassing() method here.
      //  If the grade is passing and odd return "passing and odd".
      //If the grade is failing and odd return "failing and odd".
     // If the grade is passing and even return "passing and even".
     //   If the grade is failing and even return "failing and even".




    


