using System;
using System.Collections.Generic;  // Give me access to the systems generic collections stuff

namespace Day_2_Dictionary_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*********************************************************
             * Example use of a Dictionary with array/List value
             *********************************************************/
                
            // Ask the user for a name and a grade
            // Store them in a Dictionary
            
            // Dictionary to hold name (key) and grade (value)
            //         key     value
            //         type    type    name      = new Dictionary<key-type, value>();
            Dictionary<string, list<double>> gradeBook = new Dictionary<string, list<double>>();
            
              // Lets add 3 students - loop 3 times for-loop
              //for (int i = 0; i < 3; i++)
            
               //OR
            
               //lets add students and grade until the user indicated they are done
               //loop until the usr satifies a condition instead of a specific # of times
               // Replace the for loop with a while-loop or do-while()
               // Do we want to loop at least once? Yes - do-while loop - while
               // Is Ok to loop 0 times? Yes - while loop, No - do- while loop
               // In this case we have to ask the user at least once for some data
               // How do we want the user to let us know they are done?
               //

               string userResponse = ("");
               //double grade = 0;
               do
               {
                   // Ask the user for the student name and grade
                   Console.Write("Enter student name: ");
                   string studentName = Console.ReadLine(); // Get student name// Ask the user for the student name
                  // Console.Write("Enter grade: ");
                   // Because the user might enter a non numeric grade causing an exception
                   // We should handle the exception so the program doesnt end 
                   // With a message that will scare the human.
                   // We can use a try/catch to handle excepption
                   // When the user enters a none numeric grade:
                   //  1. ignore it  and keep going  - we are doing this
                   //   2. Give them another chance to enter it 
                   //   3. set the grade to 0.
                   //   4. 
                   //We need to define grade outside any block so it can be used by all code 
                    double grade = 0;
                    string userGrade = "";

                    try
                    {
                        // A statement inside this try block might cause an exception
                        // We need to get mulitple grades for each student and store themin a list
                        string whatTheyTyped = "";
                        while (whatTheyTyped != "end") // Loop until the user eneter "end"
                        {
                            Console.Write("Enter grade: ");
                            //Get the user input as a string in case we neeed it later
                            whatTheyTyped = Console.ReadLine();
                            if (whatTheyTyped == "end")
                            {
                                break; //exit looop - continue would be ok too
                            }

                            grade = double.Parse(whatTheyTyped); //  
                            grade.ADD(grade); // Add grades entered to the list
                            grade = Double.Parse(userGrade); // convert the user input to number 
                            // grade  = Double.Parse(Concole.Readline());
                        }
                    }
                    catch (FormatException exceptionObject) //if it throws a Formatexception.....
                    {
                        Console.WriteLine("The data enetered )(" + grade + ") is not a valid number.");
                        Console.WriteLine("The Data is ignored");
                    }

                    // Add the data to our Dictionary
                   // Dictionary[key}     = value;
                   gradeBook[studentName] = grade; // gradeBook.Add(studentName, grade) // may cause an exception
                   
                   // We need to find out if they have more students to enter
                   // We want to be sure they only enter responses we expect
                   // loop until valid response
                   //for- loop- Do we know how many times we want to loop? No
                   //while - Do we loop based on a condition? Yes - can we loop 0 times No!
                   // do- while - Do we loop based on a condition? YES- Do we need to loop at least once?
                   do
                   {
                       Console.Write("Are you done? (y/n) ");
                       // Get a response from the user and convert to lowercase
                       userResponse = Console.ReadLine().ToLower();
                       // We are checking userResponse after we get it from the user
                   } while (userResponse != "y" && userResponse != "n") ;
                   
               } while (userResponse != "y");  // loop while they are not done  ( done = "y")
             
            // Display the entrys in our Dictionary
            // Use a KeyValuePair type to get an entry from teh Dictionary
            foreach (KeyValuePair<string, listdouble> anEntry in gradeBook)
            {
                Console.WriteLine(anEntry.Key + " has a grade of ");
            }
            
            Console.WriteLine("Program finito mama see ta...");
            Console.Read();
        }
    }
}