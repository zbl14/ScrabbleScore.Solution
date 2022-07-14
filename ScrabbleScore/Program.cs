using System;
using ScrabbleScore.Models;

namespace ScrabbleScore
{
  public class Program
  {
   public static void Main() 
   {
    Console.WriteLine("Please enter a word to see its scrabble score");
    string word = Console.ReadLine();
    int score = Scrabble.Score(word);
    switch (score)
    {
      case 0:
        Main();
        break;
      default:
        Console.WriteLine("The scrabble score for " + word + " is " + score);
        Console.WriteLine("Would you like to see another word? Y for yes, enter for quit");
        string response = Console.ReadLine();
        if (response == "Y" || response == "y")
        {
          Main();
        }
        break;
    } 
   }
  }
}
