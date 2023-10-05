using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD

namespace PhanTheMinh_dubaothoitiethomnaymua
{
    public partial class Form1 : Form
    {
        double a, b;
        Calculate cal = new Calculate();

=======
using System.Text.RegularExpressions;//Thư viện kiểm tra số

namespace bai2
{
    public partial class Form1 : Form
    {
        Mang mang = new Mang();
        int[] arr = new int[10];
        string s, s1;
        int n = 0, i, c;
>>>>>>> 68fb493 (bai 2)
        public Form1()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
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
=======
        //Kiem tra so nguyen
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox10.Text = mang.TongMang(arr, n).ToString();
            textBox11.Text = mang.TongChan(arr, n).ToString();
            textBox12.Text = mang.TongLe(arr, n).ToString();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked ==true)
            {
                for (int i = 0; i < n; i++)
                    for (int j = i+1; j <= n; j++)
                        if (arr[i]>arr[j])
                        {
                            c = arr[i];
                            arr[i] = arr[j];
                            arr[j] = c;
                        }
                s = " ";
                for (int i = 0; i <= n; i++)
                    s = s + " " + arr[i].ToString();
                textBox2.Text = s.Trim();
            }
            if (radioButton2.Checked == true)
            {
                for (int i = 0; i < n; i++)
                    for (int j = i+1; j <= n; j++)
                        if (arr[i] < arr[j])
                        {
                            c = arr[i];
                            arr[i] = arr[j];
                            arr[j] = c;
                        }
                s = " ";
                for (int i = 0; i <= n; i++)
                    s = s + " " + arr[i].ToString();
                textBox2.Text = s.Trim();
            }
            if (radioButton3.Checked == true)
            {
                int x = Convert.ToInt32(textBox3.Text);
                if (mang.TimKiemGiaTri(arr, n, x))
                    MessageBox.Show("Tìm thấy " + x.ToString(), "Kết quả tìm kiếm",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không tìm thấy " + x.ToString(), "Kết quả tìm kiếm",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton4.Checked == true)
            {
                int c1 = Convert.ToInt32(textBox4.Text);
                for (int i = 0; i <= n; i++)
                    if (textBox4.Text != "")
                        if (i == c1)
                            textBox5.Text = Convert.ToString(arr[i]);
            }
            if (radioButton6.Checked == true)
            {
                int c2 = Convert.ToInt32(textBox6.Text);
                for (int i = 0; i <= n; i++)
                {
                    if(textBox6.Text != "")
                        if (arr[i]==c2)
                        {
                            for (int k = i; k <= n; k++)
                                arr[k] = arr[k + 1];
                            n--;
                            s = "";
                            for (i = 0; i <= n; i++)
                            {
                                if (i == 0)
                                    s = s + arr[i].ToString();
                                else
                                    s = s + " " + arr[i].ToString();
                            }
                            textBox2.Text = s.Trim();
                        }
                }
            }
            if (radioButton5.Checked ==true)
            {
                int c3 = Convert.ToInt32(textBox7.Text);
                for (i = 0; i <= n; i++)
                {
                    for (i = c3; i <= n; i++)
                        arr[i] = arr[i + 1];
                    n--;
                    s = "";
                    for (i = 0; i <= n; i++)
                    {
                        if (i == 0)
                            s = s + arr[i].ToString();
                        else
                            s = s + " " + arr[i].ToString();
                    }
                    textBox2.Text = s.Trim();
                }
            }
            if (radioButton8.Checked == true)
            {
                int c4 = Convert.ToInt32(textBox8.Text);
                int c5 = Convert.ToInt32(textBox9.Text);
                
                for (i = n; i>=c5;i--)
                {
                    if (i != 0)
                        arr[i] = arr[i - 1];
                }

                arr[c5] = c4;

                s = "";
                for (i=0; i <= n; i++)
                {
                    if (i == 0)
                        s = s + arr[i].ToString();
                    else
                        s = s + " " + arr[i].ToString();
                }
                textBox2.Text = s.Trim();
            }
            if (radioButton9.Checked ==true)
            {
                int c6 = 0, c7 = 0;
                try
                {
                    c6 = Convert.ToInt32(textBox15.Text);
                    c7 = Convert.ToInt32(textBox17.Text);

                    if (mang.TimThayThe(arr, n, c6, c7))
                    {
                        s = " ";
                        for (i = 0; i <= n; i++)
                        {
                            if (i == 0)
                                s = s + arr[i].ToString();
                            else
                                s = s + " " + arr[i].ToString();
                            textBox2.Text = s.Trim();
                        }
                    }
                    else
                        MessageBox.Show(c6.ToString() + " không có trong mảng",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception)
                {
                    MessageBox.Show("Bạn chưa nhập giá trị hoặc dữ liệu bị sai",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if(radioButton10.Checked == true)
            {
                int c8 = 0, c7 = 0;
                c8 = Convert.ToInt32(textBox16.Text);
                c7 = Convert.ToInt32(textBox17.Text);

                if (c8 <= n)
                    arr[c8] = c7;

                s = "";
                for (i = 0;i<=n;i++)
                {
                    if (i == 0)
                        s = s + arr[i].ToString();
                    else
                        s = s + " " + arr[i].ToString();
                }
                textBox2.Text = s.Trim();
            }
            ////////////////////
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox13.Text = Convert.ToString(mang.Max(arr, n));
            textBox14.Text = Convert.ToString(mang.Min(arr, n));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = 0;
            s = " ";
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
            textBox7.ResetText();
            textBox8.ResetText();
            textBox9.ResetText();
            textBox10.ResetText();
            textBox11.ResetText();
            textBox12.ResetText();
            textBox13.ResetText();
            textBox14.ResetText();
            textBox15.ResetText();
            textBox16.ResetText();
            textBox17.ResetText();

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
>>>>>>> 68fb493 (bai 2)
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
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
=======
            s = textBox1.Text;
            i = s.LastIndexOf(" ");
            while (i!= -1)
            {
                s1 = s.Substring(i);
                s = s.Substring(0, i);
                arr[n] = Convert.ToInt32(s1);
                n++;
                i = s.LastIndexOf(" ");
            }
            arr[n] = Convert.ToInt32(s);
            s = " ";
            for (int i = n; i >= 0; i--)
            {
                s = s + " " + arr[i].ToString();
            }
            textBox2.Text = s.Trim();
        }

>>>>>>> 68fb493 (bai 2)
    }
}
