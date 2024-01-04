using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        shapeControl d;
        public Form1()
        {
            InitializeComponent();
            shapeValue.x = shapeValue.y = 0;
            d = new shapeControl();
            d.CurrPoint(false);
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean flg = false;
            if (richTextBox1.Text.Trim() != string.Empty)
            {
                d.runCommands(richTextBox1.Text.Trim());
                richTextBox1.Focus();
                richTextBox1.Text = string.Empty;
                flg = true;
            }
            if (textBox1.Text.Trim() != string.Empty)
            {
                d.runCommands(textBox1.Text.Trim());
                textBox1.Focus();
                textBox1.Text = string.Empty;
                flg = true;
            }
            if (!flg)
            {
                d.PrintMessage("Please enter any command!");
                textBox1.Focus();
            }
            Refresh();
            shapeValue.isFill = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shapeValue.NewPicture = new Bitmap(640, 480);
            d = new shapeControl();
            d.CurrPoint(true);
            Refresh();
        }

        public override void Refresh()
        {
            pictureBox1.Image = shapeValue.NewPicture;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (textBox1.Text.Trim() != string.Empty)
                    d.runCommands(textBox1.Text.Trim());
                else
                    d.PrintMessage("Please enter any command!");

                textBox1.Text = string.Empty;
                Refresh();
                textBox1.Focus();
                shapeValue.isFill = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            shapeValue.NewPicture = new Bitmap(640, 480);
            d = new shapeControl();
            d.CurrPoint(false);
            Refresh();
        }
    }
}
