using System.Net.Http.Headers;

namespace PlayingCardProject;

public class PlayingCard
{
    //***************************************************************
    // * Date for the class - Instance Data
     //*
   //  * Instance Data means every object has its own copy of the data
  //   * *
    // ***************************************************************

    private string suit;
    private string color;
    //                    Ace               Jack,Queen, King
    private int value;  // 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,
    
    //Constructor for a PlayingCard - get all the values from the user
    public PlayingCard(string suitName, string theColor, int theValue)
    {

        suit = suitName;
        value = theValue;
        color = theColor;
    }
    
    // ToString() so we can use a PlayingCard as string
    public override string ToString()
    {
        return $"Value: {value} color {color} suit{suit}";
    }
    
}

