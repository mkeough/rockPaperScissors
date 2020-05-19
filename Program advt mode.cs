using System;

namespace rockPaperScissors
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome");
      Console.WriteLine("I want to play a game");
      Console.WriteLine("Choose your difficulty, easy, normal, impossible");
      var diffChoice = Console.ReadLine().ToLower();
      Console.WriteLine("Choose rock, paper, or scissors");
      var UserChoice = Console.ReadLine().ToLower();
      if (diffChoice == "easy" && UserChoice == "rock")
      {

      }
      //initiate random genorator
      Random rnd = new Random();
      //genorate random indexes with arrays {}
      string[] computerChoice = { "rock", "paper", "scissors" };
      //generate random indexes for choices
      int randomIndex = rnd.Next(computerChoice.Length);
      var displayChoice = computerChoice[randomIndex];
      Console.WriteLine(displayChoice);
      if (UserChoice == "rock" && displayChoice == "scissors")
      {
        Console.WriteLine("you win");
      }
      if (UserChoice == "rock" && displayChoice == "rock")
      {
        Console.WriteLine("its a draw");
      }
      if (UserChoice == "rock" && displayChoice == "paper")
      {
        Console.WriteLine("you lose");
      }
      if (UserChoice == "paper" && displayChoice == "paper")
      {
        Console.WriteLine("its a draw");
      }

      if (UserChoice == "paper" && displayChoice == "rock")
      {
        Console.WriteLine("you win");
      }

      if (UserChoice == "paper" && displayChoice == "scissors")
      {
        Console.WriteLine("you lose");
      }
      if (UserChoice == "scissors" && displayChoice == "rock")
      {
        Console.WriteLine("you lose");
      }
      if (UserChoice == "scissors" && displayChoice == "paper")
      {
        Console.WriteLine("you win");
      }
      if (UserChoice == "scissors" && displayChoice == "scissors")
      {
        Console.WriteLine("its a draw");
      }







    }
  }
}