using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanTheMinh_dubaothoitiethomnaymua
{
    public partial class Form1 : Form
    {
        double a, b;
        Calculate cal = new Calculate();

        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out a) == false)
                errorProvider1.SetError(textBox1, "Please insert number");
            else
                errorProvider1.Clear();
            cal.A = a;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out b) == false)
                errorProvider2.SetError(textBox2, "Please insert number");
            else
                errorProvider2.Clear();
            cal.B = b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox3.Text = Convert.ToString(cal.Cong());
            }
            else if (radioButton2.Checked)
            {
                textBox3.Text = Convert.ToString(cal.Tru());
            }
            else if (radioButton3.Checked)
            {
                textBox3.Text = Convert.ToString(cal.Nhan());
            }
            else
            {
                if (cal.B == 0)
                {
                    MessageBox.Show("Can not devide 0!", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    textBox3.Text = Convert.ToString(cal.Chia());
            }
        }
    }
}
