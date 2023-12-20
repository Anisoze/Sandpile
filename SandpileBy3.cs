using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandpile
{
    class triangle
    {
        public int value;
        public bool up;

        public triangle() { 
            value = 0;
            up = false;
        }

        public triangle(bool dir)
        {
            value = 0;
            up = dir;
        }

        public triangle(int amount, bool dir) { 
            value = amount;
            up = dir;
        }

    }



    internal class SandpileBy3
    {

        private static int size;
        private triangle[,] grid;

        public SandpileBy3(int hight)
        {
            size = (int)(Math.Sqrt(hight / 3.14159265359) + 8);
            grid = new triangle[size,2*size];
            int dir;
            for (int i = 0; i < size - 1; i++)
            {
                dir = i;
                for (int j = 0; j < 2 * size - 1; j++)
                {
                    grid[i, j] = new triangle(dir%2==0);
                    dir += 1;
                }
            }
                     
             grid[1, (size)].value = hight;
            
            

        }


        public int Size()
        {
            return size;
        }

        
        public triangle At(int x, int y)
        {
            return grid[x,y];
        }


        private void topple(int x, int y, int hight)
        {
            grid[x,y].value = hight % 3;
            grid[x + 1, y].value += hight / 3;
            grid[x - 1, y].value += hight / 3;
            if (grid[x, y].up)
            {
                grid[x, y - 1].value += hight / 3;
            }
            else
            {
                grid[x, y + 1].value += hight / 3;
            }

       
            if (x == 2)
            {
                grid[x - 1, y].value += hight / 3;
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
                    for (int j = 1; j < 2*size - 1; j++)
                    {
                        h = grid[i, j].value;
                        if (h > 2)
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
