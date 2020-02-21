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
    public partial class BangKhenThuong : UserControl
    {
        public BangKhenThuong()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BangKhenThuong_Load(object sender, EventArgs e)
        {
            DataConnection dc = new DataConnection();
            SqlConnection connect = dc.getConnect();
            connect.Open();

            string sql = "select * from BangKhenThuong";
            SqlDataAdapter sqlad = new SqlDataAdapter(sql, connect);

            DataTable dt = new DataTable();
            sqlad.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!home.Instance.PanelContainer.Controls.ContainsKey("KhenThuongNhanVien"))
            {
                KhenThuongNhanVien dskl = new KhenThuongNhanVien();
                dskl.Dock = DockStyle.Fill;
                home.Instance.PanelContainer.Controls.Add(dskl);
            }
            home.Instance.PanelContainer.Controls["KhenThuongNhanVien"].BringToFront();
        }

        bool checkData()
        {
            if (string.IsNullOrEmpty(makht.Text))
            {
                MessageBox.Show("Chưa nhập Mã khen Thưởng", " thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    makht.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tenkht.Text))
            {
                MessageBox.Show("Chưa nhập tên khen thưởng", " thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tenkht.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(hth.Text))
            {
                MessageBox.Show("Chưa nhập hình thức khen Thưởng", " thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hth.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tien.Text))
            {
                MessageBox.Show("Chưa nhập số tiền thưởng", " thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tien.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(noid.Text))
            {
                MessageBox.Show("Chưa nhập Nôi dung", " thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                noid.Focus();
                return false;
            }


            if (Regex.IsMatch(tien.Text, "[a-zA-Z]"))
            {
                MessageBox.Show(" tiền thưởng Phải là số", " thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tien.Focus();
                return false;
            }
            
            DataConnection dc = new DataConnection();
            SqlConnection connect = dc.getConnect();
            connect.Open();

            string sql = "select MaKhenThuong from BangKhenThuong where MaKhenThuong='"+makht.Text+"'";
            SqlDataAdapter sqlad = new SqlDataAdapter(sql, connect);

            DataTable dt = new DataTable();
            sqlad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show(" Mã Khen Thuong Đã tồn tại", " thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!checkData())
            {
                DataConnection dc = new DataConnection();
                SqlConnection connect = dc.getConnect();
                connect.Open();
                
              
                    string sql = "insert into BangKhenThuong values(@MaKhenThuong,@TenKhenThuong,@HinhThuc,@SoTienThuong,@NoiDung)";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.Parameters.Add("@MaKhenThuong", SqlDbType.VarChar).Value = makht.Text;
                    cmd.Parameters.Add("@TenKhenThuong", SqlDbType.NVarChar).Value = tenkht.Text;
                    cmd.Parameters.Add("@HinhThuc", SqlDbType.NVarChar).Value = hth.Text;
                    cmd.Parameters.Add("@SoTienThuong", SqlDbType.Int).Value = tien.Text;
                    cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar).Value = noid.Text;
                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
