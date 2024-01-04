using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class canvass
    {
        //Graphics variable to execute graphics fuction
        Graphics g;
        //declaire pen variable
        Pen p;
        //declare two integer variable x and y which show currunt position of ponter 
        int x, y;
        //declare current position recangle to show current pointer
        Rectangle CuurPos;
        //declare current shape recangle to for getting current shape
        Rectangle CurrShape;

        public canvass()
        {
            //Initialize graphics instance and asign value Bitmap value 
            this.g = Graphics.FromImage(shapeValue.NewPicture);
            //Initializa pen as black
            p = new Pen(Color.Black, 1);
            //Assign Value to x and y from get set method
            x = shapeValue.x;
            y = shapeValue.y;
        }

        public void DrawLine(int xpos, int ypos)
        {
            try
            {
                //check line have color or not
                if (shapeValue.isFill)
                {
                    //Re initialize pen with new color and draw line 
                    p = new Pen(shapeValue.penColor, 1);
                    this.g.DrawLine(p, x, y, xpos, ypos);
                }
                else
                    //Draw black line
                    this.g.DrawLine(p, x, y, xpos, ypos);
                //Set pen color default as black
                p = new Pen(Color.Black, 1);
                //Set value if function run successfully for unit testing
                shapeValue.isUnitTestValid = true;
            }
            catch (Exception ex)
            {
                //print message if any run time error occure
                PrintMessage(ex.Message);
                shapeValue.isUnitTestValid = false;
            }

        }

        public void DrawSquare(int width)
        {
            try
            {
                int xpos = x - (width / 2);
                int ypos = y - (width / 2);
                CurrShape = new Rectangle(xpos, ypos, width, width);
                if (shapeValue.isFill)
                    this.g.FillRectangle(shapeValue.FillColor, CurrShape);
                this.g.DrawRectangle(p, CurrShape);
                shapeValue.isUnitTestValid = true;
            }
            catch (Exception ex)
            {
                PrintMessage(ex.Message);
                shapeValue.isUnitTestValid = false;
            }
        }

        public void DrawRect(int width, int height)
        {
            try
            {
                int xpos = x - (width / 2);
                int ypos = y - (height / 2);
                CurrShape = new Rectangle(xpos, ypos, width, height);
                if (shapeValue.isFill)
                    this.g.FillRectangle(shapeValue.FillColor, CurrShape);
                this.g.DrawRectangle(p, CurrShape);
                shapeValue.isUnitTestValid = true;
            }
            catch (Exception ex)
            {
                PrintMessage(ex.Message);
                shapeValue.isUnitTestValid = false;
            }
        }

        public void DrawCircle(int width)
        {
            try
            {
                int xpos = x - (width / 2);
                int ypos = y - (width / 2);
                CurrShape = new Rectangle(xpos, ypos, width, width);
                if (shapeValue.isFill)
                    this.g.FillEllipse(shapeValue.FillColor, CurrShape);
                this.g.DrawEllipse(p, xpos, ypos, width, width);
                shapeValue.isUnitTestValid = true;
            }
            catch (Exception ex)
            {
                PrintMessage(ex.Message);
                shapeValue.isUnitTestValid = false;
            }
        }

        public void MovePoint(int xpos, int ypos)
        {
            try
            {
                p = new Pen(SystemColors.ActiveBorder, 2);
                this.g.DrawRectangle(p, CuurPos);
                p = new Pen(Color.Red, 2);
                CuurPos = GetRectangle(xpos, ypos, 2, 2);
                this.g.DrawRectangle(p, CuurPos);
                x = shapeValue.x = xpos;
                y = shapeValue.y = ypos;
                p = new Pen(Color.Black, 1);
                shapeValue.isUnitTestValid = true;
            }
            catch (Exception ex)
            {
                PrintMessage(ex.Message);
                shapeValue.isUnitTestValid = false;
            }
        }

        public void DrawTriangle(int xpos, int ypos, int zpos)
        {
            try
            {
                int tx, ty, cx, cy;
                cx = Convert.ToInt32(x - (xpos / 3));
                cy = Convert.ToInt32(y - (ypos / 3));
                tx = Convert.ToInt32(cx + xpos);
                ty = Convert.ToInt32(cy + ypos);

                Point[] points = new Point[3];
                points[0] = new Point(cx, cy);
                points[1] = new Point(tx, cy);
                points[2] = new Point(cx, ty);
                if (shapeValue.isFill)
                    this.g.FillPolygon(shapeValue.FillColor, points);
                this.g.DrawPolygon(p, points);
                shapeValue.isUnitTestValid = true;
            }
            catch (Exception ex)
            {
                PrintMessage(ex.Message);
                shapeValue.isUnitTestValid = false;
            }
        }

        public void CurrPoint(Boolean flg)
        {
            p = new Pen(Color.Red, 2);
            if (flg)
            {
                CuurPos = GetRectangle(shapeValue.x, shapeValue.y, 2, 2);
                this.g.DrawRectangle(p, CuurPos);
            }
            else
            {
                x = y = 0;
                shapeValue.x = shapeValue.y = 0;
                CuurPos = GetRectangle(x, y, 2, 2);
                this.g.DrawRectangle(p, CuurPos);
            }
            p = new Pen(Color.Black, 1);
        }

        public void PrintMessage(String ErrMsg)
        {
            using (Font myFont = new Font("Arial", 8))
            {
                g.DrawString(ErrMsg, myFont, Brushes.Black, new Point(5, 5));
            }
        }

        private Rectangle GetRectangle(int rx, int ry, int rwidth, int rheight)
        {
            return new Rectangle(rx, ry, rwidth, rheight);
        }
    }
}
