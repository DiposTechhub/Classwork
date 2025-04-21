using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace ShoppingList;

internal class Program
{
    static void Main(string[] args)
    {
        // Location of 8 items!

        Dictionary<string, double> shoppingList = new Dictionary<string, double>();

        //Add 8 items names and prices
        //   Name[key] =   value

        shoppingList["Hair Pick"] = 9.99;
        shoppingList["Shoes"] = 49.99;
        shoppingList["Hat"] = 19.26;
        shoppingList["Towel"] = 11.99;
        shoppingList["Shorts"] = 7.99;
        shoppingList["Hoodie"] = 52.99;
        shoppingList["Blanket"] = 10.99;
        shoppingList["Candy"] = 3.99;
        shoppingList["Available"] = 0.00;
        
        shoppingList["Towel"] = 2.99;
        shoppingList.Add("PirateBooty", 45.99);
        //dictionaryName.Add( key, value)  throws and error/exception
        //ShoppingList.Add

        if (!shoppingList.ContainsKey("Hair Pick"))
        {
            shoppingList.Add("Hair Pick", 9.99); //Add it

        }
        else // if Key/shoppinglist Is already in the dictionary
        {
            shoppingList["Hair Pick"] = 9.99; //update its value

        }

        Console.WriteLine("Shoppinglist items are ready : " + shoppingList["Available"]);

        Console.WriteLine("Which list item would you like?");
        string name = Console.ReadLine();

        try
        {
            Console.WriteLine(shoppingList + " is priced at: " + shoppingList[name]);
        }
        catch (KeyNotFoundException exceptionInfo)
        {
            Console.WriteLine("Item is not in shopping list: " + name);
            Console.WriteLine(exceptionInfo.Message);
        }

        //key value pair returns the key and associated value from the dictionary/Map
        //.key- access the key
        //.value - access the value
        //Get  key and value pair and store it in a variable called AnEntry! 

        foreach (KeyValuePair<string, double> anEntry in shoppingList)
        {
            Console.WriteLine(anEntry.Key + ": item price is  " + anEntry.Value);
        }

        //Ask user for item and display price
        //        key       value
        //          type       type    name       = new dictionary<key- type,  value();
        Dictionary<string, double> shoppingList2 = new Dictionary<string, double>();

        for (int i = 0; i < 3; i++)


            //Ask user for item name and price!
            Console.WriteLine(" Enter shopping item: ");
        string item = Console.ReadLine();
        Console.WriteLine("Enter Item Price");
        double price = double.Parse(Console.ReadLine());
        

        shoppingList2[item] = price; // shoppingList2.ADD(shoppingListnName, price)

        //Using Keyvaluepair type to get an entry from Dictionary
        foreach (KeyValuePair<string, double> anEntry in shoppingList2)
        {


    Console.WriteLine(anEntry.Key + ": item is in list for " + anEntry.Value);
       }


       Console.WriteLine("Please Press Enter to end program");
        Console.ReadLine();

    }

}


      
    
       
       
       
       
       
    
