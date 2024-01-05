using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class DrawTriangle : shapes
    {
        private Point[] pnt;
        public DrawTriangle(Point[] pnt)
        {

            this.pnt = pnt;
        }
        public DrawTriangle() { }

        public override void setTriangle(int x, int y, Point[] points)
        {
            base.set(x, y);
            this.pnt = points;
        }
        public override void Draw(Graphics g, Pen pen, Brush brush)
        {

            g.DrawPolygon(pen, pnt);
            g.FillPolygon(brush, pnt);
        }
    }
}
