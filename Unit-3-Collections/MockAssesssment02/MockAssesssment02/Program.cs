namespace MockAssesssment02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Welcome to Star Wars Character!");

        //Create a static method named AddStarWarsCharacter() that take in a string[]
        // A. This method searches for and index of Yoda
        // b.   "Yoda" is not in array, return -1.

        static int AddStarWarsCharacters(string[] starWarsCharacters)
        {
            

            for (int i = 0; i < starWarsCharacters.Length; i++)
            {
                if (starWarsCharacters[i] == "Yoda")
                {
                    return i;
                }
            }

            return -1;
        }
        string[] starWarsCharactersArray = { "Leia", "obiwan", "Jarjar", "Darth", "Luke", "Yoda" };
        string[] starWarsCharactersNoYoda = { "leia", "obiwan", "jarjar", "Darth", "Luke" };

        int yodaIndex = AddStarWarsCharacters(starWarsCharactersArray);
        Console.WriteLine($"Index of Yoda in array with Yoda: {yodaIndex} - expecting 3T");

        yodaIndex = AddStarWarsCharacters(starWarsCharactersNoYoda);
        Console.WriteLine($"Index of Yoda in array without Yoda: {yodaIndex} - expecting -1F");

        //End AddStarWarCharacters
        //Create a static method named DeathStarCombat() that takes in a dictionary<string,int>
        // of star wars Characters (key) and their attack values (value)
        //Method should return the name of the jedi with the highest Attack value
        static string DeathStarCombat(Dictionary<string, int> jediDictionary)
        {
            string strongestJedi = "";
            int strongestValue = -1;

            foreach (KeyValuePair<string, int> aJedi in jediDictionary)
            {
                if (aJedi.Value > strongestValue)
                {
                    strongestJedi = aJedi.Key;
                    strongestValue = aJedi.Value;

                }
            }

            return strongestJedi;
        }

        Dictionary<string, int> jediDictionary = new Dictionary<string, int>();
        jediDictionary.Add("Luke", 700);
        jediDictionary.Add("Leia", 720);
        jediDictionary.Add("Darth", 900);
        jediDictionary.Add("Obiwan", 1000);
        jediDictionary.Add("JarJar", 2);

        string strongestJedi = DeathStarCombat(jediDictionary);
        Console.WriteLine($"The strongest Jedi is {strongestJedi} with an attack value of {jediDictionary[strongestJedi]}");
        Console.WriteLine("Expecting 'Obiwan' has an attack value of 1000");

        //End of strongest Jedi;

        //Create a static method named ConvertPlanets() takes in one parameter: an array of planets names
        //  a. The method will convert the array of planets into a list of planets in reverse order
        //  b. Return List

        static List<string> ConvertPlanets(string[] arrayOfPlanet)
        {
            // Array of planets
            string[] planets = { "Venus", "Mercury", "Earth", "Mars", "Jupiter", "Neptune", "Uranus", "Pluto" };
            Console.WriteLine("\nPlants in reverse order (expecting Pluto first and Mercury last:");
            foreach (string planet in ConvertPlanets(planets))
            {
                Console.Write(planet + " ");
            }

            //Make a list to hold said Planet to hold a return value
            List<string> listOfPlanets = new List<string>();

            listOfPlanets = arrayOfPlanet.ToList();
            listOfPlanets.Reverse();

            return listOfPlanets;
        }
        //Solution 2 process array backwards from end to start

        static List<string> CovertPlanets(string[] arrayOfPlanets)
        {

            //Define a list named Listof planets to hold a return value
            List<string> listOfPlanets = new List<string>();

            //setting i to last index and decrement i each time through the lopp

            for (int i = arrayOfPlanets.Length - 1; i >= 0; i--)
            {
                listOfPlanets.Add(arrayOfPlanets[i]); //Add current element to list 
            }

            return listOfPlanets; //Returns list with final results
        } //  End of ConvertPlanets() solution

        double evenAverage2 = AverageDroids2(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        Console.WriteLine($"Using Solution 2 - Average for even numbers is {evenAverage2} - expecting 6");



        //4.Create a static Method named AverageDriod() takes in an integer List for driods,
        // a The method will search through the list and claculate the average for all even-numbers driods
        //b Return the average

        static double AverageDroids(List<int> driods)
        {

            // Average and All Even number driods method (a)
            double evenAverage = 0;
            double evenSum = 0;
            //List method

            List<int> evenNumbers = new List<int>();

            foreach (int aNumber in driods)
            {
                if (aNumber % 2 == 0)
                {
                    evenSum = evenSum + aNumber;
                    evenNumbers.Add(aNumber);
                }

            }

            evenAverage = evenSum / evenNumbers.Count;
            return evenAverage;



        }

        // Alternate Solution
        // Create a static method named AverageDroids() takes in an integer List for droids
        //    The method will search through the list and calculate the average of all even-numbered droids. 
        //    Return the average

        double evenAverage = AverageDroids(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        Console.WriteLine($"\nUsing Solution 1 - Average for even numbers is {evenAverage} - expecting 6");




        static double AverageDroids2(List<int> droids)

        {
            List<int> evenDroidsScores = droids.Where(droidScores => droidScores % 2 == 0).ToList();
            return evenDroidsScores.Average();
        }

        //Alterante solution 
     //   static double AverageDroids3(List<int> droids)
        {
       //     return droids.Where(droidScore => droidScore % 2 == 0).ToList().Average();
        }
        //end of averagedroids()

        // 5. Create a static method named TryToCatchDarthVader().
        //    This method will take in a string as a parameter and parse that string as an integer.
        //    return “Vader Was Captured!” If the parse is successful.
        //    return “Vader Got Away!”. If FormatException is thrown.
        //    Hint: Use A Try-Catch. 

        static string TryToCatchDarthVader(string darthVader)
        {
            try
            {
                Int32.Parse(darthVader);
            }
            catch (FormatException exceptionObject)
            {
                return "Vader Got Away";
            }
           //we get here only if an Exception.   
            return "Vader Was Captured";
        } // end of trytocatchdarthvader()


        Console.WriteLine("Trying to catch Vader with invalid int string (expecting Got Away!): " +
                          TryToCatchDarthVader("R2D2"));
       // Console.WriteLine("Trying to catch Vader with invalid int string (expecting Got Away!): " +
          //                TryToCatchDarthVader("3.2"));
        Console.WriteLine("Trying to catch Vader with valid int string (expecting CapturedNo!):   " +
                          TryToCatchDarthVader("1"));
       
        // Array of planets
        string[] planets = { "Venus", "Mercury", "Earth", "Mars", "Jupiter", "Neptune", "Uranus", "Pluto" };
        Console.WriteLine("\nPlants in reverse order (expecting Pluto first and Mercury last:");
        
        
    }
}