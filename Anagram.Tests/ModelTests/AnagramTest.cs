using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram.Models;
using System;

namespace Anagram.Tests
{

  [TestClass]
  public class AnagramTest
  {

    [TestMethod]
    public void CompareWords_CompareArrays1_True()
    {
      //Arrange
      AnagramChecker newWord = new AnagramChecker();

      //action
      List<string> result = newWord.Compare("no", "on");
      List<string> expected = new List<string> {"on"};


      //Assert
      CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void CompareWords_CompareArrays2_True()
    {
      //Arrange
      AnagramChecker newWord = new AnagramChecker();
      //List<string> resultList = new List<string> {};

      //action
      List<string> result = newWord.Compare("bread", "beard");
      List<string> expected = new List<string> {"beard"};

      //Assert
      CollectionAssert.AreEqual(expected, result);
    }

    // [TestMethod]
    // public void CompareWords_CompareArrays3_True()
    // {
    //   //Arrange
    //   AnagramChecker newWord = new AnagramChecker();
    //
    //   //action
    //   var result = newWord.Compare("acre", testList("care", "race"));
    //   var expected = "care", "race";
    //   Console.WriteLine("Output: " + result);
    //
    //   //Assert
    //   Assert.AreEqual(expected, result);
    // }

  }
}
