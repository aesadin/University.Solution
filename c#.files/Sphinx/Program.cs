using System;
using System.Collections.Generic;

class Program
{
  public static Dictionary<string,string> riddles = new Dictionary<string, string>();

  public static void Main()
  {
    Console.WriteLine("Answer this riddle");
    string answer = Console.ReadLine();
    if (answer == "Towel" || answer == "towel")
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