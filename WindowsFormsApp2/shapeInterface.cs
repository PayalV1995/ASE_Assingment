using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    interface  shapeInterface
    {
        void set(params int[] list);
        void setTriangle(int x, int y, Point[] points);
        void Draw(Graphics g, Pen pen, Brush brush);
    }
}
