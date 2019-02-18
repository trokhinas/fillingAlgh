using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Pixel
    {
        public int X { get => X; set => X = value; }
        public int Y { get => Y; set => Y = value; }
        public int Width { get => Width; set => Width = value; }
        public int Height { get => Height; set => Height = value; }

        public Pixel(MouseEventArgs e, int width, int height)
        {
            X = Convert.ToInt32(e.X);
            Y = Convert.ToInt32(e.Y);
            Width = width;
            Height = height;
        }


        public void Fill()
        {

        }
    }
}
