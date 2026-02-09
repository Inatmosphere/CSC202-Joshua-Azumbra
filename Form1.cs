using System;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Calculator2 : Form
    {
        // Variables representing first number, second number, and result
        private double firstNumber;
        private double secondNumber;
        private double result;

        public Calculator2()
        {
            InitializeComponent();
        }

        // Try to read inputs into firstNumber and secondNumber
        private bool TryGetInputs()
        {
            bool ok1 = double.TryParse(NumberInput1.Text, out firstNumber); // pulls input from box 1 throws to firstNumber variable
            bool ok2 = double.TryParse(NumberInput2.Text, out secondNumber); // pulls input from box 2 throws to secondNumber variable

            // Conditional #1: invalid first numberw
            if (!ok1)
            {
                MessageBox.Show("First value is not a valid number.");
                return false;
            }

            // Conditional #2: invalid second number
            if (!ok2)
            {
                MessageBox.Show("Second value is not a valid number.");
                return false;
            }

            return true;
        }

        // addition function (has parameters, returns non-void)
        private double Add(double a, double b)
        {
            return a + b;
        }

        // subtraction function
        private double Subtract(double a, double b)
        {
            return a - b;
        }

        // multiplication function
        private double Multiply(double a, double b)
        {
            return a * b;
        }

        // division function (includes extra conditional)
        private double Divide(double a, double b)
        {
            // Conditional #3: division by zero check
            if (b == 0)
            {
                // condition is handled by caller using the return value
                return double.NaN;
            }

            return a / b;
        }

        // ADD button
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs())
                return;

            result = Add(firstNumber, secondNumber); //calls Add function
            MessageBox.Show(result.ToString());
        }

        // SUBTRACT button
        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs())
                return; // prevents invalid input from being used

            result = Subtract(firstNumber, secondNumber); //calls Subtract function
            MessageBox.Show(result.ToString());
        }

        // MULTIPLY button
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs())
                return; // prevents invalid input from being used

            result = Multiply(firstNumber, secondNumber); //calls Multiply function
            MessageBox.Show(result.ToString());
        }

        // DIVIDE button
        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs())
                return; // prevents invalid input from being used

            // conditional to handle divide-by-zero in UI
            if (secondNumber == 0)
            {
                MessageBox.Show("Cannot divide by zero.");
                return; // prevents invalid input from being used
            }

            result = Divide(firstNumber, secondNumber); //calls divide function
            MessageBox.Show(result.ToString());
        }

        private void Calculator2_Load(object sender, EventArgs e)
        {
            // optional initialization code
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // optional validation or live behavior
        }
    }
}
