using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        double result=0;
        String actionperfomed;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            resuttb.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            resuttb.Text = resuttb.Text + button.Text;
        }

        private void opertaor_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            actionperfomed = button.Text;
            result = Double.Parse(resuttb.Text);
            valulbl.Text = result + "" + actionperfomed;
            resuttb.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (actionperfomed)
            {
                case "+":
                    resuttb.Text = (result + Double.Parse(resuttb.Text)).ToString();
                    break;
                case "-":
                    resuttb.Text = (result - Double.Parse(resuttb.Text)).ToString();
                    break;
                case "*":
                    resuttb.Text = (result * Double.Parse(resuttb.Text)).ToString();
                    break;
                case "/":
                    resuttb.Text = (result / Double.Parse(resuttb.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
