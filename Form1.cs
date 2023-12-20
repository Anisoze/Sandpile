using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sandpile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private static int amount = 50000;
        private static int cellsize = 2;
        //BufferedGraphicsContext myContext = new BufferedGraphicsContext();
        //BufferedGraphicsContext currentContext = BufferedGraphicsManager.Current;
        //BufferedGraphics myBuffer;

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            Brush brushW = new SolidBrush(Color.White);
            Brush brush0 = new SolidBrush(Color.Black);
            Brush brush1 = new SolidBrush(Color.Green);
            Brush brush2 = new SolidBrush(Color.Purple);
            Brush brush3 = new SolidBrush(Color.Gold);


            graphics.FillRectangle(brushW, 5, 410, 200, 50);

            graphics.FillRectangle(brush0, 10, 410, 20, 50);
            graphics.FillRectangle(brush1, 40, 410, 20, 50);
            graphics.FillRectangle(brush2, 73, 410, 20, 50);
            graphics.FillRectangle(brush3, 108, 410, 20, 50);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            Brush brushW = new SolidBrush(Color.White);
            Brush brush0 = new SolidBrush(Color.Black);
            Brush brush1 = new SolidBrush(Color.Green);
            Brush brush2 = new SolidBrush(Color.Gold);


            graphics.FillRectangle(brushW, 5, 410, 200, 50);

            graphics.FillRectangle(brush0, 10, 410, 20, 50);
            graphics.FillRectangle(brush1, 40, 410, 20, 50);
            graphics.FillRectangle(brush2, 73, 410, 20, 50);

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            Brush brushW = new SolidBrush(Color.White);
            Brush brush0 = new SolidBrush(Color.Black);
            Brush brush1 = new SolidBrush(Color.Green);
            Brush brush2 = new SolidBrush(Color.Purple);
            Brush brush3 = new SolidBrush(Color.DarkBlue);
            Brush brush4 = new SolidBrush(Color.DarkRed);
            Brush brush5 = new SolidBrush(Color.Gold);

            graphics.FillRectangle(brushW, 5, 410, 200, 50);

            graphics.FillRectangle(brush0, 10, 410, 20, 50);
            graphics.FillRectangle(brush1, 40, 410, 20, 50);
            graphics.FillRectangle(brush2, 73, 410, 20, 50);
            graphics.FillRectangle(brush3, 108, 410, 20, 50);
            graphics.FillRectangle(brush4, 144, 410, 20, 50);
            graphics.FillRectangle(brush5, 183, 410, 20, 50);
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
       {
            try
            {
                amount = Convert.ToInt32(textBox1.Text);
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SandpileBy4 pile4 = new SandpileBy4(amount);
            cellsize = 640 / (2 * pile4.Size());

            Graphics graphics = CreateGraphics();
            Brush brush0 = new SolidBrush(Color.Black);
            Brush brush1 = new SolidBrush(Color.Green);
            Brush brush2 = new SolidBrush(Color.Purple);
            Brush brush3 = new SolidBrush(Color.Gold);
            graphics.FillRectangle(brush0, 250, 27, 800, 800);

            pile4.toppleAll();


            for (int i = 1; i < pile4.Size() - 1; i++)
            {
                for (int j = 1; j < pile4.Size() - 1; j++)
                {
                    if (pile4.At(i, j) != 0)
                    {
                        if (pile4.At(j, i) == 1)
                        {
                            graphics.FillRectangle(brush1, 250 + (pile4.Size() + 1 - i) * cellsize, 27 + (pile4.Size() + 1 - j) * cellsize, cellsize, cellsize);
                            graphics.FillRectangle(brush1, 250 + (pile4.Size() - 1 + i) * cellsize, 27 + (pile4.Size() + 1 - j) * cellsize, cellsize, cellsize);
                            graphics.FillRectangle(brush1, 250 + (pile4.Size() + 1 - i) * cellsize, 27 + (pile4.Size() - 1 + j) * cellsize, cellsize, cellsize);
                            graphics.FillRectangle(brush1, 250 + (pile4.Size() - 1 + i) * cellsize, 27 + (pile4.Size() - 1 + j) * cellsize, cellsize, cellsize);
                        }
                        else if (pile4.At(i, j) == 2)
                        {
                            graphics.FillRectangle(brush2, 250 + (pile4.Size() + 1 - i) * cellsize, 27 + (pile4.Size() + 1 - j) * cellsize, cellsize, cellsize);
                            graphics.FillRectangle(brush2, 250 + (pile4.Size() - 1 + i) * cellsize, 27 + (pile4.Size() + 1 - j) * cellsize, cellsize, cellsize);
                            graphics.FillRectangle(brush2, 250 + (pile4.Size() + 1 - i) * cellsize, 27 + (pile4.Size() - 1 + j) * cellsize, cellsize, cellsize);
                            graphics.FillRectangle(brush2, 250 + (pile4.Size() - 1 + i) * cellsize, 27 + (pile4.Size() - 1 + j) * cellsize, cellsize, cellsize);

                        }
                        else
                        {
                            graphics.FillRectangle(brush3, 250 + (pile4.Size() + 1 - i) * cellsize, 27 + (pile4.Size() + 1 - j) * cellsize, cellsize, cellsize);
                            graphics.FillRectangle(brush3, 250 + (pile4.Size() - 1 + i) * cellsize, 27 + (pile4.Size() + 1 - j) * cellsize, cellsize, cellsize);
                            graphics.FillRectangle(brush3, 250 + (pile4.Size() + 1 - i) * cellsize, 27 + (pile4.Size() - 1 + j) * cellsize, cellsize, cellsize);
                            graphics.FillRectangle(brush3, 250 + (pile4.Size() - 1 + i) * cellsize, 27 + (pile4.Size() - 1 + j) * cellsize, cellsize, cellsize);
                        }
                    }
                    
                }
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SandpileBy3 pile3 = new SandpileBy3(amount);
            cellsize = 640 / (2*pile3.Size());

            Graphics graphics = CreateGraphics();         
            Brush brushB = new SolidBrush(Color.Black);
            Brush brushGr = new SolidBrush(Color.Green);
            Brush brushGl = new SolidBrush(Color.Gold);
            graphics.FillRectangle(brushB, 250, 27, 800, 800);

            pile3.toppleAll();
            
            Point point1 = new Point();
            Point point2 = new Point();
            Point point3 = new Point();
            Point point4 = new Point();
            Point point5 = new Point();
            Point point6 = new Point();
            Point[] PL = {point1, point2, point3};
            Point[] PR = {point4, point5, point6};

            for (int i = 1; i < pile3.Size() - 1; i++)
            {
                for (int j = 1; j < 2*pile3.Size() - 1; j++)
                {
                    if(pile3.At(i,j).value != 0)
                    {
                        PL[0].X = 250 + (pile3.Size() - i - 1) * cellsize;                    
                        PL[1].X = 250 + (pile3.Size() - i) * cellsize;
                        PL[2].X = 250 + (pile3.Size() - i + 1) * cellsize;
                       
                        PR[0].X = 250 + (pile3.Size() + i - 1 - 2) * cellsize;                     
                        PR[1].X = 250 + (pile3.Size() + i - 2) * cellsize;
                        PR[2].X = 250 + (pile3.Size() + i + 1 - 2 ) * cellsize;                      

                        if (pile3.At(i, j).up)
                        {
                            PL[0].Y = 27 + (8 * pile3.Size() / 5 - j + 1) * 2*cellsize;                       
                            PL[1].Y = 27 + (8 * pile3.Size() / 5 - j - 1 + 1) * 2 * cellsize;
                            PL[2].Y = 27 + (8 * pile3.Size() / 5 - j + 1) * 2 * cellsize;

                            PR[0].Y = 27 + (8 * pile3.Size() / 5 - j + 1) * 2 * cellsize;
                            PR[1].Y = 27 + (8 * pile3.Size() / 5 - j - 1 + 1) * 2 * cellsize;
                            PR[2].Y = 27 + (8 * pile3.Size() / 5 - j + 1) * 2 * cellsize;
                        }
                        else
                        {
                            PL[0].Y = 27 + (8 * pile3.Size() / 5 - j) * 2 * cellsize;
                            PL[1].Y = 27 + (8 * pile3.Size() / 5 - j + 1) * 2 * cellsize;
                            PL[2].Y = 27 + (8 * pile3.Size() / 5 - j) * 2 * cellsize;

                            PR[0].Y = 27 + (8 * pile3.Size() / 5 - j) * 2 * cellsize;
                            PR[1].Y = 27 + (8 * pile3.Size() / 5 - j + 1) * 2 * cellsize;
                            PR[2].Y = 27 + (8 * pile3.Size() / 5 - j) * 2 * cellsize;
                        }

                        if (pile3.At(i, j).value == 1)
                        {
                            graphics.FillPolygon(brushGr, PL);
                            graphics.FillPolygon(brushGr, PR);
                        }
                        else if (pile3.At(i, j).value == 2)
                        {
                            graphics.FillPolygon(brushGl, PL);
                            graphics.FillPolygon(brushGl, PR);
                        }
                    }
                                                         
                    
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SandpileBy6 pile6 = new SandpileBy6(amount);          
            cellsize = 640 / (4 * pile6.Size());

            Graphics graphics = CreateGraphics();
            Brush brush0 = new SolidBrush(Color.Black);
            Brush brush1 = new SolidBrush(Color.Green);
            Brush brush2 = new SolidBrush(Color.Purple);
            Brush brush3 = new SolidBrush(Color.DarkBlue);
            Brush brush4 = new SolidBrush(Color.DarkRed);
            Brush brush5 = new SolidBrush(Color.Gold);
            graphics.FillRectangle(brush0, 250, 27, 800, 800);

            pile6.toppleAll();

            Point point1 = new Point();
            Point point2 = new Point();
            Point point3 = new Point();
            Point point4 = new Point();
            Point point5 = new Point();
            Point point6 = new Point();
            Point[] PRU = { point1, point2, point3, point4, point5, point6 };
            Point[] PRD = { point1, point2, point3, point4, point5, point6 };
            Point[] PLU = { point1, point2, point3, point4, point5, point6 };
            Point[] PLD = { point1, point2, point3, point4, point5, point6 };

            for (int i = 1; i < pile6.Size()-1; i++)
            {
                for (int j = 1; j < pile6.Size()-1; j++)
                {                  

                    if (pile6.At(i,j) != 0)
                    {
                        if (j%2 == 0)
                        {
                            PRU[0].X = 250 + (pile6.Size() + 2 * i + 1 + 1) * 2 * cellsize;
                            PRU[1].X = 250 + (pile6.Size() + 2 * i + 1 + 1) * 2 * cellsize;
                            PRU[2].X = 250 + (pile6.Size() + 2 * i + 1) * 2 * cellsize;
                            PRU[3].X = 250 + (pile6.Size() + 2 * i + 1 - 1) * 2 * cellsize;
                            PRU[4].X = 250 + (pile6.Size() + 2 * i + 1 - 1) * 2 * cellsize;
                            PRU[5].X = 250 + (pile6.Size() + 2 * i + 1) * 2 * cellsize;

                            PRD[0].X = PRU[0].X;
                            PRD[1].X = PRU[1].X;
                            PRD[2].X = PRU[2].X;
                            PRD[3].X = PRU[3].X;
                            PRD[4].X = PRU[4].X;
                            PRD[5].X = PRU[5].X;

                            PLU[0].X = 250 + (pile6.Size() - 2 * i + 1 + 1 + 2) * 2 * cellsize;
                            PLU[1].X = 250 + (pile6.Size() - 2 * i + 1 + 1 + 2) * 2 * cellsize;
                            PLU[2].X = 250 + (pile6.Size() - 2 * i + 1 + 2) * 2 * cellsize;
                            PLU[3].X = 250 + (pile6.Size() - 2 * i + 1 - 1 + 2) * 2 * cellsize;
                            PLU[4].X = 250 + (pile6.Size() - 2 * i + 1 - 1 + 2) * 2 * cellsize;
                            PLU[5].X = 250 + (pile6.Size() - 2 * i + 1 + 2) * 2 * cellsize;

                            PLD[0].X = PLU[0].X;
                            PLD[1].X = PLU[1].X;
                            PLD[2].X = PLU[2].X;
                            PLD[3].X = PLU[3].X;
                            PLD[4].X = PLU[4].X;
                            PLD[5].X = PLU[5].X;
                        }
                        else
                        {
                            PRU[0].X = 250 + (pile6.Size() + 2 * i + 1) * 2 * cellsize;
                            PRU[1].X = 250 + (pile6.Size() + 2 * i + 1) * 2 * cellsize;
                            PRU[2].X = 250 + (pile6.Size() + 2 * i) * 2 * cellsize;
                            PRU[3].X = 250 + (pile6.Size() + 2 * i - 1) * 2 * cellsize;
                            PRU[4].X = 250 + (pile6.Size() + 2 * i - 1) * 2 * cellsize;
                            PRU[5].X = 250 + (pile6.Size() + 2 * i) * 2 * cellsize;

                            PRD[0].X = PRU[0].X;
                            PRD[1].X = PRU[1].X;
                            PRD[2].X = PRU[2].X;
                            PRD[3].X = PRU[3].X;
                            PRD[4].X = PRU[4].X;
                            PRD[5].X = PRU[5].X;

                            PLU[0].X = 250 + (pile6.Size() - 2 * i + 1 + 4) * 2 * cellsize;
                            PLU[1].X = 250 + (pile6.Size() - 2 * i + 1 + 4) * 2 * cellsize;
                            PLU[2].X = 250 + (pile6.Size() - 2 * i + 4) * 2 * cellsize;
                            PLU[3].X = 250 + (pile6.Size() - 2 * i - 1 + 4) * 2 * cellsize;
                            PLU[4].X = 250 + (pile6.Size() - 2 * i - 1 + 4) * 2 * cellsize;
                            PLU[5].X = 250 + (pile6.Size() - 2 * i + 4) * 2 * cellsize;

                            PLD[0].X = PLU[0].X;
                            PLD[1].X = PLU[1].X;
                            PLD[2].X = PLU[2].X;
                            PLD[3].X = PLU[3].X;
                            PLD[4].X = PLU[4].X;
                            PLD[5].X = PLU[5].X;
                        }

                        PRU[0].Y = 27 + (2 * pile6.Size() - 3 * j - 1) * cellsize;
                        PRU[1].Y = 27 + (2 * pile6.Size() - 3 * j + 1) * cellsize;
                        PRU[2].Y = 27 + (2 * pile6.Size() - 3 * j + 2) * cellsize;
                        PRU[3].Y = 27 + (2 * pile6.Size() - 3 * j + 1) * cellsize;
                        PRU[4].Y = 27 + (2 * pile6.Size() - 3 * j - 1) * cellsize;
                        PRU[5].Y = 27 + (2 * pile6.Size() - 3 * j - 2) * cellsize;

                        PRD[0].Y = 27 + (2 * pile6.Size() + 3 * j - 1 - 6) * cellsize;
                        PRD[1].Y = 27 + (2 * pile6.Size() + 3 * j + 1 - 6) * cellsize;
                        PRD[2].Y = 27 + (2 * pile6.Size() + 3 * j + 2 - 6) * cellsize;
                        PRD[3].Y = 27 + (2 * pile6.Size() + 3 * j + 1 - 6) * cellsize;
                        PRD[4].Y = 27 + (2 * pile6.Size() + 3 * j - 1 - 6) * cellsize;
                        PRD[5].Y = 27 + (2 * pile6.Size() + 3 * j - 2 - 6) * cellsize;

                        PLU[0].Y = PRU[0].Y;
                        PLU[1].Y = PRU[1].Y;
                        PLU[2].Y = PRU[2].Y;
                        PLU[3].Y = PRU[3].Y;
                        PLU[4].Y = PRU[4].Y;
                        PLU[5].Y = PRU[5].Y;

                        PLD[0].Y = PRD[0].Y;
                        PLD[1].Y = PRD[1].Y;
                        PLD[2].Y = PRD[2].Y;
                        PLD[3].Y = PRD[3].Y;
                        PLD[4].Y = PRD[4].Y;
                        PLD[5].Y = PRD[5].Y;

                        if (pile6.At(i, j) == 1)
                        {
                            graphics.FillPolygon(brush1, PRU);
                            graphics.FillPolygon(brush1, PRD);
                            graphics.FillPolygon(brush1, PLU);
                            graphics.FillPolygon(brush1, PLD);
                        }
                        else if (pile6.At(i,j) == 2)
                        {
                            graphics.FillPolygon(brush2, PRU);
                            graphics.FillPolygon(brush2, PRD);
                            graphics.FillPolygon(brush2, PLU);
                            graphics.FillPolygon(brush2, PLD);
                        }
                        else if (pile6.At(i,j) == 3)
                        {
                            graphics.FillPolygon(brush3, PRU);
                            graphics.FillPolygon(brush3, PRD);
                            graphics.FillPolygon(brush3, PLU);
                            graphics.FillPolygon(brush3, PLD);
                        }
                        else if (pile6.At(i, j) == 4)
                        {
                            graphics.FillPolygon(brush4, PRU);
                            graphics.FillPolygon(brush4, PRD);
                            graphics.FillPolygon(brush4, PLU);
                            graphics.FillPolygon(brush4, PLD);
                        }
                        else
                        {
                            graphics.FillPolygon(brush5, PRU);
                            graphics.FillPolygon(brush5, PRD);
                            graphics.FillPolygon(brush5, PLU);
                            graphics.FillPolygon(brush5, PLD);
                        }
                    }
                    
                }
            }
        }

       

        
    }
}
