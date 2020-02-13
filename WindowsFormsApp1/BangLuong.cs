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
    public partial class BangLuong : UserControl
    {
        public BangLuong()
        {
            InitializeComponent();
        }

        private void BangLuong_Load(object sender, EventArgs e)
        {
            DataConnection dc = new DataConnection();
            SqlConnection connect = dc.getConnect();
            connect.Open();
            /*
            string sql = "select NhanVien.MaNV,LuongThucTe = Luong.LuongCB / 26 * BangChamCong.SoNgayLam," +
                            "Luong.PhuCapChoO," +
                            "Luong.PhuCapDT," +
                            "Luong.PhuCapXang," +
                            "Luong.PhuCapTN," +
                            "TongLuong = Luong.LuongCB / 26 * BangChamCong.SoNgayLam + Luong.LuongCB / 26 * BangChamCong.SoNgayLam * PhiBaohiem.baohiem / 100 + Luong.PhuCapChoO + Luong.PhuCapDT + Luong.PhuCapXang + Luong.PhuCapTN" +
                        "from Luong, NhanVien, BangChamCong, ChucVu,(select NhanVien.MaNV, baohiem = Sum(BaoHiem.LePhiThang)" +
                        "from NhanVien, BaoHiem, BaoHiemNhanVien" +
                        "where NhanVien.MaNV = BaoHiemNhanVien.MaNV and" +
                        "BaoHiem.MaBH = BaoHiemNhanVien.MaBH" +
                        "group by NhanVien.MaNV )as PhiBaohiem" +
                        "where NhanVien.MaNV = BangChamCong.MaNV and" +
                        "ChucVu.MaChucVu = NhanVien.ChucVu and" +
                        "Luong.MaLuong = ChucVu.MaLuong and" +
                        "NhanVien.MaNV = PhiBaohiem.MaNV";*/

            string sql = "select *"+
                        "from Luong, NhanVien, BangChamCong, ChucVu,(select NhanVien.MaNV, baohiem = Sum(BaoHiem.LePhiThang)" +
                                                                    "from NhanVien, BaoHiem, BaoHiemNhanVien" +
                                                                    "where NhanVien.MaNV = BaoHiemNhanVien.MaNV and" +
                                                                    "BaoHiem.MaBH = BaoHiemNhanVien.MaBH" +
                                                                    "group by NhanVien.MaNV )as PhiBaohiem" +
                        "where NhanVien.MaNV = BangChamCong.MaNV and" +
                        "ChucVu.MaChucVu = NhanVien.ChucVu and" +
                        "Luong.MaLuong = ChucVu.MaLuong and" +
                        "NhanVien.MaNV = PhiBaohiem.MaNV";
            SqlDataAdapter sqlad = new SqlDataAdapter(sql, connect);

            DataTable dt = new DataTable();
            sqlad.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
    }
}
