using System;
using System.Windows.Forms;

namespace Calculator2
{
    partial class Calculator2 : Form
    {
        public Calculator2()
        {
            InitializeComponent();
        }


        private bool TryGetInputs(out double a, out double b)
        {
            if (!double.TryParse(NumberInput1.Text, out a))
            {
                MessageBox.Show("First value is not a valid number.");
                b = 0;
                return false;
            }

            if (!double.TryParse(NumberInput2.Text, out b))
            {
                MessageBox.Show("Second value is not a valid number.");
                return false;
            }

            return true;
        }

        //add
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b)) return;
            double result = a + b;
            MessageBox.Show(result.ToString());
        }

        //minus
        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b)) return;
            double result = a - b;
            MessageBox.Show(result.ToString());
        }

        //times
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b)) return;
            double result = a * b;
            MessageBox.Show(result.ToString());
        }

        //divide
        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b)) return;

            

            double result = a / b;
            MessageBox.Show(result.ToString());
        }


        private void Calculator2_Load(object sender, EventArgs e)
        {
            //initialization code
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //validation or live behavior
        }
    }
}
