/*
 * form size = 982, 492
 * button size = 67, 63
 * button location = 884, 372
 *
 * FixedToolWindow
 * 
 * alCoPaUL, beth GviLLErMo [GIMO]
 * 8/16/2025
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            string[] gg = {"Shortest C# Periodic Table by alcopaul (c) 10/19/2013 | http://www.twitter.com/thealcopaul", "H", "He", "Li", "Be", "B", "C", "N", "O", "F", "Ne", "Na", "Mg", "Al", "Si", "P", "S", "Cl", "Ar", "K", "Ca", "Sc", "Ti", "V", "Cr", "Mn", "Fe", "Co", "Ni", "Cu", "Zn", "Ga", "Ge", "As", "Se", "Br", "Kr", "Rb", "Sr", "Y", "Zr", "Nb", "Mo", "Tc", "Ru", "Rh", "Pd", "Ag", "Cd", "In", "Sn", "Sb", "Te", "I", "Xe", "Cs", "Ba", "La", "Ce", "Pr", "Nd", "Pm", "Sm", "Eu", "Gd", "Tb", "Dy", "Ho", "Er", "Tm", "Yb", "Lu", "Hf", "Ta", "W", "Re", "Os", "Ir", "Pt", "Au", "Hg", "Tl", "Pb", "Bi", "Po", "At", "Rn", "Fr", "Ra", "Ac", "Th", "Pa", "U", "Np", "Pu", "Am", "Cm", "Bk", "Cf", "Es", "Fm", "Md", "No", "Lr", "Rf", "Db", "Sg", "Bh", "Hs", "Mt", "Ds", "Rg", "Cn", "Nh", "Fl", "Mc", "Lv", "Ts", "Og"};
            Graphics g = this.CreateGraphics();
            Font drawFont = new System.Drawing.Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(System.Drawing.Color.Black);
            int xx = 5;
            int yy = 5;
            int counter = 0;
            int an = 0;
            Rectangle rectangle = new System.Drawing.Rectangle(xx, yy, 40, 40);
            for (int i = 0; i < 162; i++)
            {
                if (i % 18 == 0 && i != 0)
                {
                    yy = yy + 40;
                    rectangle.Y = yy;
                    xx = 5;
                }
                    rectangle.X = xx;
                    if ((i > 0 && i < 17) || (i > 19 && i < 30) || (i > 37 && i < 48) || (i > 125 && i < 128) || (i > 141 && i < 146) || (i > 159 && i <= 162))
                    {
                        xx = xx + 40;
                        counter = counter + 1;
                    }
                    else if (i == 92 || i == 110)
                    {
                        counter = counter - 14;
                        an = ((i - counter) + 1);
                        Draw(g, rectangle, drawFont, drawBrush, xx, yy, gg[an], an);
                        xx = xx + 40;
                    }
                    else if ((i >= 128 && i <= 142) || (i >= 146 && i <= 162))
                    {
                        if (i >= 128 && i <= 142)
                        {
                            an = ((i - 72) + 1);
                            Draw(g, rectangle, drawFont, drawBrush, xx, yy, gg[an], an);
                            xx = xx + 40;
                        }
                        else
                        {
                            an = ((i - 58) + 1);
                            Draw(g, rectangle, drawFont, drawBrush, xx, yy, gg[an], an);
                            xx = xx + 40;
                        }
                    }
                    else
                    {
                        an = ((i - counter) + 1);
                        Draw(g, rectangle, drawFont, drawBrush, xx, yy, gg[an], an);
                        xx = xx + 40;
                    }
            }
 
        }
        private void Draw(Graphics g, Rectangle rectangle, Font drawFont, SolidBrush drawBrush, int xx, int yy, string symbol, int atomicnumber)
        {
            g.DrawString(symbol, drawFont, drawBrush, (float)(xx + 10), (float)(yy + 15));
            g.DrawString((atomicnumber).ToString(), drawFont, drawBrush, (float)(xx), (float)(yy));
            g.DrawRectangle(Pens.Black, rectangle);
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        
    }
}

// alcopaul
