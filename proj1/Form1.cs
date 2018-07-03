using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            double Num1 = Convert.ToDouble(TextBoxNum1.Text);
            double Num2 = Convert.ToDouble(TextBoxNum2.Text);
            double Result = Num1 + Num2;
            TextBoxResult.Text = Result.ToString();
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            double Num1 = Convert.ToDouble(TextBoxNum1.Text);
            double Num2 = Convert.ToDouble(TextBoxNum2.Text);
            double Result = Num1 - Num2;
            TextBoxResult.Text = Result.ToString();
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            double Num1 = Convert.ToDouble(TextBoxNum1.Text);
            double Num2 = Convert.ToDouble(TextBoxNum2.Text);
            double Result = Num1 * Num2;
            TextBoxResult.Text = Result.ToString();
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            double Num1 = Convert.ToDouble(TextBoxNum1.Text);
            double Num2 = Convert.ToDouble(TextBoxNum2.Text);
            double Result = Num1 / Num2;
            TextBoxResult.Text = Result.ToString();
        }
    }
}
