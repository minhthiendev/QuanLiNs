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
    public partial class ThanNhan : UserControl
    {
        public ThanNhan()
        {
            InitializeComponent();
        }
        string mnv;
        public ThanNhan(string mnv) : this()
        {
            this.mnv = mnv;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ThanNhan_Load(object sender, EventArgs e)
        {
            DataConnection dc = new DataConnection();
            SqlConnection connect = dc.getConnect();
            connect.Open();
            string sql = "select TenThanNhan,QuanHe,NgaySinh,NoiO,Sdt from ThanNhan Where MaNV = '"+ this.mnv+"'";
            SqlDataAdapter sqlad = new SqlDataAdapter(sql, connect);

            DataTable dt = new DataTable();
            sqlad.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
    }
}
