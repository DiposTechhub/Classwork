namespace Day_1_Student_Class_Example;

// internal attribute was removed so we can use the class anywhere

// public - anyone can use this class
// class - this is the definition of a C# class
// Student - name of the class - Classname are in PascalCase

// A class is a description of an object used in object oriented programming
// A class contains data (class member/class data and methods (class methods)
// A class is a programmer defined data type (much like int, string, double, List<>)
// Because it is a PROGRAMMER defined data type, the programmer is responsible for:
//
//     the data in the class
//     the methods that manipulate the class data (behaviors of the object)
//
//  class can do whatever a programmer decides it should or shouldn't do
//  public is used so any one can instantiate objects of the class
//
//
//
//This class is 
//
public class Student
{
    // Define the data for our class
    // private indicates only members of the class can access the data
    // private implements the Object-Oriented principle of Encapsulation
    // Encapsulation - class should protect the data from outside access
    //                 only methods in the class can access the data
    //
    //                 Users of the class access the data using methods
    //                 defined in the class.
    //
    // Note: The data is defined without an initial value
    //       Class data should be initialized in constructors
    private string    studentName;
    private List<double> testScores;
    
    // Define methods for the class
    
    // One special methods for a class is called a constructor
    // A constructor is responible for initializingthe data in a class
    // (data should never be uninitialized - the starting value needs to be known)
    
    // a constructor method is special because:
    //
    //   1. it has no return type; not even void
    //   2. it has the same name as the Class
    //   3. it may or may not receive parameters (initializers)
    //      ( a constructor with no parameters is called a default constructor)
    //   4. Usually public 
    
    // Define a constructor to initialize our data with values 
    //          specified by the user
    //
    //As the class designer You decide what you need to properly intialize objects of the class
    // You decide how constructors you need or how users of the class can intailize your objects
    
    // Default value is a value used when the real value is known
    //Do we want to allow an object with default values?
    //  Does it make sense to have defult student name and default scores?
    //  No - dont code a default contstrutor to intialize with default values
    //  Yes - code a 0- arg contstructor to assign defult values : public student
    
    //Do we want to allow storing the student name with scores?
    // Yes- Code a 1-arg constructor that takes a name and assign it studentname
    //                                        and assigns an emptylist         to testScores
    
    //****************************************************************************
       //  Contructors  Allow users to create object and intialize
    //****************************************************************************
    public Student(string theName)
    {
        studentName = theName;  // Assign the name passed to the constutor to our studentName
        testScores = new List<double>(); //Define and assign an empty List to testscores
    }
    
    public Student(string name, List<double> scores) 
        // 2 arguement construtor- //
        // two parameters used to intialize object
    {
        studentName = name;  // Set the class data to the data passed in from the user
        testScores = scores; // Set the class data to the data passed in from the user
    }
    
    //*******************************************************************************
    //  *Methods to manipulate the class
    //********************************************************************************/
    // Provide a method to display our data
    // (Console.WriteLine() doesn't know how to do it)
    /// Method signature : acess return
    ///                     type   type    MethodName(parameters)
    /// Method body: inside {} following method signature
    ///
    public void AddScore(double score) // Accept a score and return nothing 
    {
        testScores.Add(score);
    }
    
    // Allow the user to get the sum of the scores
    // Need a method to add up the scores and return to 
    public double SumOfScores() // No args are needed as we have access to all the data we need in class
    {
       
        // Define a variable to hold what we returning 
        double sum = 0;
        
        //Two ways we can do this: 1. Use a for loop
        //                         2. See if there a method for list that do the sum for us
        //      There seem to be a method we could use, but it looks complicated)
        // We will use a foreach loop
        foreach (double score in testScores)
        {
            sum = sum + score;  // sum += scores is OK Too
        }
        //return the variable with the result 
        return sum;
    }
    //Method compute averageg score for user 
    public double AverageOfScores()
    {
        return SumOfScores() / testScores.Count;  //Using a class method inside another class method
    }
    
    public void ShowStudent()
    {
        Console.WriteLine("\nName: " + studentName);
        Console.Write("Scores: ");

        foreach (double score in testScores)
        {
            Console.Write(score + "      ");  //Display on same line
        }
    }
    
}