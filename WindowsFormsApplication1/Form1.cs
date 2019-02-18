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
        enum Mode
        {
            Fill,
            FillCell
        };
        private Mode currentMode = Mode.FillCell;
        public int CellCount
        {
            get
            {
                int x = Convert.ToInt32(XUpDown.Value);
                int y = Convert.ToInt32(YUpDown.Value);
                return x * y;
            }
        }
        public int CellWidth
        {

            get
            {
                int cellCountX = Convert.ToInt32(XUpDown.Value);
                return DrawingArea.Width / cellCountX;
            }
        }
        public int CellHeight
        {

            get
            {
                int cellCountY = Convert.ToInt32(YUpDown.Value);
                return DrawingArea.Height / cellCountY;
            }
        }

        public Form1()
        {
            InitializeComponent();
            DrawingArea.Image = new Bitmap(DrawingArea.Width, DrawingArea.Height);
            UpdateCellLabel();
            UpdateModeLabel();
        }

        private void ColorDialog_Click(object sender, EventArgs e)
        {
         
           colorDialog1.AllowFullOpen = false;
           colorDialog1.ShowHelp = true;
          // colorDialog1.Color = colorCurrentBox;
           if (colorDialog1.ShowDialog() == DialogResult.OK)
               colorCurrentBox = colorDialog1.Color;
           pictureBox2.BackColor = colorCurrentBox;
// }
        }



        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = Convert.ToInt32(e.X); // координата по оси X
            int y = Convert.ToInt32(e.Y); // координата по оси Y
            PositionLabel.Text = x.ToString() + ',' + y.ToString();

        }




        private void CellCountX_ValueChanged(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(DrawingArea.Image))
            {
                g.Clear(DrawingArea.BackColor);
                DrawVertical(g);
                DrawHorizontal(g);
            }
            UpdateCellLabel();
            DrawingArea.Refresh();
        }
        private void CellCountY_ValueChanged(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(DrawingArea.Image))
            {
                g.Clear(DrawingArea.BackColor);
                DrawHorizontal(g);
                DrawVertical(g);
            }
            UpdateCellLabel();
            DrawingArea.Refresh();
        }





        private void DrawHorizontal(Graphics g)
        {
            int boxWidth = DrawingArea.Width;
            int boxHeight = DrawingArea.Height;
            int boxStepHeight = Convert.ToInt32(YUpDown.Value);
            stepHeight = boxHeight / boxStepHeight;

            Pen myPen = new Pen(Color.Gray, 1);
            for (int i = 1; i < boxStepHeight; i++)
            {
                g.DrawLine(myPen, 0, i * stepHeight, boxWidth, i * stepHeight);
            }
         
        }
        private void DrawVertical(Graphics g)
        {
            int boxWidth = DrawingArea.Width;
            int boxHeight = DrawingArea.Height;
            int boxStepWidth = Convert.ToInt32(XUpDown.Value);
            stepWidth = boxWidth / boxStepWidth;

            Pen myPen = new Pen(Color.Gray, 1);
            for (int i = 1; i < boxStepWidth; i++)
            {
                g.DrawLine(myPen, i * stepWidth, 0, i * stepWidth, boxHeight);
            }
        }


        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
           var point = new Point(e.X, e.Y);
           if(currentMode == Mode.FillCell)
            {
                FillOne(point);
            }
           else
            {
                Fill(point);
            }
        }
        private void FillOne(Point e) 
        {
            if (!IsPointInArea(e))
                return;
            //SolidBrush - сплошная закраска цветом кисти;
            //TextureBrush - наложение картинки (image) на область закраски;
            //HatchBrush - закраска области предопределенным узором;
            //LinearGradientBrush - сплошная закраска c переходом цвета кисти (градиентная закраска);
            //PathGradientBrush -сплошная закраска c переходом цвета кисти по специальному алгоритму.
            int x = Convert.ToInt32(e.X); // координата по оси X
            int y = Convert.ToInt32(e.Y); // координата по оси Y
            var pixelColor = PixelColor(x, y);
            SolidBrush myBrush;
                myBrush = new SolidBrush(colorCurrentBox);
           

            x = x / CellWidth;
            y = y / CellHeight;

            using (Graphics g = Graphics.FromImage(DrawingArea.Image))
            {
                g.FillRectangle(myBrush, x * CellWidth, y * CellHeight, CellWidth, CellHeight);
            }
            DrawingArea.Refresh();

        }
        private void Fill(Point point)
        {
            Stack<Point> stack = new Stack<Point>();
            stack.Push(point);
            int startColor = PixelColor(point.X, point.Y);

            while(stack.Count != 0)
            {
                var cell = stack.Pop();
                if (!IsPointInArea(cell))
                    continue;
                if(!IsAlreadyFilled(cell) && startColor == PixelColor(cell))
                {
                    FillOne(cell);
                    stack.Push(new Point(cell.X, cell.Y - CellHeight));
                    stack.Push(new Point(cell.X, cell.Y + CellHeight));
                    stack.Push(new Point(cell.X + CellWidth, cell.Y));
                    stack.Push(new Point(cell.X - CellWidth, cell.Y));
                }
            }
        }




        private void FillModeButton_Click(object sender, EventArgs e)
        {
            currentMode = Mode.Fill;
            UpdateModeLabel();
        }
        private void FillOneModeButton_Click(object sender, EventArgs e)
        {
            currentMode = Mode.FillCell;
            UpdateModeLabel();
        }

      

        private void UpdateModeLabel()
        {
            FillLabel.Text = "Current mode is " + currentMode.ToString();
        }
        private void UpdateCellLabel()
        {
            CellCountLabel.Text = "Cell count = " + CellCount;
        }

        private int PixelColor(Point point)
        {
            return PixelColor(point.X, point.Y);
        }
        private int PixelColor(int x, int y)
        {
            Bitmap bitmap = DrawingArea.Image as Bitmap;
            Color c = bitmap.GetPixel(x, y);
            return c.ToArgb();
        }
        private bool IsAlreadyFilled(int x, int y, Color color)
        {
            Bitmap bitmap = DrawingArea.Image as Bitmap;

            Color colour = bitmap.GetPixel(x, y);
            bool answer = colour.ToArgb() == color.ToArgb();
            Console.WriteLine($"({x}, {y}) {answer} oldColor: {colour}, newColor: {color}");

            return answer;
        }
        private bool IsAlreadyFilled(Point point, Color color)
        {
            return IsAlreadyFilled(point.X, point.Y, color);
        }
        private bool IsAlreadyFilled(int x, int y)
        {
            Bitmap bitmap = DrawingArea.Image as Bitmap;

            Color colour = bitmap.GetPixel(x, y);
            bool answer = colour.ToArgb() == colorCurrentBox.ToArgb();
            Console.WriteLine($"({x}, {y}) {answer} oldColor: {colour}, newColor: {colorCurrentBox}");

            return answer;
        }
        private bool IsAlreadyFilled(Point point)
        {
            return IsAlreadyFilled(point.X, point.Y);
        }


        private bool IsPointInArea(int x, int y)
        {
            return x >= 0 && y >= 0 && x <= DrawingArea.Width && y <= DrawingArea.Height;
        }
        private bool IsPointInArea(Point point)
        {
            return IsPointInArea(point.X, point.Y);
        }
    }
}
