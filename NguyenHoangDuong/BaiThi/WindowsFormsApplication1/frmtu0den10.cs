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
    public partial class frmtu0den10 : Form
    {
        public frmtu0den10()
        {
            InitializeComponent();
        }

        public void hii()
        {

            int n = 1;
            label2.Text = "";
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    label2.Text += n++ + " ";
                    //label2.Text += (j + (i - 1) * 10) + " \t";
                }
                label2.Text += "\n";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //hii();
            int n = int.Parse(textBox1.Text);
            label2.Text = "";
            for (int i = 1; i <= n; i++)
            {

                label2.Text += i.ToString() + " \t "; // t de tab cach
                if (i % 10 == 0)
                    label2.Text += "\n";
                //if (i % 10 == 0)
                //{
                //    label2.Text += i.ToString() + " \t ";
                //    label2.Text += "\n";
                //}
                //else
                //    label2.Text += i.ToString() + " \t ";
            }
        }

        private void frmtu0den10_Load(object sender, EventArgs e)
        {
            label2.Text = "";
        }
    }
}
