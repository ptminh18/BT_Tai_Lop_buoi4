using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanTheMinh_dubaothoitiet
{
    public partial class Form1 : Form
    {
        double a, b, c;
        PT_bac_1 ptb1 = new PT_bac_1();
        PT_bac_2 ptb2 = new PT_bac_2();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out a) == false)
                errorProvider1.SetError(textBox1, "Please insert number!");
            else
                errorProvider1.Clear();
            ptb1.A = a;
            ptb2.A = a;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out b) == false)
                errorProvider2.SetError(textBox2, "Please insert number!");
            else
                errorProvider2.Clear();
            ptb1.B = b;
            ptb2.B = b;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox3.Text, out c) == false)
                errorProvider3.SetError(textBox3, "Please insert number!");
            else
                errorProvider3.Clear();
            ptb2.C = c;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label4.Enabled = false;
                textBox3.Enabled = false;
            }
            else
            {
                label4.Enabled = true;
                textBox3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //phuong trinh bac 1
            if (radioButton1.Checked == true)
            {
                if (ptb1.A == 0)
                    MessageBox.Show("Can not devide 0!!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                else
                {
                    textBox4.Text = Convert.ToString(ptb1.Calculate());
                }
            }
            //phuong trinh bac 2
            else
            {
                if (ptb2.Calculate() == 1)
                {
                    textBox4.Text = "Vô nghiệm!";
                }
                else if (ptb2.Calculate() == 2)
                {
                    double x = -ptb2.B / (2 * ptb2.A);
                    textBox4.Text = "x1=x2= " + Convert.ToString(x);
                }
                else if (ptb2.Calculate() ==3)
                {
                    double x1 = (-ptb2.B + Math.Sqrt(ptb2.Delta)) / (2 * ptb2.A);
                    double x2 = (-ptb2.B - Math.Sqrt(ptb2.Delta)) / (2 * ptb2.A);
                    textBox4.Text = "x1 = " + Convert.ToString(x1) + " x2= " + Convert.ToString(x2);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                Close();
        }
    }
}
