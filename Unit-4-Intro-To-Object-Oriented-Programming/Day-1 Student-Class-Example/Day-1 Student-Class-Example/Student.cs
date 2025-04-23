namespace Day_1_Student_Class_Example;


//internal attribute was removed so we can use the class anywhere
//public - anyone can use this class
//class - this is the definition of a classname are in PascalCase
//Student - name of the class - Classname are in PascalCase

//A class is a description of an object used in object oriented programming
// A class contains data (class member/class data and methods (class methods)
// A  class is a programmer defined data type ( much like int, string , doible , list<>)
// Becasue it is a Programmer defined data type, the programmer is responsible for:

// data in the class
// the methods that manipulates the class data 

// class can do whatever a programmer decided it should or shouldnt do 

public class Student

{
    // Define the data for our class 
    // Private indicated only member of the class can access the data 
    // private implents the object- oriented principle of Encapsulation
    //Encapsulation - class should protect the data from outside access
    //               -  only methods in the class can access the data 
    //
    //                -  Users of the class access the data using methods 
    //                - defined in the class.
    //
    // Note: The data is defined without an intial value 
    //      Class data should be intitailized in contructors
    //
    private string firstName;
    private List<int> testscores;


    // Define methods for the class 
    //One special methods for a class is called a construtor 
    // A construtor is responsible for initailizing data in a class
    // ( data should never be unintialized data in a class 

    // a constructor method is special because:
    // 1. it has no return type; not even void
    // 2. it has the same name as the class
    // 3.it may or may not receive parameters (intializers)
    // (a constructor with no parameter is called a default constructor)
    // 4. Usually public 
    //
    //  Define constructor to intialize our data with values 
    //      specified by the user
    //
    public Student(string name, List<int> Scores)
    {
        studentName = name;  // Set 
        testscores = Scores;  // set the class datat to data passed
    }
      public void ShowStudent
    {
        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("Scores: ");
    }
    
}