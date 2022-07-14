namespace ScrabbleScore.Models
{
  public class Score
  {
    public string Word { get; set; }

    public Score(string word)
    {
      Word = word;
    }
  }
}