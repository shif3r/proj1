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
            double firstNumber = Convert.ToDouble(TextBoxNumber1.Text);
            double secondNumber = Convert.ToDouble(TextBoxNumber2.Text);
            double result = 0;
            switch (((Button)sender).Name)
            {
                case "Plus":
                    result = firstNumber + secondNumber;
                    break;
                case "Multiply":
                    result = firstNumber * secondNumber;
                    break;
                case "Minus":
                    result = firstNumber - secondNumber;
                    break;
                case "Divide":
                    result = firstNumber / secondNumber;
                    break;
            }
            TextBoxResult.Text = result.ToString();
        }
    }
}
