using System;
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
  }
}