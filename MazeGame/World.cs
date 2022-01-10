using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace MazeGame
{
    class World
    {

        private string[,] Map;
        private int Rows;
        private int Columns;

        public World(string[,] map)
        {
            Map = map;
            Rows = Map.GetLength(0);
            Columns = Map.GetLength(1);
        }

        public void Draw()
        {
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Columns; x++)
                {
                    string element = Map[y, x];
                    SetCursorPosition(x, y);
                    Write(element);
                }
            }
        }

        public bool IsPositionValid(int x, int y)
        {
            //I'm checking if the player is about to move outside borders on map
            if (x < 0 || y < 0 || x >= Columns || y >= Rows)
            {
                return false;
            }
            //I'm checking if the position the player want to move is an accesible block
            return Map[y, x] == " " || Map[y, x] == "X";

        }

        public string getElementPlayerIsOn(int x,int y)
        {
            return Map[y, x];
        }

    }
}
