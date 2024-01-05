using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class DrawRectangle : shapes
    {

        private int width;
        private int height;

        public DrawRectangle(int x, int y, int width, int height) : base(x, y)
        {

            this.width = width;
            this.height = height;
        }
        public DrawRectangle() { }
        public override void set(params int[] list)
        {
            base.set(list[0], list[1]);
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics g, Pen pen, Brush brush)
        {
            g.FillRectangle(brush, x, y, width, height);
            g.DrawRectangle(pen, x, y, width, height);
        }
    }
}
