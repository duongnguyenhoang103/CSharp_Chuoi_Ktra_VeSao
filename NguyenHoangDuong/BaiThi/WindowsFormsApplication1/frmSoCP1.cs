using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmSoCP1 : Form
    {
        public frmSoCP1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public bool SoChinhPhuong(int n)
        {
            int a = (int) Math.Sqrt(n);
            return a * a == n;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int n = int.Parse(textBox1.Text);
            for (int i = 1; i <= n; i++)
                if (SoChinhPhuong(i))
                    label2.Text += i.ToString() + ",";
            //string a = textBox1.Text;
            //int n = int.Parse(a);
            //int m = (int)(Math.Sqrt(n));
            //label2.Text = "";
            //for (int i = 1; i <= m; i++)
            //    label2.Text += (i * i).ToString() + ","; 

        }

        private void frmSoCP1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
        }
    }
}
