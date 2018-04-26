using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleApp.Models;
using System.Collections.Generic;
using System;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTest
  {
    [TestMethod]
    public void testscore()
    {
      //Arrange
      Scrabble1 word = new Scrabble1("hello", 0);
      //Act
      int score = word.scrabble();
      //Assert
      Assert.AreEqual(9, score);
    }
  }
}
