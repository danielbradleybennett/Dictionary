using System;
using System.Collections.Generic;


namespace Dictionary
{
  class Program
  {
    static void Main(string[] args)
    {

      List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();
      Dictionary<string, string> excitedWord = new Dictionary<string, string>();
      {
        excitedWord.Add("word", "excited");
        excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
        excitedWord.Add("part of speech", "adjective");
        excitedWord.Add("example sentence", "I am excited to learn C#!");
      }
      dictionaryOfWords.Add(excitedWord);

      Dictionary<string, string> terrifiedWord = new Dictionary<string, string>();
      {

        terrifiedWord.Add("word", "terrified");
        terrifiedWord.Add("definition", "cause to feel extreme fear.");
        terrifiedWord.Add("part of speech", "verb");
        terrifiedWord.Add("example sentence", "the thought terrifies me");

      }
      dictionaryOfWords.Add(terrifiedWord);

      foreach (Dictionary<string, string> word in dictionaryOfWords)
      {
        // Iterate the KeyValuePairs of the Dictionary
        foreach (KeyValuePair<string, string> wordData in word)
        {
          Console.WriteLine($"{wordData.Key}: {wordData.Value}");
        }
      }





    }






  }




}


