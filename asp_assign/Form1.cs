using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double Res_value = 0;
        string Operation_performed = "";
        bool isOperation_Performed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") ||(isOperation_Performed) )
                textBox_Result.Clear();
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }else
            textBox_Result.Text = textBox_Result.Text + button.Text;
            isOperation_Performed = false;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (Res_value != 0)
            {
                button16.PerformClick();
                Operation_performed = button.Text;
                label_Current.Text = Res_value + " " + Operation_performed;
                isOperation_Performed = true;
            }
            else
            {
                Operation_performed = button.Text;
                Res_value = double.Parse(textBox_Result.Text);
                label_Current.Text = Res_value + " " + Operation_performed;
                isOperation_Performed = true;
            }   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            Res_value = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (Operation_performed)
            {
                case "+":
                    textBox_Result.Text = (Res_value + double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "-":
                    textBox_Result.Text = (Res_value - double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (Res_value * double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (Res_value / double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            Res_value = Double.Parse(textBox_Result.Text);
            label_Current.Text = "";
        }
    }
}