using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    public partial class frmLoaiThuoc : Form
    {
        public frmLoaiThuoc()
        {
            InitializeComponent();
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=DUONG-PC\SQLEXPRESS;Initial Catalog=BANTHUOC;User ID=sa;Password=123456 ");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "select * from tbl_LOAITHUOC";
            SqlConnection con = getConnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new System.Data.DataTable();
            ad.Fill(dt);

            dataGridView1.DataSource = dt;
        }
        
         

    }
}
