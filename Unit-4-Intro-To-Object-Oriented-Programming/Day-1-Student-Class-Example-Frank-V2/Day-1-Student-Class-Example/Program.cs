namespace Day_1_Student_Class_Example;

class Program
{
    // This is an application program - uses Objects of the class to do work
    // It instantiates and uses objects to perform processing
    // Every application has exactly one method called Main()
    
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Student Class Example");
        
    // Instantiate (define) a Student class object       
    // A class is data type
    // Define an object of a class liek any other variable with a slight difference
    
    // data-type name = initializer;  int sum = 0;
    
    // A class is instantiated with the new keyword 
    //         is initiaized using one of its constructors
    // className name = new className(initializers);
    
    // We need to be sure have all the data we want to store in our object
    // Before we instantiate the object
    List<double> scores = new List<double>();
    scores.Add(100);
    scores.Add(90);
    scores.Add(80);
    
    List<double> scores2 = new List<double>();
    scores2.Add(100);
    scores2.Add(100);
    scores2.Add(100);
    
    //defining an oject of a class is very similar to defining any other datatype
    //data
    //

    // Instantiate a Student using the data we want to store in the Student object
    // ClassName objName = new className (intial-name, initial scores)
    Student aStudent = new Student("Frank", scores);
    Student aStudent2 = new Student("Marquise", scores2);
    
    // Display the Student object we created
    // Console.WriteLine() does not now how to display an object of our class
    Console.WriteLine("aStudent: " + aStudent);
    
    // Use the Student class method to display Student class object
    //
    // object.method() <--- object oriented notations
    aStudent.ShowStudent();
    aStudent2.ShowStudent();
    
    //Define a student with no scores
    Student JohnTheStudent= new Student("JohnTheStudent");
    //JohnTheStudent.ShowStudent();
    //Add some scores to johnthestudent
    JohnTheStudent.AddScore(86.5);
    JohnTheStudent.AddScore(90.4);
    JohnTheStudent.AddScore(80.6);
    JohnTheStudent.AddScore(22.5);
    JohnTheStudent.AddScore(10.8);

    JohnTheStudent.ShowStudent();
    JohnTheStudent.AddScore(80);
    JohnTheStudent.AddScore(22);
    JohnTheStudent.AddScore(10);
    //Console.WriteLine(aStudent.studentName);

    Console.WriteLine($"The sum of scores: {JohnTheStudent.SumOfScores()}");
    Console.WriteLine($"The avg of scores: {JohnTheStudent.AverageOfScores()}");
    
    //Console.WriteLine(aStudent.studentName);
    }
}