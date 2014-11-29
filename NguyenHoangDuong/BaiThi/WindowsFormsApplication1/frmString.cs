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
    public partial class frmString : Form
    {
        public frmString()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.ToUpper();
            label2.Text = textBox1.Text.ToLower();
        }
        // tach chuoi
        private void button2_Click(object sender, EventArgs e)
        {
            string hoten = textBox1.Text.Trim(); 
            int vt1, vt2;
            vt1 = hoten.IndexOf(" ");
            vt2 = hoten.LastIndexOf(" ");

            string ho, dem, ten;
            ho = hoten.Substring(0, vt1);
            dem = hoten.Substring(vt2,hoten.Length-vt2  );
            ten = hoten.Substring(vt1,vt2 - vt1 +1);

            textBox2.Text = ho.Trim();
            textBox3.Text = dem.Trim();          
            textBox4.Text = ten.Trim(); 

            // hoac la 
            
        }
        // dao chuoi
        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Text = " ";
            for (int i = textBox1.Text.Length -1; i >= 0; i--)
                textBox5.Text += textBox1.Text[i];

            //char[] a = hoten.ToCharArray();
            //Array.Reverse(a);
            //textBox5.Text = new String(a);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < textBox1.Text.Trim().Length; i++)
                if (textBox1.Text.Trim()[i].ToString() == " ")
                    dem++;
            textBox6.Text = (dem).ToString (); // dem tu xuat hien 
            //textBox6.Text = (dem +1).ToString ()

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < textBox1.Text.Trim().Length; i++)
                if (textBox1.Text.Trim()[i].ToString() == "a")
                    dem++;
            textBox6.Text = (dem).ToString(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] a = textBox1.Text.Split(' ');
            string s;
            for (int i = 0; i < a.Length; i++) {
                if (a[i] != "") {
                    textBox7.Text += a[i].Substring(0, 1).ToUpper() + a[i].Substring(1) + " ";
                }
            }
        }
    }
}
