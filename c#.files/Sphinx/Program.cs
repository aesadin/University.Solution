using System;
using System.Collections.Generic;

class Program
{
  public static Dictionary<int, string> riddles = new Dictionary<int, string>();
  public static void FilledRiddles(Dictionary<int, string> dictionaryOfRiddles)
  {
    dictionaryOfRiddles.Add(0, "I am wet when drying. What am I?");
    //dictionaryOfRiddles.Add("I am wet when drying. What am I?", "towel");
    //dictionaryOfRiddles.Add("I am wet when drying. What am I?", "towel");
    //dictionaryOfRiddles.Add("I am wet when drying. What am I?", "towel");
    //dictionaryOfRiddles.Add("I am wet when drying. What am I?", "towel");
  }

  public static string[] answerArray = new string[1];
  public static void FilledAnswers(string[] array, int length)
  {
    array[0] = "towel";
    //dictionaryOfRiddles.Add("I am wet when drying. What am I?", "towel");
    //dictionaryOfRiddles.Add("I am wet when drying. What am I?", "towel");
    //dictionaryOfRiddles.Add("I am wet when drying. What am I?", "towel");
    //dictionaryOfRiddles.Add("I am wet when drying. What am I?", "towel");
  }

  public static void Main()
  {
    FilledRiddles(riddles);
    FilledAnswers(answerArray, 1);
    Console.WriteLine("Answer this riddle");
    Console.WriteLine(riddles[0]);
    string answer = Console.ReadLine();
    if (answer == answerArray[0])
    {
      Console.WriteLine("You are very clever, here is another riddle");
      //NextRiddle();
    }
    else
    {
      Console.WriteLine("You have answered incorrectly");      
    }
  }
}

// I am wet when drying. What am I?
// A towel.