using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
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

    [TestMethod]
    public void Score_GetScore_25()
    {
      string word = "quickly";
      int result = Scrabble.Score(word);
      Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void Score_GetScore_0()
    {
      string word = "";
      int result = Scrabble.Score(word);
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Score_GetScore_13()
    {
      string word = " quit ";
      int result = Scrabble.Score(word);
      Assert.AreEqual(13, result);
    }
  }
}