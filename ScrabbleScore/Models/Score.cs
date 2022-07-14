using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class Score
  {
    public string Word { get; set; }
    private static List<Score> _instances = new List<Score> {};

    public Score(string word)
    {
      Word = word;
      _instances.Add(this);
    }

    public static List<Score> GetLetter()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}