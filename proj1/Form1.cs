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

        private void ButtonClick(object sender, EventArgs e)
        {
            double Num1 = Convert.ToDouble(TextBoxNum1.Text);
            double Num2 = Convert.ToDouble(TextBoxNum2.Text);
            double Result = 0;
            switch (((Button)sender).Name)
            {
                case "ButtonPlus":
                    Result = Num1 + Num2;
                    break;
                case "ButtonMultiply":
                    Result = Num1 * Num2;
                    break;
                case "ButtonMinus":
                    Result = Num1 - Num2;
                    break;
                case "ButtonDivide":
                    Result = Num1 / Num2;
                    break;
            }
            TextBoxResult.Text = Result.ToString();
        }
    }
}
