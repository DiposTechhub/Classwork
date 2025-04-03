namespace StringExamples;

class Program
{
    static void Main(string[] args)
    {
        //****************************************************************
        //* Strings in c# are a special data type - they dont work like you think they should
        //* 
        //*String literals are enclosed in " "
        //*
        //* A literal is something that says what it is:  1 1.24  "BOB"
        //* String variables sometimes require special processing
        //* You cant use < > to compare strings
        //*Beware: Early versions of C# do not allow use of == with strings
        //
        //
        //  C# provides methods to operate on strings:
        //*.Equals(string) - compare the string to left of the . to string inside () for equals
        //*.compareTO(string) - return a number indicating how the first string related to the second
        //*                     return a negative number oif first string is less than the second
        //*                     return a zero if first string is equal the second
        //*                     return a postive number if first string is greater than
        //*
        //*
        //*****************************************************************
        // if ( condition) {
        //    What to do if condition is true
        // }
        // else {
        //   What to do if condition is false
        // }
        string string1 = "a";
        string string2 = "a";
       
        if (string1.CompareTo(string2) > 0)   // if these are equal
        {
                  Console.WriteLine("string1 is greater than string2");
                  
        }
        else
        {
            Console.WriteLine("they are not equ");
        }
    } // End main ()
} // End of class program