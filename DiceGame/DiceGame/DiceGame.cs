using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DiceGame
{
    class DiceGame
    {

        private string GameLogo = @"
             __      __   _           _   _        _____  _             _____                      
             \ \    / /  | |         (_|   )      |  __ \(_)           / ____|                     
              \ \  / /_ _| | ___ _ __ _|  /  ___  | |  | |_  ___ ___  | |  __  __ _ _ __ ___   ___ 
               \ \/ / _` | |/ _ \ '__| |    / __| | |  | | |/ __/ _ \ | | |_ |/ _` | '_ ` _ \ / _ \
                \  / (_| | |  __/ |  | |    \__ \ | |__| | | (_|  __/ | |__| | (_| | | | | | |  __/
                 \/ \__,_|_|\___|_|  |_|    |___/ |_____/|_|\___\___|  \_____|\__,_|_| |_| |_|\___|
        ";


        private Random RandomGenerator;
        private int Score;


        public DiceGame()
        {
            Score = 0;
            RandomGenerator = new Random();
        }


        public void Start()
        {
            Console.Clear();
            Console.Title = "Valeri's Dice Game";
            Console.WriteLine(GameLogo);

            Console.WriteLine("Welcome to Valeri's dice game!\n\nThe dice will " +
                "roll randomly between 1-9, and you have 3 options to pick: " +
                "\n\t1) Low (1-3)\n\t2) Middle (4-6)\n\t3) High (7-9)\n" +
                "In order to win, you have to guess correctly in which range the dice rolled.\n\n" +
                "Do you want to play now? (Type - 'y' for yes, or 'n' for no)");
            string PlayerResponse = Console.ReadLine().ToLower().Trim();
            
            if(PlayerResponse == "y")
            {
                Console.Clear();
                Console.WriteLine("Yay! Good luck!\n\nPress any key to start...");
                Round();
            }
            else if(PlayerResponse == "n")
            {
                Console.Clear();
                Console.WriteLine("A shame... :(\n\nPress any key to exit...");
                Console.ReadKey();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Please, answer with - 'y' or 'n'\n\nPress any key to try again...");
                Console.ReadKey();
                Start();
            }
        }


        private void Round()
        {
            Console.Clear();
            Console.WriteLine("Type the range ('l' for low, 'm'for medium or 'h' for high) you guess: ");
            string playerGuess = Console.ReadLine().Trim().ToLower();
            int diceRoll = RandomGenerator.Next(1, 9);

            string diceRollString = diceRoll.ToString();


            if(diceRollString == "1")
            {
                string one = @"
    -----
    |   |
    | o |
    |   |
    -----";
                Console.Clear();
                Console.WriteLine("You guessed: " + playerGuess);
                Console.WriteLine($"The dice rolled on: {diceRoll}\n\t" + one);
            }

            else if (diceRollString == "2")
            {
                string two = @"
    -----
    |o  |
    |   |
    |  o|
    -----";
                Console.Clear();
                Console.WriteLine("You guessed: " + playerGuess);
                Console.WriteLine($"The dice rolled on: {diceRoll}\n\t" + two);
            }

            else if (diceRollString == "3")
            {
                string three = @"
    -----
    |o  |
    | o |
    |  o|
    -----";
                Console.Clear();
                Console.WriteLine("You guessed: " + playerGuess);
                Console.WriteLine($"The dice rolled on: {diceRoll}\n\t" + three);
            }

            else if (diceRollString == "4")
            {
                string four = @"
    -----
    |o o|
    |   |
    |o o|
    -----";
                Console.Clear();
                Console.WriteLine("You guessed: " + playerGuess);
                Console.WriteLine($"The dice rolled on: {diceRoll}\n\t" + four);
            }

            else if (diceRollString == "5")
            {
                string five = @"
    -----
    |o o|
    | o |
    |o o|
    -----";
                Console.Clear();
                Console.WriteLine("You guessed: " + playerGuess);
                Console.WriteLine($"The dice rolled on: {diceRoll}\n\t" + five);
            }

            else if (diceRollString == "6")
            {
                string six = @"
    -----
    |o o|
    |o o|
    |o o|
    -----";
                Console.Clear();
                Console.WriteLine("You guessed: " + playerGuess);
                Console.WriteLine($"The dice rolled on: {diceRoll}\n\t" + six);
            }

            else if (diceRollString == "7")
            {
                string seven = @"
    -----
    |o o|
    |o o|
    |o o|
    |o  |
    -----";
                Console.Clear();
                Console.WriteLine("You guessed: " + playerGuess);
                Console.WriteLine($"The dice rolled on: {diceRoll}\n\t" + seven);
            }

            else if (diceRollString == "8")
            {
                string eight = @"
    -----
    |o o|
    |o o|
    |o o|
    |o o|
    -----";
                Console.Clear();
                Console.WriteLine("You guessed: " + playerGuess);
                Console.WriteLine($"The dice rolled on: {diceRoll}\n\t" + eight);
            }

            else
            {
                string nine = @"
    -----
    |o o|
    |o o|
    |o o|
    |o o|
    |o  |
    -----";
                Console.Clear();
                Console.WriteLine("You guessed: " + playerGuess);
                Console.WriteLine($"The dice rolled on: {diceRoll}\n\t" + nine);
            }


            if (playerGuess == "l")
            {
                if (diceRoll <= 3)
                {
                    Win();
                }
                else
                {
                    Lose();
                }
            }

            else if (playerGuess == "m")
            {
                if (diceRoll > 3 && diceRoll <= 6)
                {
                    Win();
                }
                else
                {
                    Lose();
                }
            }

            else if (playerGuess == "h")
            {
                if (diceRoll > 6 && diceRoll <= 9)
                {
                    Win();
                }
                else
                {
                    Lose();
                }
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Invalid guess, please type only one of the three valid options...\n" +
                    "Press any key to try again...");
                Console.ReadKey();
                Round();
            }
        }


        private void Win()
        {
            Score += 1;
            Console.WriteLine($"Correct!\nScore is now: {Score}");
            PlayAgain();
        }


        private void Lose()
        {
            Score = 0;
            Console.WriteLine($"Wrong... :(\nScore: {Score}");
            PlayAgain();
        }


        private void PlayAgain()
        {
            Console.WriteLine("Do you want to play another round? Type 'y' for more, or any other key to exit...");
            string playAgain = Console.ReadLine().ToLower().Trim();
            if(playAgain == "y")
            {
                Round();
            }
            else
            {
                Console.WriteLine("Okay, maybe another time, bye!");
            }
        }
    }
}
