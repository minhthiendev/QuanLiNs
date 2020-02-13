using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class ThuongOfNV : UserControl
    {
        public ThuongOfNV()
        {
            InitializeComponent();
        }

        string mnv;
        public ThuongOfNV(string mnv) : this()
        {
            this.mnv = mnv;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThuongOfNV_Load(object sender, EventArgs e)
        {
            DataConnection dc = new DataConnection();
            SqlConnection connect = dc.getConnect();
            connect.Open();
            string sql = "select MaKhenThuong, NgayKhenThuong, GhiChu from BangKhenThuongChiTiet Where MaNV = '" + this.mnv + "'";
            SqlDataAdapter sqlad = new SqlDataAdapter(sql, connect);

            DataTable dt = new DataTable();
            sqlad.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
    }
}
