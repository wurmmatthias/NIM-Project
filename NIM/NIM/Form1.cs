using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIM
{
    public partial class Form1 : Form
    {

        int space = 10;
        int counter = 0;
        int loopi = 0;
        int room = 10;
        int endcounter = 0;
        int k = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void DrawItBlack(int x)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(myBrush, new Rectangle(x, 150, 50, 50));
            myBrush.Dispose();
            formGraphics.Dispose();

        }

        private void DrawItRed(int x)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.RoyalBlue);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(myBrush, new Rectangle(x, 150, 50, 50));
            myBrush.Dispose();
            formGraphics.Dispose();

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            loopi = 11;
            space = 10;
            while (loopi > 0)
            {
                space = space + k;
                DrawItBlack(space);
                loopi = loopi - 1;
            }

            
        }

        private void one_Click(object sender, EventArgs e)
        {
            counter++;
            endcounter++;

            loopi = counter;
            while (loopi > 0)
            {
                room = room + k;
                DrawItRed(room);
                loopi = loopi - 1;
            }
            counter = 0;
            if (endcounter >= 11)
            {

                MessageBox.Show("Du hast verloren! ", "Spielende",MessageBoxButtons.OK, MessageBoxIcon.Information);
                space = 10;
                room = 10;
                loopi = 11;
                while (loopi > 0)
                {
                    space = space + k;
                    DrawItBlack(space);
                    loopi = loopi - 1;
                }
                endcounter = 0;

            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (endcounter <= 8)
            {
                counter = 2;
                endcounter = endcounter + 2;
                loopi = counter;
                while (loopi > 0)
                {
                    room = room + k;
                    DrawItRed(room);
                    loopi = loopi - 1;
                }
                counter = 0;
                if (endcounter >= 11)
                {

                    MessageBox.Show("Du hast verloren! ", "Spielende", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    space = 10;
                    room = 10;
                    loopi = 11;
                    while (loopi >= 0)
                    {
                        space = space + k;
                        DrawItBlack(space);
                        loopi = loopi - 1;
                    }
                    endcounter = 0;

                }
            }
            else
            {

                MessageBox.Show("Du hast verloren! ", "Spielende", MessageBoxButtons.OK, MessageBoxIcon.Information);
                space = 10;
                room = 10;
                loopi = 10;
                while (loopi >= 0)
                {
                    space = space + k;
                    DrawItBlack(space);
                    loopi = loopi - 1;
                }
                endcounter = 0;
            }
        }
    

        private void three_Click(object sender, EventArgs e)
        {
            if (endcounter <= 7) {
                counter = 3;
                endcounter = endcounter + 3;
                loopi = counter;
                while (loopi > 0)
                {
                    room = room + k;
                    DrawItRed(room);
                    loopi = loopi - 1;
                }
                counter = 0;
                if (endcounter >= 11)
                {

                    MessageBox.Show("Du hast verloren! ", "Spielende", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    space = 10;
                    room = 10;
                    loopi = 11;
                    while (loopi >= 0)
                    {
                        space = space + k;
                        DrawItBlack(space);
                        loopi = loopi - 1;
                    }
                    endcounter = 0;

                }
            } else {

                MessageBox.Show("Du hast verloren! ", "Spielende", MessageBoxButtons.OK, MessageBoxIcon.Information);
                space = 10;
                room = 10;
                loopi = 10;
                while (loopi >= 0)
                {
                    space = space + k;
                    DrawItBlack(space);
                    loopi = loopi - 1;
                }
                endcounter = 0;
            }
        }
    }
}
