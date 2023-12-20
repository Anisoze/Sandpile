using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandpile
{
    internal class SandpileBy4
    {

        private static int size;
        private int[,] grid;


        public SandpileBy4(int hight)
        {
            size = (int)(Math.Sqrt(hight/2.0/ 3.14159265359)+4);
            grid = new int[size, size];
            grid[1,1] = hight;
        }


        public int Size()
        {
            return size;
        }


        public int At(int x, int y)
        {
            return grid[x,y];
        }


        private void topple(int x, int y, int hight)
        {
            grid[x, y] = hight % 4;
            grid[x, y + 1] += hight / 4;
            grid[x, y - 1] += hight / 4;
            grid[x + 1, y] += hight / 4;
            grid[x - 1, y] += hight / 4;

            if (x == 2)
            {
                grid[x - 1, y] += hight / 4;
            }

            if (y == 2)
            {
                grid[x, y - 1] += hight / 4;
            }
        }


        public void toppleAll()
        {
            bool more = true;
            int h;
            while (more)
            {
                more = false;

                for (int i = 1; i < size - 1; i++)
                {
                    for (int j = 1; j < size - 1; j++)
                    {
                        h = grid[i, j];
                        if (h > 3)
                        {
                            more = true;
                            topple(i, j, h);
                        }
                    }
                }
            }
        }





    }
}
