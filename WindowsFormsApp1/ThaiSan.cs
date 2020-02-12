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
    public partial class ThaiSan : UserControl
    {
        public ThaiSan()
        {
            InitializeComponent();
        }
        string mnv;
        public ThaiSan(string mnv) : this()
        {
            this.mnv = mnv;
        }

        private void ThaiSan_Load(object sender, EventArgs e)
        {
            DataConnection dc = new DataConnection();
            SqlConnection connect = dc.getConnect();
            connect.Open();
            string sql = "select NgayBD, NgayKT,PhuCap  from ThaiSan Where MaNV = '" + this.mnv + "'";
            SqlDataAdapter sqlad = new SqlDataAdapter(sql, connect);

            DataTable dt = new DataTable();
            sqlad.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
    }
}
