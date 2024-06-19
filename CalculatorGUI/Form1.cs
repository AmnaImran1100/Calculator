using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        bool operationperformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operationperformed))
            {
                txtResult.Clear();
            }
            operationperformed = false;
            Button button = (Button)sender;
            if (button.Text.Contains("."))
            {
                if (!txtResult.Text.Contains("."))
                {
                    txtResult.Text = txtResult.Text + button.Text;
                }
            }
            else
            {
                txtResult.Text = txtResult.Text + button.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                button18.PerformClick();
                operation = button.Text;
                lblCurrentOperation.Text = result + " " + operation;
                operationperformed = true;
            }
            else
            {
                operation = button.Text;
                result = double.Parse(txtResult.Text);
                lblCurrentOperation.Text = result + " " + operation;
                operationperformed = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            result = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    txtResult.Text = (result + double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (result - double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (result * double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (result / double.Parse(txtResult.Text)).ToString();
                    break;
            }
            result = double.Parse(txtResult.Text);
            lblCurrentOperation.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
