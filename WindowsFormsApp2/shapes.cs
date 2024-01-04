using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public abstract class shapes : shapeInterface
    {
        protected int x, y;
        public shapes(int x, int y)
        {

            this.x = x;
            this.y = y;

        }

        public shapes()
        {
        }

        public virtual void set(params int[] list)
        {

            this.x = list[0];
            this.y = list[1];

        }
        public virtual void setTriangle(int x, int y, Point[] points)
        {
            this.x = x;
            this.y = y;

        }

        public abstract void Draw(Graphics g, Pen pen, Brush brush);

        public override string ToString()
        {
            return base.ToString() + "    " + this.x + "," + this.y + " : ";
        }

    }
}
