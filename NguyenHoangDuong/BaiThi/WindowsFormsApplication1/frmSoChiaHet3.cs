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
    public partial class frmSoChiaHet3 : Form
    {
        public frmSoChiaHet3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private bool laChinhPhuong(int n)
        {
            int a = (int) Math.Sqrt(n);
            return a * a == n;
            //for (int i = 1; i <= a; i++)
            //{
            //    if (i * i == n)
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            string so1 = textBox1.Text;
            string so2 = textBox2.Text;

            int n = int.Parse(so1);
            int m = int.Parse(so2);
            for (int i = 0; i <= n; i++)
            {
                if(i%3==0)
                //if (laChinhPhuong(i))
                    label3.Text += i.ToString() + ",";
            }
        }

        private void frmSoChiaHet3_Load(object sender, EventArgs e)
        {

        }
    }
}
