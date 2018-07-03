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
            double Number1 = Convert.ToDouble(TextBoxNumber1.Text);
            double Number2 = Convert.ToDouble(TextBoxNumber2.Text);
            double Result = 0;
            switch (((Button)sender).Name)
            {
                case "Plus":
                    Result = Number1 + Number2;
                    break;
                case "Multiply":
                    Result = Number1 * Number2;
                    break;
                case "Minus":
                    Result = Number1 - Number2;
                    break;
                case "Divide":
                    Result = Number1 / Number2;
                    break;
            }
            TextBoxResult.Text = Result.ToString();
        }
    }
}
