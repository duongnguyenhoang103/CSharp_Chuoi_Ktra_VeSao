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
    public partial class frmGiaHePT : Form
    {
        public frmGiaHePT()
        {
            InitializeComponent();
        }

        private void bntThuchien_Click(object sender, EventArgs e)
        {
            String a1, b1, c1;
            a1 = txta.Text;
            b1 = txtb.Text;
            c1 = txtc.Text;

            if (a1 == "" || b1 == "" || c1 == "")
                MessageBox.Show("Ban nhap thieu du lieu!!!", "Error!!!");
            else
            {
                int a, b, c;
                a = Int32.Parse(a1);
                b = Int32.Parse(b1);
                c = Int32.Parse(c1);
                if (a == 0)
                    if (b == 0)
                        if (c == 0)
                            txtKQ.Text = "Thoa man voi moi x";
                        else
                            txtKQ.Text = "PTVN";
                    else
                        txtKQ.Text = "Nghiem x=" + (-c * 1.0 / b).ToString();
                else
                {
                    int delta = b * b - 4 * a * c;
                    if (delta < 0)
                        txtKQ.Text = "PTVN";
                    else
                        if (delta == 0)
                            txtKQ.Text = "x1=x2=" + ((-b * 1.0) / (2 * a)).ToString();
                        else
                        {
                            double x1, x2;
                            x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                            x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                            txtKQ.Text = "x1= " + x1.ToString() + " ,  x2=" + x2.ToString();
                        }
                }
            }
        }
    }
}
