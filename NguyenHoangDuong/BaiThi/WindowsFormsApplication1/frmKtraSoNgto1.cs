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
    public partial class frmKtraSoNgto1 : Form
    {
        public frmKtraSoNgto1()
        {
            InitializeComponent();
        }

        int ktra(int n)
        {
            int dem = 0;
            for (int i = 1; i <= n; i++)

                if (n % i == 0)
                    dem++;
            if (dem <= 2)
                return 1; // so ngto
            else
                return 0; //kto
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            //int n = int.Parse(textBox1.Text .ToString ());
            //label2.Text = "";

            //for (int i = 1; i <= n; i++)
            //    if (ktra(i) == 1)
            //        label2.Text = label2.Text + i.ToString() + " , ";
            //label2.Font = new Font(label2.Font, FontStyle.Bold);
            string a = textBox1.Text;
            int n = int.Parse(a);
            label2.Text = "";

            for (int i = 1; i <= n; i++)
            {
                if (ktra(i) == 1)
                {
                    //label2.Text += i.ToString() + ","; // giong label2.Text = label2.Text + i.ToString() + " , ";
                    label2.Text = " so " + textBox1.Text + " la so nguyen to";
                    label2.Font = new Font(label2.Font, FontStyle.Bold);

                }
                else
                    label2.Text = " so " + textBox1.Text + " khong la so nguyen to";
            }
        }

        private void frmKtraSoNgto1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
