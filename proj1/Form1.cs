using System;
using System.Windows.Forms;
using proj1.Interfaces;

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
            try
            {
                double firstNumber = Convert.ToDouble(TextBoxNumber1.Text);
                double secondNumber = Convert.ToDouble(TextBoxNumber2.Text);
                string buttonName = ((Button) sender).Name;
                ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(buttonName);
                double result = calculator.Calculate(firstNumber, secondNumber);
                TextBoxResult.Text = result.ToString();
            }
            catch (Exception exc)
            {
                throw new Exception("Некорректный ввод данных");
            }
        }
        private void Button2Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(TextBoxNumber1.Text);
                string buttonName = ((Button) sender).Name;
                ISingleArgumentCalculator calculator = SingleArgumentFactory.CreateCalculator(buttonName);
                double result = calculator.Calculate(firstNumber);
                TextBoxResult.Text = result.ToString();
            }
            catch (Exception exc)
            {
                throw new Exception("Некорректный ввод данных");
            }
        }
    }
}
