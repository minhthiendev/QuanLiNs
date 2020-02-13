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
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class ListBaoHiem : UserControl
    {
        public ListBaoHiem()
        {
            InitializeComponent();
        }

        private void ListBaoHiem_Load(object sender, EventArgs e)
        {
            DataConnection dc = new DataConnection();
            SqlConnection connect = dc.getConnect();
            connect.Open();
            string sql = "select * from BaoHiem";
            SqlDataAdapter sqlad = new SqlDataAdapter(sql, connect);

            DataTable dt = new DataTable();
            sqlad.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
        public bool checkNull(string str, string name)
        {
            if (string.IsNullOrEmpty(str))
            {
                MessageBox.Show("Chưa Nhập: " + name, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        public bool checkData()
        {
            if (!checkNull(mabh.Text, " Mã Bảo Hiêm")) { mabh.Focus(); return false; }
            if (!checkNull(tenbh.Text, " TenNV")) { tenbh.Focus(); return false; }
            if (!checkNull(lpt.Text, " Ngày Sinh")) { lpt.Focus(); return false; }

            if (Regex.IsMatch(lpt.Text, "[A-Za-z]"))
            {
                MessageBox.Show("Lệ phí tháng Ko hơp lệ  --- Đúng : 1.3%", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lpt.Focus();
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkData())
            {

                DataConnection dc = new DataConnection();
                SqlConnection connect = dc.getConnect();
                connect.Open();
                try
                {
                    string sql = "insert into BaoHiem values(@MaBh,@TenBh,@lephiThang)";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.Parameters.Add("@MaBh", SqlDbType.VarChar).Value = mabh.Text;
                    cmd.Parameters.Add("@TenBh", SqlDbType.NVarChar).Value = tenbh.Text;
                    cmd.Parameters.Add("@lephiThang", SqlDbType.VarChar).Value = lpt.Text;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Cần phải kiểm tra kiểu dữ liệu nhập vào", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataConnection dc = new DataConnection();
            SqlConnection connect = dc.getConnect();
            connect.Open();
            string sql = "select * from BaoHiem";
            SqlDataAdapter sqlad = new SqlDataAdapter(sql, connect);

            DataTable dt = new DataTable();
            sqlad.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
    }
}
