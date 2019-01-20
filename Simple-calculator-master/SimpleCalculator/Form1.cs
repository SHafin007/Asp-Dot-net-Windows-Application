using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private int firstNumber;
        private int secondNumber;
        private int result;

        public void Cal()
        {
            firstNumber = Convert.ToInt32( firstNmuberTextBox.Text);
            secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Cal();

            result = firstNumber + secondNumber;
            ResultTextBox.Text = result.ToString();
            ResultTextBox.ReadOnly=true;
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            Cal();

            result = firstNumber - secondNumber;
            ResultTextBox.Text = result.ToString();
            ResultTextBox.ReadOnly = true;
        }

        private void MultButton_Click(object sender, EventArgs e)
        {
            Cal();

            result = firstNumber * secondNumber;
            ResultTextBox.Text = result.ToString();
            ResultTextBox.ReadOnly = true;
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            Cal();

            result = firstNumber / secondNumber;
            ResultTextBox.Text = result.ToString();
            ResultTextBox.ReadOnly = true;
        }

        private void ModButton_Click(object sender, EventArgs e)
        {
            Cal();

            result = firstNumber % secondNumber;
            ResultTextBox.Text = result.ToString();
            ResultTextBox.ReadOnly = true;
        }
    }
}
