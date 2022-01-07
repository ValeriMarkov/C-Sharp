using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace RockPaperScissors
{
    class RockPaperScissors
    {
        private int score;
        private Random randomGenerator;
        private string playerChoice;
        private string botString;
        private int bot;

        private string logo = @"
            ╦═╗┌─┐┌─┐┬┌─     ╔═╗┌─┐┌─┐┌─┐┬─┐     ╔═╗┌─┐┬┌─┐┌─┐┌─┐┬─┐┌─┐  
            ╠╦╝│ ││  ├┴┐ ─── ╠═╝├─┤├─┘├┤ ├┬┘ ─── ╚═╗│  │└─┐└─┐│ │├┬┘└─┐  
            ╩╚═└─┘└─┘┴ ┴     ╩  ┴ ┴┴  └─┘┴└─     ╚═╝└─┘┴└─┘└─┘└─┘┴└─└─┘  
            ";

        private string rock = @"
___________
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
";

        private string paper = @"
    _______
---'   ____)____
          ______)
          _______)
         _______)
---.__________)
";

        private string scissors = @"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
";

        public RockPaperScissors()
        {
            score = 0;
            randomGenerator = new Random();
        }

        public void GameStart()
        {
            Clear();
            WriteLine(logo);
            WriteLine("   Welcome to my rock/paper/scissors game!\n\n" +
                "   I don't think anyone needs an explanation on how to play the game, so let's just start!\n\n\t\n" +
                "Press any key to start...");
            ReadKey();
            Round();
        }


        private void Round()
        {
            Clear();
            WriteLine(logo);

            WriteLine("For rock type 'r'\n" +
            "For paper type 'p'\n" +
            "For scissors type 's'");

            playerChoice = ReadLine().ToLower().Trim();
            bot = randomGenerator.Next(1, 3);
            botString = bot.ToString();

            if ((playerChoice == "r") || (playerChoice == "p") || (playerChoice == "s"))
            {
                if (playerChoice == "r")
                {
                    Clear();
                    WriteLine(logo);
                    WriteLine($"You chose: {rock}");
                }
                else if (playerChoice == "p")
                {
                    Clear();
                    WriteLine(logo);
                    WriteLine($"You chose: {paper}");
                }
                else
                {
                    Clear();
                    WriteLine(logo);
                    WriteLine($"You chose: {scissors}");
                }


                if (botString == "1")
                {
                    WriteLine($"Oponent chose: {rock}");
                }
                else if (botString == "2")
                {
                    WriteLine($"Oponent chose: {paper}");
                }
                else
                {
                    WriteLine($"Oponent chose: {scissors}");
                }



                if ((playerChoice == "r" && botString == "1") || (playerChoice == "p" && botString == "2") ||
                       (playerChoice == "s" && botString == "3"))
                {
                    Draw();
                }

                else if ((playerChoice == "r" && botString == "2") || (playerChoice == "p" && botString == "3") ||
                    (playerChoice == "s" && botString == "1"))
                {
                    Lose();
                }
                else if ((playerChoice == "r" && botString == "3") || (playerChoice == "p" && botString == "1") ||
                    (playerChoice == "s" && botString == "2"))
                {
                    Win();
                }
            }
            else
            {
                Clear();
                WriteLine("Invalid choice, please use one of the three valid options...\n" +
                    "Press any key to try again...");

                ReadKey();
                Round();
            }
        }


        private void Win()
        {
            score += 1;
            WriteLine($"You won!\n Score: {score}");
            PlayAgain();
        }

        private void Lose()
        {
            WriteLine($"You lost!\n Score: {score}");
            score = 0;
            PlayAgain();
        }

        private void Draw()
        {
            WriteLine($"Draw!\n Score: {score}");
            PlayAgain();
        }

        private void PlayAgain()
        {
            WriteLine("Do you want to play another round? Type 'y' for more, or any other key to exit...");
            string playAgain = Console.ReadLine().ToLower().Trim();
            if (playAgain == "y")
            {
                Round();
            }
            else
            {
                Clear();
                WriteLine(logo);
                Console.WriteLine("Okay :( maybe another time, bye!");
            }
        }
    }
}