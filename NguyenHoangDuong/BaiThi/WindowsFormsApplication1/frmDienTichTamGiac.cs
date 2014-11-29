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
    public partial class frmDienTichTamGiac : Form
    {
        public frmDienTichTamGiac()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a1, b1, c1;
            a1 = txtA.Text;
            b1 = txtB.Text;
            c1 = txtC.Text;
            if(a1==""|| b1==""|| c1=="")
            {
                MessageBox .Show (" nhap du thong tin");
            }
            else
            {
                int a, b, c;
                    a = Int32.Parse(a1);
                    b = Int32.Parse(b1);
                    c = Int32.Parse(c1);
                if(a==0||b==0||c==0)
                    MessageBox.Show("Ban nhap khong dung!!!","Error");
                    if(a+b<=c||b+c<=a||c+a<=b)
                        MessageBox.Show("Day khong phai la tam jac","Error");
                    else
                    {
                        int P = a + b + c;
                        float p = P / 2;
                        double S;
                        S=Math.Sqrt((p*(p-a)*(p-b)*(p-c))/2);
                        ChuVitxt.Text=P.ToString();
                        DienTichtxt.Text=S.ToString();
                    }
            
                 
            }
        }

        private void FrmDienTichTamGiac_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
