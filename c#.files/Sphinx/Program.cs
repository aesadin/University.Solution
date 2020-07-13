using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  public static void FilledRiddles(Dictionary<string, string> riddles)
  {
    riddles.Add("I am wet when drying. What am I?", "towel");
    riddles.Add("I shave every day, but my beard stays the same. What am I?", "barber");
    riddles.Add("David’s parents have three sons: Snap, Crackle, and what’s the name of the third son?", "david");
    riddles.Add("What invention lets you look right through a wall?", "window");
    riddles.Add("What has words, but never speaks?", "book");
  }

  public static int RandomIndexInDictionary(int numberOfElementsInTheDictionary) 
  {
    Random random = new Random();
    return random.Next(numberOfElementsInTheDictionary);
  }

  public static void NextRiddle(Dictionary<string, string> riddles)
  {
    int randomIndex = RandomIndexInDictionary(riddles.Count);
    Console.WriteLine("Answer this riddle");
    Console.WriteLine(riddles.ElementAt(randomIndex).Key);
    string answer = Console.ReadLine().ToLower();
    if (answer == riddles.ElementAt(randomIndex).Value) 
    {
      Console.WriteLine("You are very clever, here is another riddle");
      NextRiddle(riddles);      
    }
    else
    {
      Console.WriteLine("You have answered incorrectly");      
    }
  }  
  
  public static void Main()
  {
    Dictionary<string, string> myRiddles = new Dictionary<string, string>();
    FilledRiddles(myRiddles);
    NextRiddle(myRiddles);
  }
}