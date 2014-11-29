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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void bai1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiThuoc frm1 = new frmLoaiThuoc();
            frm1.Show();
        }

        private void bai2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDienTichTamGiac frmTG = new frmDienTichTamGiac();
            frmTG.Show();
        }

        private void bai3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiaHePT frmPT = new frmGiaHePT();
            frmPT.Show();
        }

        private void b4KtraSoNgtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKtraSoNgto1 frmNgto = new frmKtraSoNgto1();
            frmNgto.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void b5ChiaHetCho3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiaHet3 frmCH3 = new frmChiaHet3();
            frmCH3.Show();
        }

        private void b6KtraSoCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSoCP1 frmSCP = new frmSoCP1 ();
            frmSCP.Show();
        }

        private void b7HienThi0Den10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtu0den10 frm = new frmtu0den10(); frm.Show();
        }

        private void veSaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVeSao1 frm = new frmVeSao1(); frm.Show();
        }

        private void stringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmString frm = new frmString(); frm.Show();
        }
    }
}
