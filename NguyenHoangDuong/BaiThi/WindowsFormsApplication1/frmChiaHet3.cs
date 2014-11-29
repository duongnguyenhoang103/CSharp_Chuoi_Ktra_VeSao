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
    public partial class frmChiaHet3 : Form
    {
        public frmChiaHet3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sothu1 = int.Parse(textBox1 .Text );
            int sothu2 = int.Parse(textBox1.Text);
            label3.Text = "";
            for (int i = 1 ;i <=sothu1 ; i++)
               if(i % 3 == 0)
                   label3.Text += i.ToString() + ",";
            label3.Font = new Font(label2.Font, FontStyle.Bold);

        }
        // hihi
        private void frmChiaHet3_Load(object sender, EventArgs e)
        {
            label3.Text = "";
        }
    }
}
