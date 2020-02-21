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
    public partial class AddNV : UserControl
    {
        public AddNV()
        {
            InitializeComponent();
        }
        public bool checkNull(string str,string name)
        {
            if (string.IsNullOrEmpty(str))
            {
                MessageBox.Show("Chưa Nhập: "+name, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }



        public bool checkData()
        {
            if (!checkNull(mnv.Text, " MaNV")) { mnv.Focus(); return false; }
            if (!checkNull(tnv.Text, " TenNV")) { tnv.Focus(); return false; }
            if (!checkNull(ns.Text, " Ngày Sinh")) { ns.Focus(); return false; }
            if (!checkNull(noisinh.Text, " Nơi Sinh")) { noisinh.Focus(); return false; }
            if (!checkNull(tamt.Text, " Tạm trú")) { tamt.Focus(); return false; }
            if (!checkNull(qq.Text, " Quê Quán")) { qq.Focus(); return false; }
            if (!checkNull(qt.Text, " Quốc Tịch")) { qt.Focus(); return false; }
            if (!checkNull(dto.Text, " Dân tộc")) { dto.Focus(); return false; }
            if (!checkNull(cmnd.Text, " CMND")) { cmnd.Focus(); return false; }
            if (!checkNull(ngc.Text, " Ngày Cấp Cmnd")) { ngc.Focus(); return false; }
            if (!checkNull(noic.Text, " Nơi cấp")) { noic.Focus(); return false; }
            if (!checkNull(email.Text, " Email")) { email.Focus(); return false; }
            if (!checkNull(sdt.Text, " SDT")) { sdt.Focus(); return false; }
            if (!checkNull(phg.Text, " Phòng")) { phg.Focus(); return false; }
            if (!checkNull(cv.Text, " Chúc vụ")) { cv.Focus(); return false; }
            if (!checkNull(Gt.Text, " Giới Tính")) { Gt.Focus(); return false; }


            DataConnection dc = new DataConnection();

            SqlConnection connect = dc.getConnect();
            connect.Open();
            string sql = "select MaNV from NhanVien Where MaNV='" + mnv.Text + "'";
            string sql1 = "select MaPhong from PhongBan Where MaPhong='" + phg.Text + "'";
            string sql2 = "select MaChucVu from ChucVu Where MaChucVu='" + cv.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("MaNV đã tồn tại ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            SqlDataAdapter da1 = new SqlDataAdapter(sql1, connect);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            if (dt1.Rows.Count == 0)
            {
                MessageBox.Show("MaPhong chưa tồn tại ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            SqlDataAdapter da2 = new SqlDataAdapter(sql2, connect);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            if (dt2.Rows.Count == 0)
            {
                MessageBox.Show("MaChucVu chưa tồn tại ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (Regex.IsMatch(tnv.Text, "[0-9]"))
            {
                MessageBox.Show(" Tên Nhân viên không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tnv.Focus();
                return false;
            }


            if (Regex.IsMatch(cmnd.Text, "[A-Za-z]") || cmnd.Text.Length != 9)
            {
                MessageBox.Show("CMND không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmnd.Focus();
                return false;
            }


            if (Regex.IsMatch(sdt.Text, "[A-Za-z]") || sdt.Text.Length != 10)
            {
                MessageBox.Show("SDT không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sdt.Focus();
                return false;
            }
            if (Gt.Text.ToUpper() == "NAM" || Gt.Text.ToUpper() == "NU")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Gioi tinh phải là Nam / nu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    string sql = "insert into NhanVien values(@MaNV,@TenNV,@NgaySinh,@NoiSinh,@TamTru,@QueQuan,@QuocTich,@DanToc,@CMND,@NgayCap,@NoiCap,@Email,@Sdt,@MaPhong,@ChucVu,@GioiTinh)";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = mnv.Text;
                    cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = tnv.Text;
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = ns.Text;
                    cmd.Parameters.Add("@NoiSinh", SqlDbType.NVarChar).Value = noisinh.Text;
                    cmd.Parameters.Add("@TamTru", SqlDbType.NVarChar).Value = tamt.Text;
                    cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar).Value = qq.Text;
                    cmd.Parameters.Add("@QuocTich", SqlDbType.NVarChar).Value = qt.Text;
                    cmd.Parameters.Add("@DanToc", SqlDbType.VarChar).Value = dto.Text;
                    cmd.Parameters.Add("@CMND", SqlDbType.VarChar).Value = cmnd.Text;
                    cmd.Parameters.Add("@NgayCap", SqlDbType.DateTime).Value = ngc.Text;
                    cmd.Parameters.Add("@NoiCap", SqlDbType.NVarChar).Value = noic.Text;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = email.Text;
                    cmd.Parameters.Add("@Sdt", SqlDbType.VarChar).Value = sdt.Text;
                    cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = phg.Text;
                    cmd.Parameters.Add("@ChucVu", SqlDbType.VarChar).Value = cv.Text;
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = Gt.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Cần phải kiểm tra 2 ô ngày sinh và ngày cấp cmnd", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            mnv.Text = null;
            tnv.Text = null;
            ngc.Text = null;
            ns.Text = null;
            qq.Text = null;
            dto.Text = null;
            tamt.Text = null;
            sdt.Text = null;
            email.Text = null;
            cv.Text = null;
            phg.Text = null;
            cmnd.Text = null;
            qt.Text = null;
            mnv.Text = null;
            mnv.Text = null;
            Gt.Text = null;
            noic.Text = null;
            noisinh.Text = null;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            home.Instance.LabelFunc.Text = "Quản lí Nhân Viên";
            if (!home.Instance.PanelContainer.Controls.ContainsKey("ListNhanVien"))
            {
                ListNhanVien lnv = new ListNhanVien();
                lnv.Dock = DockStyle.Fill;
                home.Instance.PanelContainer.Controls.Add(lnv);
            }
            home.Instance.PanelContainer.Controls["ListNhanVien"].BringToFront();
        }
    }
}
