using System.Collections.Generic;
using System;

namespace Anagram.Models
{
  public class AnagramChecker
  {
    public string Compare(string mainWord, string checkWord)
    {

      char[] mainList = mainWord.ToCharArray();
      char[] compareList = checkWord.ToCharArray();

      Array.Sort(mainList);
      Array.Sort(compareList);

      if (new string(mainList) == new string(compareList))
      {
        return checkWord;
      }
      else {
        return "Word is not an Anagram";
      }
    }
  }
}

// Console.WriteLine("Im about to sort the MAINLIST");
// foreach (var letter in mainList)
// {
//   Console.Write(letter + ", ");
// }
// Console.WriteLine("   ...END OF MAINLIST");
//
// Console.WriteLine("Im about to sort the COMPARE LIST");
// foreach (var letter in compareList)
// {
//   Console.Write(letter + ", ");
// }
// Console.WriteLine("   ...END OF COMPARE LIST");
//

















    // public List<string> GetResult(string word)
    // {
    //   List<string> mainList = new List<string> {};
    //   List<string> compareList = new List<string> {};
    //   List<string> resultList = new List<string> {};
    //
    //
    // }
