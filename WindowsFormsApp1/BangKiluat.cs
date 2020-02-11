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
    public partial class BangKiluat : UserControl
    {
        public BangKiluat()
        {
            InitializeComponent();
        }

        private void BangKiluat_Load(object sender, EventArgs e)
        {
            DataConnection dc = new DataConnection();
            SqlConnection connect = dc.getConnect();
            connect.Open();

            string sql = "select * from BangKiLuat";
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
                MessageBox.Show("Cần phải nhập " + name, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public bool checkData()
        {
            if (!checkNull(makl.Text, " MaKiLuat")) { makl.Focus(); return false; }
            if (!checkNull(ht.Text, " Hình thức Phạt")) { ht.Focus(); return false; }
            if (!checkNull(nd.Text, " Nội dung")) { nd.Focus(); return false; }
            
            if (!checkNull(tp.Text, " Tiền Phạt nhỏ Nhất phải là 0")) { tp.Focus(); return false; }
            if (!checkNull(tenkl.Text, " Tên Lỗi Kĩ Luật")) { tp.Focus(); return false; }

            DataConnection dc = new DataConnection();

            SqlConnection connect = dc.getConnect();
            connect.Open();
            string sql = "select MaKiLuat from BangKiLuat Where MaKiLuat='" + makl.Text + "'";
           
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("MaKiLuat đã tồn tại ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
             try
            {
            if (checkData())
            {
                DataConnection dc = new DataConnection();
                SqlConnection connect = dc.getConnect();
                connect.Open();

                string sql = "insert into BangKiLuat values(@MaKiLuat,@TenKiLuat,@HinhThuc,@SoTienPhat,@NoiDung)";
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.Add("@MaKiLuat", SqlDbType.VarChar).Value = makl.Text;
                cmd.Parameters.Add("@TenKiLuat", SqlDbType.NVarChar).Value = tenkl.Text;
                cmd.Parameters.Add("@HinhThuc", SqlDbType.NVarChar).Value = ht.Text;
                cmd.Parameters.Add("@SoTienPhat", SqlDbType.Money).Value =tp.Text;
                cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar).Value = nd.Text;
                cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string sql1 = "select * from BangKiLuat";
                    SqlDataAdapter sqlad = new SqlDataAdapter(sql1, connect);

                    DataTable dt = new DataTable();
                    sqlad.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
           }
           catch
           {
                MessageBox.Show("Kiểm tra lại Kiểu dữ liệu đầu vào","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!home.Instance.PanelContainer.Controls.ContainsKey("DSKLNV"))
            {
                DSKLNV dskl = new DSKLNV();
               dskl.Dock = DockStyle.Fill;
                home.Instance.PanelContainer.Controls.Add(dskl);
            }
            home.Instance.PanelContainer.Controls["DSKLNV"].BringToFront();
        }
    }
}
