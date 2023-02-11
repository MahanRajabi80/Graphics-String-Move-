using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_17_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //------------------------------------------------------------------------------------
        private void btnShowAnimate_Click(object sender, EventArgs e)
        {
            if (txtString.Text == "")
            {
                MessageBox.Show("TextBox is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtString.Focus();
                return;
            }
            string moveText = txtString.Text;
            int x=10,stop_y=200;
            Graphics gr = this.CreateGraphics();
            gr.Clear(this.BackColor);
            Font stringFont = new Font("Arial", 50);
            for (int index = 0; index < moveText.Length; index++)//all chars
            {
                int width1Char = (int)gr.MeasureString(moveText[index].ToString(), stringFont).Width;
                int height1Char = (int)gr.MeasureString(moveText[index].ToString(), stringFont).Height;
                for (int y = this.Height; y >= stop_y; y--)
                {
                    gr.DrawString(moveText[index].ToString(), stringFont, Brushes.Black, x, y);
                    for (int k = 0; k <= 1000000; k++) ;//delay
                    if (y != stop_y)
                    {
                        gr.DrawString(moveText[index].ToString(), stringFont, SystemBrushes.Control, x, y);
                    }
                }
                x += width1Char;
            }
        }
    }
}
