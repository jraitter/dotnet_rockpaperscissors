using System;

namespace rockpaperscissors
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      // create variable needed
      int playerWinCount = 0;
      int compWinCount = 0;
      // create choices array
      string[] computerChoices = new string[]
      {
        "rock",
        "paper",
        "scissors"
      };

      Console.WriteLine("Hello Player");
      Console.Write("Please enter your name: ");
      string playerName = Console.ReadLine();
      bool running = true;

      // start while loop 
      while (running)
      {
        Console.WriteLine("At anytime enter q to quit the game");

        Console.WriteLine("");
        Console.WriteLine("Please enter your choice: rock paper scissors ");
        string playerChoice = Console.ReadLine().ToLower();
        if (playerChoice == "q" || playerChoice == "quit")
        {
          running = false;
          Console.WriteLine($"Thanks {playerName} for playing the game");
          break;
        }
        // determine computer choice
        string compChoice = computerChoices[randNum()];
        Console.WriteLine("");

        Console.WriteLine($"Player has chosen: {playerChoice}");
        Console.WriteLine("");

        Console.WriteLine($"Computer has chosen: {compChoice}");
        Console.WriteLine("");


        // compare computer choice to player choice

        if (playerChoice == compChoice)
        {
          Console.WriteLine("Ther was a tie");
        }
        else if (playerChoice == "rock")
        {
          if (compChoice == "paper")
          {
            // computer wins
            Console.WriteLine("paper beats rock");
            Console.WriteLine("The computer wins this round");
            compWinCount++;
          }
          else
          {
            // player wins
            Console.WriteLine("rock beats scissors");
            Console.WriteLine("The player wins this round");
            playerWinCount++;
          }
        }
        else if (playerChoice == "paper")
        {
          if (compChoice == "Rock")
          {
            //player wins
            Console.WriteLine("paper beats rock");
            Console.WriteLine("The player wins this round");
            playerWinCount++;
          }
          else
          {
            //computer wins
            Console.WriteLine("scissors beats paper");
            Console.WriteLine("The computer wins this round");
            compWinCount++;
          }
        }
        else if (playerChoice == "scissors")
        {
          if (compChoice == "paper")
          {
            //player wins
            Console.WriteLine("scissors beats paper");
            Console.WriteLine("The player wins this round");
            playerWinCount++;
          }
          else
          {
            //computer wins
            Console.WriteLine("rock beats scissors");
            Console.WriteLine("The computer wins this round");
            compWinCount++;
          }
        }
        Console.WriteLine("");
        Console.WriteLine($"Player win count : {playerWinCount.ToString()}");
        Console.WriteLine("");
        Console.WriteLine($"Computer win count: {compWinCount.ToString()}");
        Console.WriteLine("");
      } //end of while loop

      //random number generator 0 to 2
      int randNum()
      {
        Random rnd = new Random();
        int randNum = rnd.Next(3);
        return randNum;
      }//end of randNum

    } //end of main
  }//end of program
}//end of namespace
