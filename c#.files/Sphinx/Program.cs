using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  public static Dictionary<string, string> riddles = new Dictionary<string, string>();
  public static void FilledRiddles(Dictionary<string, string> dictionaryOfRiddles)
  {
    dictionaryOfRiddles.Add("I am wet when drying. What am I?", "towel");
    dictionaryOfRiddles.Add("I shave every day, but my beard stays the same. What am I?", "barber");
    dictionaryOfRiddles.Add("David’s parents have three sons: Snap, Crackle, and what’s the name of the third son?", "david");
    dictionaryOfRiddles.Add("What invention lets you look right through a wall?", "window");
    dictionaryOfRiddles.Add("What has words, but never speaks?", "book");
  }

  public static void Main()
  {
    FilledRiddles(riddles);
    Random random = new Random();
    int randomIndexInDictionary = random.Next(riddles.Count);
    Console.WriteLine("Answer this riddle");
    Console.WriteLine(riddles.ElementAt(randomIndexInDictionary).Key);
    string answer = Console.ReadLine();
    if (answer == riddles.ElementAt(randomIndexInDictionary).Value) 
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

/*13. Riddle: I shave every day, but my beard stays the same. What am I?
Answer: A barber

20. Riddle: David’s parents have three sons: Snap, Crackle, and what’s the name of the third son?
Answer: David

29. Riddle: What invention lets you look right through a wall?
Answer: A window

30. Riddle: If you’ve got me, you want to share me; if you share me, you haven’t kept me. What am I?
Answer: A secret

32. Riddle: What goes up and down but doesn’t move?
Answer: A staircase

45. Riddle: What has words, but never speaks?
Answer: A book

47. Riddle: What can travel all around the world without leaving its corner?
Answer: A stamp*/