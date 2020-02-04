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
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }
        string mnv;
        public Profile(string mnv) : this()
        {
            this.mnv = mnv;
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
       
        private void Profile_Load(object sender, EventArgs e)
        {
            try {
                DataConnection dc = new DataConnection();
                SqlConnection connect = dc.getConnect();
                connect.Open();
                string sql = "select * from NhanVien where MaNV='" + this.mnv + "'";
                SqlDataAdapter sqlad = new SqlDataAdapter(sql, connect);
                DataTable dt = new DataTable();
                sqlad.Fill(dt);
                manv.Text = dt.Rows[0]["MaNV"].ToString();
                nc.Text = dt.Rows[0]["NoiCap"].ToString();
                ngc.Text = dt.Rows[0]["NgayCap"].ToString();
                ngs.Text = dt.Rows[0]["NgaySinh"].ToString();
                qq.Text = dt.Rows[0]["QueQuan"].ToString();
                ten.Text = dt.Rows[0]["TenNV"].ToString();
                gt.Text = dt.Rows[0]["GioiTinh"].ToString();
                cmnd.Text = dt.Rows[0]["CMND"].ToString();
                email.Text = dt.Rows[0]["Email"].ToString();
                ns.Text = dt.Rows[0]["NoiSinh"].ToString();
                qt.Text = dt.Rows[0]["QuocTich"].ToString();
                tt.Text = dt.Rows[0]["TamTru"].ToString();
                sdt.Text = dt.Rows[0]["SDT"].ToString();
                phg.Text = dt.Rows[0]["MaPhong"].ToString();
                cv.Text = dt.Rows[0]["ChucVu"].ToString();
                dto.Text = dt.Rows[0]["DanToc"].ToString();
            }
            catch {
                MessageBox.Show("Throw Error", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
