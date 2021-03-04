using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLabWork2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
            {
                Width += 10; Height += 10;
            }
            if (e.KeyChar == '-')
            {
                Width -= 10; Height -= 10;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.X) Close();
                if (e.KeyCode == Keys.Left) Left -= 5;
                if (e.KeyCode == Keys.Right) Left += 5;
            }
        }
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Green_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Поменять цвет?", "Форма запроса", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                BackColor = Color.Green;
        }
        private void Gray_Click(object sender, EventArgs e)
        {
            BackColor = Color.Gray;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Cursor = Cursors.Default;
                    break;
                case 1:
                    Cursor = Cursors.Hand;
                    break;
                case 2:
                    Cursor = Cursors.AppStarting;
                    break;
                case 3:
                    Cursor = Cursors.WaitCursor;
                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = checkBox1.Checked;
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            Exit.Visible = !checkBox2.Checked;
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = !checkBox3.Checked;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    BackColor = Color.White;
                    break;
                case 1:
                    BackColor = Color.Red;
                    break;
                case 2:
                    BackColor = Color.Green;
                    break;
                case 3:
                    BackColor = Color.Blue;
                    break;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
