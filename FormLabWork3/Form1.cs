using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLabWork3
{
    public partial class Form1 : Form
    {
        int Oper = 0;
        Double Value = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Edit1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "1";
            else textBox1.Text = textBox1.Text + "1";
        }
        private void Edit2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "2";
            else textBox1.Text = textBox1.Text + "2";
        }
        private void Edit3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "3";
            else textBox1.Text = textBox1.Text + "3";
        }
        private void Edit4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "4";
            else textBox1.Text = textBox1.Text + "4";
        }
        private void Edit5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "5";
            else textBox1.Text = textBox1.Text + "5";
        }
        private void Edit6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "6";
            else textBox1.Text = textBox1.Text + "6";
        }
        private void Edit7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "7";
            else textBox1.Text = textBox1.Text + "7";
        }
        private void Edit8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "8";
            else textBox1.Text = textBox1.Text + "8";
        }
        private void Edit9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "9";
            else textBox1.Text = textBox1.Text + "9";
        }
        private void Edit0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "0";
            else textBox1.Text = textBox1.Text + "0";
        }
        private void fraction_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.LastIndexOf(',') < 0)
                textBox1.Text = textBox1.Text + ",";
        }
        private void minus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0] == '-')
                textBox1.Text = textBox1.Text.Remove(0, 1);
            else textBox1.Text = "-" + textBox1.Text;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 0);
                }
            }
        }
        private void equate_Click(object sender, EventArgs e) // '='
        {
            Double Value2 = Convert.ToDouble(textBox1.Text);
            Double Result = Value2;
            switch (Oper)
            {
                case 1:
                    Result = Value + Value2;
                    break;
                case 2:
                    Result = Value - Value2;
                    break;
                case 3:
                    Result = Value * Value2;
                    break;
                case 4:
                    Result = Value / Value2;
                    break;
            }
            textBox1.Text = Result.ToString();
            Value = 0;
            Oper = 0;
        }
        private void sum_Click(object sender, EventArgs e) // '+'
        {
            Value = Convert.ToDouble(textBox1.Text);
            Oper = 1;
            textBox1.Text = "0";
        }
        private void subtract_Click(object sender, EventArgs e) // '-'
        {
            Value = Convert.ToDouble(textBox1.Text);
            Oper = 2;
            textBox1.Text = "0";
        }
        private void multiply_Click(object sender, EventArgs e) // '*'
        {
            Value = Convert.ToDouble(textBox1.Text);
            Oper = 3;
            textBox1.Text = "0";
        }
        private void div_Click(object sender, EventArgs e) // '/'
        {;
            Value = Convert.ToDouble(textBox1.Text);
            Oper = 4;
            textBox1.Text = "0";
        }
    }
}