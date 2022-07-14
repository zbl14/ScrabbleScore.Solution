using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleTests //: IDisposable
  {
    // public void Dispose()
    // {
    //   Score.ClearAll();
    // }

    [TestMethod]
    public void Score_GetScore_1()
    {
      string word = "A";
      int result = Scrabble.Score(word);
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Score_GetScore_3()
    {
      string word = "tea";
      int result = Scrabble.Score(word);
      Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void Score_GetScore_5()
    {
      string word = "dog";
      int result = Scrabble.Score(word);
      Assert.AreEqual(5, result);
    }

    // [TestMethod]
    // public void GetWord_ReturnWord_String()
    // {
    //   string word = "test";
    //   Score newScore = new Score(word);
    //   string result = newScore.Word;
    //   Assert.AreEqual(word, result);
    // }

    // [TestMethod]
    // public void GetLetter_ReturnEmptyList_ScoreList()
    // {
    //   List<Score> newList = new List<Score> { };
    //   List<Score> result = Score.GetScore();
    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    // public void GetLetter_ReturnLetters_LetterList()
    // {
    //   string word1 = "A";
    //   string word2 = "B";
    //   List<Score> letter = new List<Score>(word);
    //   Assert.AreEqual(word,  );
    // }
  }
}