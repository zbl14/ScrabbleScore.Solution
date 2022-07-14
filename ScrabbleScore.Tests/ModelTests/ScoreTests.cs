using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScoreTests // : IDisposable
  {
    // public void Dispose()
    // {
    //   ClassName.ClearAll();
    // }

    [TestMethod]
    public void ScoreConstructor_CreateInstanceOfScore_Score()
    {
      Score newScore = new Score("test");
      Assert.AreEqual(typeof(Score), newScore.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnWord_String()
    {
      string word = "test";
      Score newScore = new Score(word);
      string result = newScore.Word;
      Assert.AreEqual(word, result);
    }

    [TestMethod]
    public void GetLetter_ReturnEmptyList_LetterList()
    {
      List<Score> newList = new List<Score> { };
      List<Score> result = Score.GetLetter();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}