using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Color colorCurrentBox = Color.Gray;
        private int stepWidth = 0;
        private int stepHeight = 0;
        enum mode
        {
            fill,
            click
        };
        private mode currentMode = mode.click;
        
        public int cellCount
        {
            get
            {
                int x = Convert.ToInt32(numericUpDown1.Value);
                int y = Convert.ToInt32(numericUpDown2.Value);
                return x * y;
            }
        }
        
        public Form1()
        {
            InitializeComponent();
            updateCellLabel();
            updateModeLabel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
           colorDialog1.AllowFullOpen = false;
           colorDialog1.ShowHelp = true;
          // colorDialog1.Color = colorCurrentBox;
           if (colorDialog1.ShowDialog() == DialogResult.OK)
               colorCurrentBox = colorDialog1.Color;
           pictureBox2.BackColor = colorCurrentBox;
// }
        }



        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = Convert.ToInt32(e.X); // координата по оси X
            int y = Convert.ToInt32(e.Y); // координата по оси Y
            label1.Text = x.ToString() + ',' + y.ToString();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {    
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            g.Clear(pictureBox1.BackColor);
            drawVertical(g);
            drawHorizontal(g);

            updateCellLabel();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            g.Clear(pictureBox1.BackColor);
            drawHorizontal(g);
            drawVertical(g);

            updateCellLabel();
        }

        private void drawHorizontal(Graphics g)
        {
            int boxWidth = pictureBox1.Width;
            int boxHeight = pictureBox1.Height;
            int boxStepHeight = Convert.ToInt32(numericUpDown2.Value);
            stepHeight = boxHeight / boxStepHeight;

            Pen myPen = new Pen(Color.Gray, 1);
            for (int i = 1; i < boxStepHeight; i++)
            {
                g.DrawLine(myPen, 0, i * stepHeight, boxWidth, i * stepHeight);
            }

        }
        private void drawVertical(Graphics g)
        {
            int boxWidth = pictureBox1.Width;
            int boxHeight = pictureBox1.Height;
            int boxStepWidth = Convert.ToInt32(numericUpDown1.Value);
            stepWidth = boxWidth / boxStepWidth;

            Pen myPen = new Pen(Color.Gray, 1);
            for (int i = 1; i < boxStepWidth; i++)
            {
                g.DrawLine(myPen, i * stepWidth, 0, i * stepWidth, boxHeight);
            }
        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
           if(currentMode == mode.click)
            {
                fillOne(e);
            }
           else
            {
                fill(e);
            }
        }

        private void fillOne(MouseEventArgs e) 
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            //SolidBrush - сплошная закраска цветом кисти;
            //TextureBrush - наложение картинки (image) на область закраски;
            //HatchBrush - закраска области предопределенным узором;
            //LinearGradientBrush - сплошная закраска c переходом цвета кисти (градиентная закраска);
            //PathGradientBrush -сплошная закраска c переходом цвета кисти по специальному алгоритму.
            SolidBrush myBrush = new SolidBrush(colorCurrentBox);


            int boxWidth = pictureBox1.Width;
            int boxHeight = pictureBox1.Height;

            int boxStepWidth = Convert.ToInt32(numericUpDown1.Value);
            int stepWidth = boxWidth / boxStepWidth;

            int boxStepHeight = Convert.ToInt32(numericUpDown2.Value);
            int stepHeight = boxHeight / boxStepHeight;

            int x = Convert.ToInt32(e.X); // координата по оси X
            int y = Convert.ToInt32(e.Y); // координата по оси Y           


            x = x / stepWidth;
            y = y / stepHeight;
            g.FillRectangle(myBrush, x * stepWidth, y * stepHeight, stepWidth, stepHeight);
        }

        private void fill(MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentMode = mode.fill;
            updateModeLabel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentMode = mode.click;
            updateModeLabel();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void updateModeLabel()
        {
            label5.Text = "Current mode is " + (currentMode == mode.click ? "fillOne" : "fill");
        }
        private void updateCellLabel()
        {
            label2.Text = "Cell count = " + cellCount;
        }
    }
}
