using System.Threading.Tasks.Sources;
using System.Xml.Schema;

namespace Day_1_Student_Class_Example;

class Program
{
    
    
    // This is an application program 
    // it instantiates and uses objects to perform processing 
    // Every application has exactly one method called Main()
    static void Main(string[] args)
    {
        Console.WriteLine("Salute Student Example");
        //Instantiate(aka define) a student object 
       // 
        // A class is data type - so you define an object of the class like any other variable with a slight difference 
        //
        // data- type name = intializer; int sum = 0
         //            is intialized using one its constructors
        //className name - new className(intailizer);
        
        //We need to be sure have all the data we want to store in our object
        //Before we intstantiate the object
        
        List<int. scores = new List<int>();
        score.Add(200);
        score.Add(345);
        score.Add(544);        
        
        // Instatiated a student using the data we want to store in the student object
        Student aStudent = new Student("Frank", scores);
            
            Console.WriteLine("aStudent: " + aStudent);
            
            
            //
            //
            aStudent.ShowStudent();
    }
}