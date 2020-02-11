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

        private void button2_Click(object sender, EventArgs e)
        {

            /*
            DataConnection dc = new DataConnection();
            SqlConnection connect = dc.getConnect();
            connect.Open();
            string sql = "update NhanVien  set MaNV ='" + manv.Text +
            "',TenNV = '" + ten.Text +
            "',NgaySinh = '" + ns.Text +
            "',NoiSinh= '" + ngs.Text +
            "',TamTru = '" + tt.Text +
            "',QueQuan= '" + qq.Text +
            "',QuocTich= '" + qt.Text +
            "',DanToc= '" + dto.Text +
            "',CMND ='" + cmnd.Text +
            "',NgayCap= '" + ngc.Text +
            "',NoiCap = '" + nc.Text +
            "',Email= '" + email.Text +
            "',Sdt = '" + sdt.Text +
            "',MaPhong = '" + phg.Text +
            "',ChucVu= '" + cv.Text +
            "',GioiTinh= '" + gt.Text + "'where MaNV = '" + this.mnv + "'";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            */

            /*
                try
                {*/
                    DataConnection dc = new DataConnection();
                    SqlConnection connect = dc.getConnect();
                    connect.Open();
                    string sql = "update NhanVien set MaNV=@MaNV,TenNV=@TenNV, NgaySinh=@NgaySinh,NoiSinh=@NoiSinh,TamTru=@TamTru,QueQuan=@QueQuan,QuocTich=@QuocTich,DanToc=@DanToc,CMND=@CMND,NgayCap=@NgayCap,NoiCap=@NoiCap,Email=@Email,Sdt=@Sdt,MaPhong=@MaPhong,ChucVu=@ChucVu,GioiTinh=@GioiTinh) where MaNV='" + this.mnv + "'";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = manv.Text;
                    cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = ten.Text;
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = ns.Text;/// dang lỗi vị ngày tháng năm
                    cmd.Parameters.Add("@NoiSinh", SqlDbType.NVarChar).Value = ngs.Text;
                    cmd.Parameters.Add("@TamTru", SqlDbType.NVarChar).Value = tt.Text;
                    cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar).Value = qq.Text;
                    cmd.Parameters.Add("@QuocTich", SqlDbType.NVarChar).Value = qt.Text;
                    cmd.Parameters.Add("@DanToc", SqlDbType.VarChar).Value = dto.Text;
                    cmd.Parameters.Add("@CMND", SqlDbType.VarChar).Value = cmnd.Text;
                    cmd.Parameters.Add("@NgayCap", SqlDbType.Date).Value = ngc.Text;
                    cmd.Parameters.Add("@NoiCap", SqlDbType.NVarChar).Value = nc.Text;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = email.Text;
                    cmd.Parameters.Add("@Sdt", SqlDbType.VarChar).Value = sdt.Text;
                    cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = phg.Text;
                    cmd.Parameters.Add("@ChucVu", SqlDbType.VarChar).Value = cv.Text;
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = gt.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /*}
                catch
                {
                    MessageBox.Show("Cần phải kiểm tra kiểu dữ liệu nhập vào", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }*/


        }
    }
}
