using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace MazeGame
{
    class Game
    {
        private World newWorld;
        private Player newPlayer;

        public void StartMenu()
        {
            string gameName = "Maze Game - by Valeri, for final exam for C# in IT Step Academy.";
            string logo = @"
             __      __   _           _   _          __  __               
             \ \    / /  | |         (_) ( )        |  \/  |              
              \ \  / /_ _| | ___ _ __ _  |/   ___   | \  / | __ _ _______ 
               \ \/ / _` | |/ _ \ '__| |     / __|  | |\/| |/ _` |_  / _ \
                \  / (_| | |  __/ |  | |     \__ \  | |  | | (_| |/ /  __/
                 \/ \__,_|_|\___|_|  |_|     |___/  |_|  |_|\__,_/___\___|
";
            Title = gameName;
            WriteLine(logo);
            WriteLine("\t\t\t\tWelcome to my maze game!\n\t\tIn order to win, you must reach the X's on the map!" +
                "\n\tYou are the red 'P' on the map, Controls: 'W' (up), 'A' (left), 'S' (down), 'D' (right)\n\n\t\t\tPress any key if you want to start!");
            ReadKey();
            Start();
        }

        public void Start()
        {

            string[,] map =
            {
                {"+","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","+","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","+"},
                {"|"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"},
                {"|"," "," "," "," ","+"," "," "," "," ","+"," "," "," "," ","+","-","-","-","-","-","-","-","-","-"," "," "," "," "," ","|"," "," "," "," "," ","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","+"," "," "," "," ","|"},
                {"|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"," "," "," "," ","|"},
                {"|"," "," "," "," ","|"," "," "," "," ","+","-","-","-","-","+","-","-","-","-","-","-","-","-","-","-","-","-","-","-","+"," "," "," "," ","+","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","+"," "," "," "," ","|"," "," "," "," ","|"},
                {"|"," "," "," "," ","|"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"},
                {"|"," "," "," "," ","+","-","-","-","-","-","-","-","-","-","-","-","-","-","-","+","-","-","-","-","-","-","-","-","-","-","-","-","-","-","+","-","-","-","-"," "," "," "," "," ","+","-","-","-","-","-","-","-","-","-","+"," "," "," "," ","|"," "," "," "," ","|"},
                {"|"," "," "," "," ","|"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"," "," "," "," "," "," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"},
                {"|"," "," "," "," ","+","-","-","-","-","-","-","-","-","-"," "," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","+","-","-","-","-","-","-","-","-","-","+"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","+","-","-","-","-","|"},
                {"|"," "," "," "," ","|"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," "," "," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," "," "," "," "," "," ","|"},
                {"|"," "," "," "," ","|"," "," "," "," "," ","-","-","-","-","-","-","-","-","-","+"," "," "," "," ","|"," "," "," "," ","+","-","-","-","-"," "," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"},
                {"|"," "," "," "," ","|"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"," "," "," "," ","|"," "," "," "," "," "," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"},
                {"|"," "," "," "," ","+","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","+"," "," "," "," ","|"," "," "," "," "," ","-","-","-","-","+"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"},
                {"|"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"},
                {"|","-","-","-","-","-","-","-","-","-","-","-","-","-","-","+","-","-","-","-","-","-","-","-","-","+"," "," "," "," ","+","-","-","-","-","-","-","-","-","-","-","-","-","-","-","+"," "," "," "," ","|"," "," "," "," ","+","-","-","-","-","+"," "," "," "," ","|"},
                {"|"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"," "," "," "," "," "," "," "," "," ","|"," "," "," "," ","|"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"},
                {"|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"},
                {"|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," "," ","-","-","-","-","-","-","-","-","-","+","-","-","-","-","-","-","-","-","-","+"," "," "," "," ","|"},
                {"|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," "," "," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"," "," "," "," ","|"},
                {"|"," "," "," "," ","|"," "," "," "," ","+","-","-","-","-","-","-","-","-","-","+","-","-","-","-","+"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","+","-","-","-","-","-","-","-","-","-","+"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"},
                {"|"," "," "," "," ","|"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," "," "," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"},
                {"|"," "," "," "," ","+","-","-","-","-","-","-","-","-","-","+","-","-","-","-","-","-","-","-","-","-","-","-","-","-","+"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"},
                {"|"," "," "," "," ","|"," "," "," "," "," "," "," "," "," ","|"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","|"},
                {"|"," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","+","-","-","-","-","-","-","-","-","-"," "," "," "," "," ","|"," "," "," "," ","|"," "," "," "," ","+","-","-","-","-","+"," "," "," "," ","|"," "," "," "," ","+","-","-","-","-","+"," "," "," "," ","|"},
                {"|"," "," "," "," "," "," "," "," "," ","|"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"," "," "," "," ","|"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"},
                {"+","-","-","-","-","-","-","-","-","-","+","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","+","X","X","X","X","+","-","-","-","-","-","-","-","-","-","-","-","-","-","-","+","-","-","-","-","-","-","-","-","-","-","-","-","-","-","+"},
            };

            newWorld = new World(map);
            newPlayer = new Player(1, 1);

            GameUpdate();
        }


        private void DrawCurrentStatus()
        {
            Clear();
            newWorld.Draw();
            newPlayer.Draw();
        }

        private void PlayerInput()
        {
            ConsoleKeyInfo keyPressed = ReadKey(true);
            ConsoleKey key = keyPressed.Key;
                switch (key)
            {
                case ConsoleKey.W:
                    if (newWorld.IsPositionValid(newPlayer.X, newPlayer.Y - 1))
                    {
                    newPlayer.Y -= 1;
                    }
                    break;

                case ConsoleKey.S:
                    if (newWorld.IsPositionValid(newPlayer.X, newPlayer.Y + 1))
                    {
                    newPlayer.Y += 1;
                    }
                    break;

                case ConsoleKey.A:
                    if (newWorld.IsPositionValid(newPlayer.X - 1, newPlayer.Y))
                    {
                    newPlayer.X -= 1;
                    }
                    break;

                case ConsoleKey.D:
                    if (newWorld.IsPositionValid(newPlayer.X + 1, newPlayer.Y))
                    {
                        newPlayer.X += 1;
                    }
                    break;

                default:
                    break;
            }
        }

        //This updates the console always, to keep track of where the player is, and whether he's finished the game.
        private void GameUpdate()
        {
            while (true){
                // Draw everything on the consople
                DrawCurrentStatus();

                //Checks whay button player presses, and moves him
                PlayerInput();


                //Checks if the player is at the exit, and ends it if so
                string elementBellowPlayer = newWorld.getElementPlayerIsOn(newPlayer.X, newPlayer.Y);
                if (elementBellowPlayer == "X")
                {
                    WriteLine("\n\n\tCongratulations, you finished my maze!!!\n\n\t\tPress any key to exit...");
                    ReadKey();
                    break;
                }

            }
        }

    }
}
