using System;
using System.Collections.Generic;
using System.Linq;

namespace ScrabbleScore.Models
{
  public class Scrabble
  {
    public static Dictionary<int, string> pointStructure = new Dictionary<int, string>()
    {
      {1, "A, E, I, O, U, L, N, R, S, T"},
      {2, "D, G"},
      {3, "B, C, M, P" },
      {4, "F, H, V, W, Y" },
      {5, "K" },
      {8, "J, X" },
      {10, "Q, Z" }
    };
    // private static int _score;

    public static int Score(string word)
    {
      string newWord = word.ToUpper();
      int score = 0;
      for (int i = 0; i < newWord.Length; i++) 
      {
        if(pointStructure[1].Contains(newWord[i])) 
        {
          score += 1;
        }
      }
      return score;
    }

    // public static void ClearAll()
    // {
    //   _score.Clear();
    // }
  }
}