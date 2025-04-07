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
        //a method() is a program that processes data in an object/variable
        //
        //
        //  C# provides methods to operate on strings:
        //*.Equals(string) - compare the string to left of the . to string inside () for equals
        //*.compareTO(string) - return a number indicating how the first string related to the second
        //*                     return a negative number oif first string is less than the second
        //*                     return a zero if first string is equal the second
        //*                     return a positive number if first string is greater than
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
        string string2 = "b";
       
        if (string1.CompareTo(string2) > 0)   // if the first string is greater than secind string
        { 
            Console.WriteLine("string1 is greater than string2");
                  
        }
        else
        {
            Console.WriteLine("string 1 is greater than string2");
        }

        if (string1.CompareTo(string2) < 0) // if the first string is greater than the second string
        {
            Console.WriteLine("string1 is less than string2");
        }
        else
        {
            Console.WriteLine("string 1 is not less than string2");
        }

        if (string1.CompareTo(string2) == 0) // if the first string is equal second string
        {
            Console.WriteLine("string1 is equal to string2");
        }
        else
        {
            Console.WriteLine("string 1 is not equal to string2");
        }
        
        //Some methods that process strings
        //to see a list of all methods available to an object - jut type objectname
        // .length - returns the numbers of characters in a string
        // .contains(string) - return true if the string given is inside the string
        // . substring(start- index, length) - extract characters from the string  starting at the start index
        //                                      for the numbers charactersindicated by the length.
        //                                       Start index starts at 0 not 1
         //                                      Whenever you see the word index start counting at 0
        //                                       whenever you see the position - starts counting at 1
        //                                       
        //
        //
        //
        //
        //
        //
        //                  
        //
        //
       // string1.
        //                01234567891123456789212345678931234567
        string sentence = "My name is John Doe and i drive cars";
        Console.WriteLine("There are" + sentence.Length + "characters in the sentence");
        
        bool containsJohn = sentence.Contains("John");  // true if sentence contain john
        Console.WriteLine("Does sentence contain John:" + containsJohn);
        Console.WriteLine("Does sentence contain John" + sentence.Contains("John"));
        string nameInsentence = sentence.Substring(11, 4);  //Extract the 5 charc starting at postion 12
        Console.WriteLine("Name is : " + nameInsentence);
        
        Console.WriteLine("Does sentence start with My? " +sentence.StartsWith("My"));
        Console.WriteLine("Does sentence end with John? " + sentence.EndsWith("John"));
        Console.WriteLine("Does sentence contain my?" + sentence.Contains("my"));
        Console.WriteLine("Does sentence contain C#?" + sentence.Contains("C#"));
        
        Console.WriteLine("Does sentence contain .NET?" + sentence.Contains(".NET"));
        Console.WriteLine("Results when sentence.Trim() is used to remove leading and trailing spaces");
        Console.WriteLine("Does sentence end with C#? "  + sentence.EndsWith("C#"));
        Console.WriteLine("Does sentence end with .NET? " + sentence.EndsWith(".NET"));
        
        // Sentence.trim().EndsWith("C#")
        // C# Process the statement from left to right , one operation at a time
        // When C# sse a statement with chained operations ( operations seperated by .)
        //
        //
        //1. sentence.Trim() - returns a string with the leading and trailing spaces removed
        //2. result-from-step-1.EndsWith() - return true or false depending on if string actually ends with chars
        

    } // End main ()
} // End of class program