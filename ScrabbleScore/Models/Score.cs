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

    public static int Score(string word)
    {
      if (word == null) return 0;
      string newWord = word.ToUpper().Trim();
      int score = 0;
      for (int i = 0; i < newWord.Length; i++) 
      {
        if(pointStructure[1].Contains(newWord[i])) 
        {
          score += 1;
        }
        else if (pointStructure[2].Contains(newWord[i]))
        {
          score += 2;
        }
        else if (pointStructure[3].Contains(newWord[i]))
        {
          score += 3;
        }
        else if (pointStructure[4].Contains(newWord[i]))
        {
          score += 4;
        }
        else if (pointStructure[5].Contains(newWord[i]))
        {
          score += 5;
        }
        else if (pointStructure[8].Contains(newWord[i]))
        {
          score += 8;
        }
        else
        {
          score += 10;
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