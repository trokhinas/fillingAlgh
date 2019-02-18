using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Color colorCurrentBox = Color.Gray;
        private int stepWidth = 0;
        private int stepHeight = 0;
        private Boolean mouseDown = false;
        private Point lastPoint;
        enum mode
        {
            fill,
            fillCell,
            line
        };
        private mode currentMode = mode.line;
        
        public int cellCount
        {
            get
            {
                int x = Convert.ToInt32(CellXUpDown.Value);
                int y = Convert.ToInt32(CellYUpDown.Value);
                return x * y;
            }
        }
        
        public Form1()
        {
            InitializeComponent();
            DrawingArea.Image = new Bitmap(DrawingArea.Width, DrawingArea.Height);
            updateCellLabel();
            updateModeLabel();
        }

        private void ColorDialog_Click(object sender, EventArgs e)
        {
         
           colorDialog1.AllowFullOpen = false;
           colorDialog1.ShowHelp = true;
          // colorDialog1.Color = colorCurrentBox;
           if (colorDialog1.ShowDialog() == DialogResult.OK)
               colorCurrentBox = colorDialog1.Color;
           CurrentColorPictBox.BackColor = colorCurrentBox;
// }
        }



        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = Convert.ToInt32(e.X); // координата по оси X
            int y = Convert.ToInt32(e.Y); // координата по оси Y
            PositionLabel.Text = x.ToString() + ',' + y.ToString();
            if(mouseDown)
            {
                using(Graphics g = Graphics.FromImage(DrawingArea.Image))
                {
                    Pen myPen = new Pen(colorCurrentBox, 1);
                    if(lastPoint.X != e.X && lastPoint.Y != e.Y)
                    {
                        g.DrawLine(myPen, lastPoint.X, lastPoint.Y, e.X, e.Y);
                        lastPoint.X = e.X;
                        lastPoint.Y = e.Y;
                    }
                        
                }
                DrawingArea.Refresh();
            }
        }

        private void CellXUpDown_ValueChanged(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(DrawingArea.Image))
            {
                g.Clear(DrawingArea.BackColor);
                drawVertical(g);
                drawHorizontal(g);
            }

            DrawingArea.Refresh();
            updateCellLabel();
        }
        private void CellYUpDown_ValueChanged(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(DrawingArea.Image))
            {
                g.Clear(DrawingArea.BackColor);
                drawVertical(g);
                drawHorizontal(g);
            }

            DrawingArea.Refresh();
            updateCellLabel();
        }

        private void drawHorizontal(Graphics g)
        {
            int boxWidth = DrawingArea.Width;
            int boxHeight = DrawingArea.Height;
            int boxStepHeight = Convert.ToInt32(CellYUpDown.Value);
            stepHeight = boxHeight / boxStepHeight;

            Pen myPen = new Pen(Color.Gray, 1);
            for (int i = 1; i < boxStepHeight; i++)
            {
                g.DrawLine(myPen, 0, i * stepHeight, boxWidth, i * stepHeight);
            }

        }
        private void drawVertical(Graphics g)
        {
            int boxWidth = DrawingArea.Width;
            int boxHeight = DrawingArea.Height;
            int boxStepWidth = Convert.ToInt32(CellXUpDown.Value);
            stepWidth = boxWidth / boxStepWidth;

            Pen myPen = new Pen(Color.Gray, 1);
            for (int i = 1; i < boxStepWidth; i++)
            {
                g.DrawLine(myPen, i * stepWidth, 0, i * stepWidth, boxHeight);
            }
        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
           if(currentMode == mode.fillCell)
            {
                isAlreadyFilled(e.X, e.Y, colorCurrentBox);
                fillCell(e);
                isAlreadyFilled(e.X, e.Y, colorCurrentBox);
            }
           else if(currentMode == mode.fill)
            {
                fill(e);
            }
        }



        private void fillCell(MouseEventArgs e) 
        {
            //SolidBrush - сплошная закраска цветом кисти;
            //TextureBrush - наложение картинки (image) на область закраски;
            //HatchBrush - закраска области предопределенным узором;
            //LinearGradientBrush - сплошная закраска c переходом цвета кисти (градиентная закраска);
            //PathGradientBrush -сплошная закраска c переходом цвета кисти по специальному алгоритму.

            int x = Convert.ToInt32(e.X); // координата по оси X
            int y = Convert.ToInt32(e.Y); // координата по оси Y  
            SolidBrush myBrush;
            if (isAlreadyFilled(x, y, colorCurrentBox))
                myBrush = new SolidBrush(DrawingArea.BackColor);
            else
                myBrush = new SolidBrush(colorCurrentBox);


            int boxWidth = DrawingArea.Width;
            int boxHeight = DrawingArea.Height;

            int XCellCount = Convert.ToInt32(CellXUpDown.Value);
            int cellWidth = boxWidth / XCellCount;

            int YCellCount = Convert.ToInt32(CellYUpDown.Value);
            int cellHeight = boxHeight / YCellCount;

                 


            x = x / cellWidth;
            y = y / cellHeight;
            using (Graphics g = Graphics.FromImage(DrawingArea.Image))
            {
                g.FillRectangle(myBrush, x * cellWidth, y * cellHeight, cellWidth, cellHeight);
            }
            DrawingArea.Refresh();
        }
        private void fill(MouseEventArgs e)
        {
            using (Graphics g = Graphics.FromImage(DrawingArea.Image))
            {
                FloodFill(DrawingArea.Image as Bitmap, e.X, e.Y, colorCurrentBox);
                DrawingArea.Refresh();
            }
                
        }

        private void FillModeButton_Click(object sender, EventArgs e)
        {
            currentMode = mode.fill;
            updateModeLabel();
        }
        private void FillCellModeButton_Click(object sender, EventArgs e)
        {
            currentMode = mode.fillCell;
            updateModeLabel();
        }
        private void LineModeButton_Click(object sender, EventArgs e)
        {
            currentMode = mode.line;
            updateModeLabel();
        }
        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void updateModeLabel()
        {
            ModeLabel.Text = "Current mode is " + currentMode.ToString();
        }
        private void updateCellLabel()
        {
            CellCountLabel.Text = "Cell count = " + cellCount;
        }


        void FloodFill(Bitmap bitmap, int x, int y, Color color)
        {
            BitmapData data = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            int[] bits = new int[data.Stride / 4 * data.Height];
            Marshal.Copy(data.Scan0, bits, 0, bits.Length);

            LinkedList<Point> check = new LinkedList<Point>();
            int floodTo = color.ToArgb();
            int floodFrom = bits[x + y * data.Stride / 4];
            bits[x + y * data.Stride / 4] = floodTo;

            if (floodFrom != floodTo)
            {
                check.AddLast(new Point(x, y));
                while (check.Count > 0)
                {
                    Point cur = check.First.Value;
                    check.RemoveFirst();

                    foreach (Point off in new Point[] {
                new Point(0, -1), new Point(0, 1),
                new Point(-1, 0), new Point(1, 0)})
                    {
                        Point next = new Point(cur.X + off.X, cur.Y + off.Y);
                        if (next.X >= 0 && next.Y >= 0 &&
                            next.X < data.Width &&
                            next.Y < data.Height)
                        {
                            if (bits[next.X + next.Y * data.Stride / 4] == floodFrom)
                            {
                                check.AddLast(next);
                                bits[next.X + next.Y * data.Stride / 4] = floodTo;
                            }
                        }
                    }
                }
            }

            Marshal.Copy(bits, 0, data.Scan0, bits.Length);
            bitmap.UnlockBits(data);
        }

        private void DrawingArea_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastPoint = new Point(e.X, e.Y);
        }

        private void DrawingArea_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private bool isAlreadyFilled(int x, int y, Color color)
        {
            Color colour = (DrawingArea.Image as Bitmap).GetPixel(x, y);
            bool answer = colour.B == color.B && colour.G == color.G && colour.R == color.R;

            Console.WriteLine($"({x}, {y}) {answer} oldColor: {colour}, newColor: {color}");

            return answer;
        }

        
    }
}
