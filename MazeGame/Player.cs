using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace MazeGame
{
    class Player
    {
        //Here i make the player movable in Y and X directions
        public int X { get; set; }
        public int Y { get; set; }
        private string PlayerSpot;
        private ConsoleColor PlayerColor;

        //Here i create the player
        public Player(int startingX, int startingY)
        {
            X = startingX;
            Y = startingY;
            PlayerSpot = "P";
            PlayerColor = ConsoleColor.Red;
        }

        //Here i draw the player on the map
        public void Draw()
        {
            ForegroundColor = PlayerColor;
            SetCursorPosition(X, Y);
            Write(PlayerSpot);
            ResetColor();
        }

    }
}
