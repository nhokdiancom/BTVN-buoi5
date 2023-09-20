using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2033216416_NguyenHaiHoa_Buoi5
{
    public partial class frmBaiTap1 : Form
    {
        ErrorProvider errorProvider;
        public frmBaiTap1()
        {
            ErrorProvider errorProvider = new ErrorProvider();
            InitializeComponent();

        }

        private void textBox_YourName(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "You must enter Your Name");
            else
                this.errorProvider1.Clear();
        }

        private void textBox2_YearofBirth(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "This is not avalid number");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
        private void button1_Show(object sender, EventArgs e)
        {
            int age;
            string s;
            s = "My name is: " + textBox1.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(textBox2.Text);
            s = s + "Age: " + age.ToString();
            MessageBox.Show(s);
        }
        private void button2_Clear(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button3_Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBT1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
    }
    }
}
