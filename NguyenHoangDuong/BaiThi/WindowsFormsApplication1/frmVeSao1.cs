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
    public partial class frmVeSao1 : Form
    {
        public frmVeSao1()
        {
            InitializeComponent();
        }
        //hinh vuong dac
        private void button1_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txtH.Text);
            lblStar.Text = "";
            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j < n; j++)
                    lblStar.Text += "* ";
                lblStar.Text += "\n";
            }
        }
       
        //// tam giac vuong nguoc dac trai
        private void button3_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txtH.Text);
            lblStar.Text = "";
            for (int i = n; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    lblStar.Text += "* ";
                }
                lblStar.Text += "\n";
            }
            //for (int i =1; i <= n; i++)
            //{
            //    for (int j = n; j >= i; j--)
            //    {
            //        lblStar.Text += "* ";
            //    }
            //    lblStar.Text += "\n";
            //}
        }
       
        // tam giac vuong dac phai
        private void button5_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txtH.Text);
            lblStar.Text = "";
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= n; j++)
                {
                    lblStar.Text += j >= i ? "* " : "  ";
                }
                lblStar.Text += "\n";
            }
        }
        //tam giac vuong nguoc  dac phai
        private void button4_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txtH.Text);
            lblStar.Text = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    lblStar.Text += j >= i ? "* " : "  ";

                }
                lblStar.Text += "\n";
            }
        }
        // tam giac vuong dac trai
        private void button2_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txtH.Text);
            lblStar.Text = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    lblStar.Text += "* ";
                }
                lblStar.Text += "\n";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txtH.Text);
            lblStar.Text = "";
            //tam giac vuong ngc phai
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= n; j++)
                    lblStar.Text += j >= i ? "* " : "  ";
                lblStar.Text += "\n";
            }
            //vuong trai
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < n; j++)
                    lblStar.Text += "  ";
                for (int j = 1; j <= i; j++)
                    lblStar.Text += "* ";
                lblStar.Text += "\n";
            }
                     
        }
        // hinh vuong rong
        private void button7_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txtH.Text);
            lblStar.Text = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                    if (i == n || j == n || i == 1 || j == 1)
                        lblStar.Text += "*";
                    else
                        lblStar.Text += " ";
                lblStar.Text += "\n";
            }
        }

        private void frmVeSao1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txtH.Text);
            lblStar.Text = "";
            for (int i = 1; i < n; i++)
            {
                for (int j = n; j >= i; j--)
                
                    lblStar.Text += "* ";
                
                lblStar.Text += "\n";
            }
            for (int i = 1; i <= n; i++)
            {
                //for (int j = 1; j < n; j++)
                //    lblStar.Text += "  ";
                for (int j = 1; j <= i; j++)
                    lblStar.Text += "* ";
                lblStar.Text += "\n";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txtH.Text);
            lblStar.Text = "";
            for (int i = n; i > 0; i--)
            {
                for (int j = -n; j <= n; j++)
                {
                    int k = Math.Abs(j);
                    if (k < i)
                        lblStar.Text += "* ";
                    else
                        lblStar.Text += "  ";
                }
                lblStar.Text += "\n";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txtH.Text);
            lblStar.Text = "";
            for (int i = -n; i <= n; i++)
            {
                for (int j = -n; j <= n; j++)
                {
                    if (Math.Abs(i) >= Math.Abs(j))
                        lblStar.Text += "* ";
                    else
                        lblStar.Text += "  ";
                }
                lblStar.Text += "\n";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txtH.Text);
            lblStar.Text = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = -n; j <= n; j++)
                {
                    int k = Math.Abs(j);
                    if (k < i)
                        lblStar.Text += "* ";
                    else
                        lblStar.Text += "  ";
                }
                lblStar.Text += "\n";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txtH.Text);
            lblStar.Text = "";
            for (int i = -n; i <= n; i++)
            {
                for (int j = -n; j <= n; j++)
                {
                    int k = Math.Abs(i);
                    int g = Math.Abs(j);
                    if (k == g || k == n)
                        lblStar.Text += "* ";
                    else
                        lblStar.Text += "  ";
                }
                lblStar.Text += "\n";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txtH.Text);
            lblStar.Text = "";
            for (int i = -n; i <= n; i++)
            {
                for (int j = -n; j <= n; j++)
                {
                    int k = Math.Abs(j);
                    int g = n - Math.Abs(i) + 1;
                    if (k < g)
                        lblStar.Text += "* ";
                    else
                        lblStar.Text += "  ";
                }
                lblStar.Text += "\n";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txtH.Text);
            lblStar.Text = "";
            for (int i = -n; i <= n; i++)
            {
                for (int j = -n; j <= n; j++)
                {
                    int k = Math.Abs(j);
                    int g = n - Math.Abs(i);
                    if (k == g)
                        lblStar.Text += "* ";
                    else
                        lblStar.Text += "  ";
                }
                lblStar.Text += "\n";
            }
        }

       
    }
}
