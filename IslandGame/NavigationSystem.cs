using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslandGame
{
    internal class NavigationSystem
    {
        
        char[,] map;
        byte islandRow = 0;
        byte islandCol = 0;
        string dspmap, updateMap = "";


        public NavigationSystem(int row, int col)
        {
            map = new char[row, col];

            //Rublic: randomly picks a spot for island within map
            Random rand = new Random();
            islandRow = (byte)rand.Next(0, map.GetLength(0) - 1);
            islandCol = (byte)rand.Next(0, map.GetLength(1) - 1);

            //fills map with "~" symbol as instructed
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = '~';
                }


            }



        }

        public string DspMap()
        {   //labels the columns
            dspmap = "";
            dspmap += "   ";
            for (int i = 0; i < map.GetLength(1); i++)
            {
                dspmap += i.ToString() + " ";
            }
            dspmap += "\n";

            for (int i = 0; i < map.GetLength(0); i++)
            {
                if (i < 10)
                {
                    dspmap += " ";
                }

                dspmap += i.ToString() + " ";
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (j > 9)
                    {
                        dspmap += " ";
                    }
                    dspmap += map[i, j].ToString() + " ";
                }
                dspmap += "\n";

            }
            return dspmap;
        }

        public string EvalGuess(int gRow, int gCol, int guessCount)
        {   //checks for island
            updateMap = "";
            if ((gRow == islandRow) && (gCol == islandCol))
            {
                map[gRow, gCol] = 'I';
                updateMap = DspMap();
                MessageBox.Show("Congrats! You found the island!");
            }

            

            else if (gCol == islandCol)
            {
                map[gRow, gCol] = 'C';
                updateMap = DspMap();
            }

            //updates row relation on even guess per instructions
            else if (guessCount % 2 == 0)
            {
                if (gRow < islandRow)
                {
                    map[gRow, gCol] = 'S';
                    updateMap = DspMap();
                }

                else if (gRow > islandRow)
                {
                    map[gRow, gCol] = 'N';
                    updateMap = DspMap();
                }

                else if (gRow == islandRow)
                {
                    map[gRow, gCol] = 'R';
                    updateMap = DspMap();
                }

            }
            //updates column relations on odd guesses per instructions
            else
            {
                if (gCol > islandCol)
                {
                    map[gRow, gCol] = 'W';
                    updateMap = DspMap();
                }

                else if (gCol < islandCol)
                {
                    map[gRow, gCol] = 'E';
                    updateMap = DspMap();
                }

                else if (gCol == islandCol)
                {
                    map[gRow, gCol] = 'C';
                    updateMap = DspMap();
                }
            }

            return updateMap;

        }
    }
}
