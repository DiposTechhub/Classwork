﻿using System;
using System.Collections.Generic;  // Give me access to the systems generic collections stuff

namespace Day_2_Dictionary_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*********************************************************
             * Example use of a Dictionary
             *********************************************************/

            // Create a Dictionary for relate zip codes people live in
            //
            //  Key - Persons Name - Unique Id for an entry
            //  (string)
            //
            //  value - Zip Code  - data associated with Key
            //  (int)
            //
            // Syntax:   Dictionary<key-type, value-type> = new Dictionary<key-type, value-type)

         // data-type<key-type, value-type> name = new data-type<key-type, value>();  
            Dictionary<string, int> personInfo   = new Dictionary<string, int>();

            // Add some people and their zip codes
            //
            // dictionaryName[key] = value;
            //
            // dictionaryName.Add(key, value) 

            personInfo["Frank"]  = 85339;
            personInfo["Kirk"]   = 48009;
            personInfo["Spock"] = 15658;
            personInfo["Bones"]   = 49116;

            personInfo.Add("Jenna", 85339);

            // Specifying a key that already exists in the Dictionary
            // When using [], the entry for the key is update
            personInfo["Frank"] = 44143;
            // personInfo.Add("Frank", 12345); // Using .Add with an exisiting key throws an exception
            // Specifying a key that already exists in the Dictionary
            // when using .Add() an exception is thrown if key already exists
            // So to avoid this and still use .Add() check to see if teh key already
            //       exists in Dictionary and only do teh .Add if it is not
            // if the key value is NOT in the dictionary...
            if (!personInfo.ContainsKey("Frank"))
            {
                personInfo.Add("Frank", 06082);  // Add it
            }
            else // If key IS already in the Dictionary
            {
                personInfo["Frank"] = 06082;    // Update its value
            }

            Console.WriteLine("Welcome address Zip");
          // Console.WriteLine("Kirk lives in: " + personInfo["Kirk"]);

            Console.Write("Whose zip code do you want? ");
            string name = Console.ReadLine();

            try
            {
                Console.WriteLine(name + " lives in: " + personInfo[name]);
            }
            catch (KeyNotFoundException exceptionInfo)
            {
                Console.WriteLine("Error looking for: " + name);
                Console.WriteLine(exceptionInfo.Message);
            }

            // If you want to walkthrough teh entire Dictionary with a foreach
            //    You need to get all the keys in the Dictionary
            //
            // use the KeyValuePair object in the foreach
            //
            // KeyValuePair<key-type, value-type> name-for-dictionary-entry
            //
            // key value pair returns the key and associated value from the dictionary
            // 
            // .key - access the key
            // .value - access the value
            // get each key value pair and store it in the variable call anEntry

            foreach (KeyValuePair<string, int> anEntry in personInfo)
            {
                Console.WriteLine(anEntry.Key + " lives in zip code " + anEntry.Value);
            }
                 
            // Ask the user for a name and a grade
            // Store them in a dictionary 
            
            //Dictionary to hold name (key) and grand
            //             key     value
            //              key     type   name  = newDictionary<key-type, value>();
            Dictionary<string, double> gradeBook = new Dictionary<string, double>();
            
            
            // Lets add three students - loop 3x means a For loop

            for (int i = 0; i < 3; i++)
            {
                // Ask User for the student name and grade
                Console.Write("Enter student name: ");
                string studentName = Console.ReadLine(); // Get student name // Ask the user for the student name
                Console.WriteLine("Enter grade book: ");
                double grade = double.Parse(Console.ReadLine()); //Get student grade

                //Add the data to our dictionary
                // Dictionary[Key]     = value;
                gradeBook[studentName] = grade; // gradebook.Add(studentName, grade) // may cause an exception
            }
            
            // Display the entrys in our dictionary
            // Use a Key valuePair type to get a entry fro dic
            foreach (KeyValuePair<string, double> anEntry in gradeBook)
            {
                Console.WriteLine(anEntry.Key + " has a grade of " + anEntry.Value);
            }

            Console.WriteLine("Please press enter to end program...");
            Console.Read();
        }
    }
}
