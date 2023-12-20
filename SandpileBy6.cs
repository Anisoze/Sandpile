using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandpile
{
    internal class SandpileBy6
    {
        private static int size;
        private int[,] grid;

        public SandpileBy6(int hight)
        {
            size = (int)(Math.Sqrt(hight /  3.14159265359) + 5);
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
            grid[x, y] = hight % 6;
            grid[x + 1, y] += hight / 6;
            grid[x - 1, y] += hight / 6;
            grid[x, y + 1] += hight / 6;
            grid[x, y - 1] += hight / 6;

            if (y % 2 != 0)
            {
                grid[x - 1, y - 1] += hight / 6;
                grid[x - 1, y + 1] += hight / 6;
            }
            else
            {
                grid[x + 1, y - 1] += hight / 6;
                grid[x + 1, y + 1] += hight / 6;
            }

            if (x<=2 || y==2)
            {
                if (x == 2 && y % 2 != 0)
                {
                    grid[x - 1, y] += hight / 6;
                }

                if (x == 1 && y%2==0)
                {
                    grid[x, y] += hight / 6;
                    grid[x, y + 1] += hight / 6;
                    grid[x, y - 1] += hight / 6;

                    if (y == 2)
                    {
                        grid[x + 1, y - 1] += hight / 6;
                        grid[x, y - 1] += 2*(hight / 6);
                    }
                }

                if (y == 2 && x!=1)
                {
                    grid[x, y - 1] += hight / 6;
                    grid[x + 1, y - 1] += hight / 6;
                }
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
                        if (h > 5)
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
