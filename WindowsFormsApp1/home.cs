using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class home : Form
    {
        static home _obj;
        public static home Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new home();
                }
                return _obj;
            }
        }

        public Panel PanelContainer
        {
            get { return pContainer; }
            set { pContainer = value; }
        }
        public Label LabelFunc
        {
            get { return tenchucnang; }
            set { tenchucnang = value; }
        }
        public home()
        {
            InitializeComponent();
        }

       

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            tenchucnang.Text = "Quản lí Kĩ luật";
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox8.BackColor = Color.Black;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.BackColor = Color.DodgerBlue;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox4.BackColor = Color.Black;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox5.BackColor = Color.Black;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox2.BackColor = Color.Black;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox7.BackColor = Color.Black;
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox8.BackColor = Color.Black;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox9.BackColor = Color.Black;
           
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox13.BackColor = Color.Black;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox14.BackColor = Color.Black;

            pictureBox11.BorderStyle = BorderStyle.None;
            pictureBox11.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox15.BorderStyle = BorderStyle.None;
            pictureBox15.BackColor = Color.Black;
            pictureBox16.BorderStyle = BorderStyle.None;
            pictureBox16.BackColor = Color.Black;
            pictureBox17.BorderStyle = BorderStyle.None;
            pictureBox17.BackColor = Color.Black;
           
            if (!Instance.PanelContainer.Controls.ContainsKey("BangKiLuat"))
            {
                BangKiluat bkl = new BangKiluat();
                bkl.Dock = DockStyle.Fill;
                Instance.PanelContainer.Controls.Add(bkl);
            }
            Instance.PanelContainer.Controls["BangKiLuat"].BringToFront();

        }

        private void home_Load(object sender, EventArgs e)
        {
            _obj = this;
            UChome uch = new UChome();
            uch.Dock = DockStyle.Fill;
            pContainer.Controls.Add(uch);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tenchucnang.Text = "Home";
            if (!Instance.PanelContainer.Controls.ContainsKey("UChome"))
            {
                UChome uch = new UChome();
                uch.Dock = DockStyle.Fill;
                Instance.PanelContainer.Controls.Add(uch);
            }
            Instance.PanelContainer.Controls["UChome"].BringToFront();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            tenchucnang.Text = "Quản lí khen thưởng";
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox8.BackColor = Color.Black;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.BackColor = Color.DodgerBlue;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox4.BackColor = Color.Black;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox2.BackColor = Color.Black;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox6.BackColor = Color.Black;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox7.BackColor = Color.Black;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox9.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox13.BackColor = Color.Black;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox14.BackColor = Color.Black;
            pictureBox11.BorderStyle = BorderStyle.None;
            pictureBox11.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox15.BorderStyle = BorderStyle.None;
            pictureBox15.BackColor = Color.Black;
            pictureBox16.BorderStyle = BorderStyle.None;
            pictureBox16.BackColor = Color.Black;
            pictureBox17.BorderStyle = BorderStyle.None;
            pictureBox17.BackColor = Color.Black;



            if (!Instance.PanelContainer.Controls.ContainsKey("BangKhenThuong"))
            {
                BangKhenThuong bkt = new BangKhenThuong();
                bkt.Dock = DockStyle.Fill;
                Instance.PanelContainer.Controls.Add(bkt);
            }
            Instance.PanelContainer.Controls["BangKhenThuong"].BringToFront();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tenchucnang.Text = "Quản lý Nhân Viên";
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.BackColor = Color.DodgerBlue;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox4.BackColor = Color.Black;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox5.BackColor = Color.Black;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox6.BackColor = Color.Black;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox7.BackColor = Color.Black;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox9.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox13.BackColor = Color.Black;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox14.BackColor = Color.Black;
            pictureBox11.BorderStyle = BorderStyle.None;
            pictureBox11.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox15.BorderStyle = BorderStyle.None;
            pictureBox15.BackColor = Color.Black;
            pictureBox16.BorderStyle = BorderStyle.None;
            pictureBox16.BackColor = Color.Black;
            pictureBox17.BorderStyle = BorderStyle.None;
            pictureBox17.BackColor = Color.Black;
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox8.BackColor = Color.Black;

            if (!Instance.PanelContainer.Controls.ContainsKey("ListNhanVien"))
            {
                ListNhanVien lnv = new ListNhanVien();
                lnv.Dock = DockStyle.Fill;
                Instance.PanelContainer.Controls.Add(lnv);
            }
            Instance.PanelContainer.Controls["ListNhanVien"].BringToFront();

            





        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tenchucnang.Text = "Quản Lý Bảo hiểm";
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox8.BackColor = Color.Black;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.BackColor = Color.DodgerBlue;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox2.BackColor = Color.Black;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox4.BackColor = Color.Black;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox5.BackColor = Color.Black;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox6.BackColor = Color.Black;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox7.BackColor = Color.Black;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox9.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox13.BackColor = Color.Black;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox14.BackColor = Color.Black;

            pictureBox11.BorderStyle = BorderStyle.None;
            pictureBox11.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox15.BorderStyle = BorderStyle.None;
            pictureBox15.BackColor = Color.Black;
            pictureBox16.BorderStyle = BorderStyle.None;
            pictureBox16.BackColor = Color.Black;
            pictureBox17.BorderStyle = BorderStyle.None;
            pictureBox17.BackColor = Color.Black;

            if (!Instance.PanelContainer.Controls.ContainsKey("BaoHiem"))
            {
                BaoHiem bh = new BaoHiem();
                bh.Dock = DockStyle.Fill;
                Instance.PanelContainer.Controls.Add(bh);
            }
            Instance.PanelContainer.Controls["BaoHiem"].BringToFront();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tenchucnang.Text = "Quản lý lương";
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.BackColor = Color.DodgerBlue;
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox8.BackColor = Color.Black;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox3.BackColor = Color.Black;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox2.BackColor = Color.Black;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox5.BackColor = Color.Black;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox6.BackColor = Color.Black;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox7.BackColor = Color.Black;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox9.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox13.BackColor = Color.Black;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox14.BackColor = Color.Black;
            pictureBox11.BorderStyle = BorderStyle.None;
            pictureBox11.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox15.BorderStyle = BorderStyle.None;
            pictureBox15.BackColor = Color.Black;
            pictureBox16.BorderStyle = BorderStyle.None;
            pictureBox16.BackColor = Color.Black;
            pictureBox17.BorderStyle = BorderStyle.None;
            pictureBox17.BackColor = Color.Black;



            if (!Instance.PanelContainer.Controls.ContainsKey("Luong"))
            {
                Luong lg = new Luong();
                lg.Dock = DockStyle.Fill;
                Instance.PanelContainer.Controls.Add(lg);
            }
            Instance.PanelContainer.Controls["Luong"].BringToFront();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            tenchucnang.Text = "Quản lý Tuyển Dụng";
            pictureBox12.BorderStyle = BorderStyle.FixedSingle;
            pictureBox12.BackColor = Color.DodgerBlue;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox4.BackColor = Color.Black;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox5.BackColor = Color.Black;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox6.BackColor = Color.Black;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox7.BackColor = Color.Black;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox9.BackColor = Color.Black;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox2.BackColor = Color.Black;
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox13.BackColor = Color.Black;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox14.BackColor = Color.Black;
            pictureBox11.BorderStyle = BorderStyle.None;
            pictureBox11.BackColor = Color.Black;
            
            pictureBox15.BorderStyle = BorderStyle.None;
            pictureBox15.BackColor = Color.Black;
            pictureBox16.BorderStyle = BorderStyle.None;
            pictureBox16.BackColor = Color.Black;
            pictureBox17.BorderStyle = BorderStyle.None;
            pictureBox17.BackColor = Color.Black;
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox8.BackColor = Color.Black;
            if (!Instance.PanelContainer.Controls.ContainsKey("TuyenDung"))
            {
                TuyenDung td = new TuyenDung();
                td.Dock = DockStyle.Fill;
                Instance.PanelContainer.Controls.Add(td);
            }
            Instance.PanelContainer.Controls["TuyenDung"].BringToFront();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            tenchucnang.Text = "Quản lí đào tạo";
            pictureBox13.BorderStyle = BorderStyle.FixedSingle;
            pictureBox13.BackColor = Color.DodgerBlue;
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox8.BackColor = Color.Black;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox4.BackColor = Color.Black;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox5.BackColor = Color.Black;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox6.BackColor = Color.Black;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox7.BackColor = Color.Black;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox9.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox2.BackColor = Color.Black;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox14.BackColor = Color.Black;
            pictureBox11.BorderStyle = BorderStyle.None;
            pictureBox11.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox15.BorderStyle = BorderStyle.None;
            pictureBox15.BackColor = Color.Black;
            pictureBox16.BorderStyle = BorderStyle.None;
            pictureBox16.BackColor = Color.Black;
            pictureBox17.BorderStyle = BorderStyle.None;
            pictureBox17.BackColor = Color.Black;


            if (!Instance.PanelContainer.Controls.ContainsKey("DaoTao"))
            {
                DaoTao dt = new DaoTao();
                dt.Dock = DockStyle.Fill;
                Instance.PanelContainer.Controls.Add(dt);
            }
            Instance.PanelContainer.Controls["DaoTao"].BringToFront();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            tenchucnang.Text = "Quản lý Hợp Đồng";
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox8.BackColor = Color.Black;
            pictureBox14.BorderStyle = BorderStyle.FixedSingle;
            pictureBox14.BackColor = Color.DodgerBlue;

            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox4.BackColor = Color.Black;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox5.BackColor = Color.Black;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox6.BackColor = Color.Black;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox7.BackColor = Color.Black;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox9.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox13.BackColor = Color.Black;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox2.BackColor = Color.Black;
            pictureBox11.BorderStyle = BorderStyle.None;
            pictureBox11.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox15.BorderStyle = BorderStyle.None;
            pictureBox15.BackColor = Color.Black;
            pictureBox16.BorderStyle = BorderStyle.None;
            pictureBox16.BackColor = Color.Black;
            pictureBox17.BorderStyle = BorderStyle.None;
            pictureBox17.BackColor = Color.Black;

            if (!Instance.PanelContainer.Controls.ContainsKey("HopDong"))
            {
                HopDong hd = new HopDong();
                hd.Dock = DockStyle.Fill;
                Instance.PanelContainer.Controls.Add(hd);
            }
            Instance.PanelContainer.Controls["HopDong"].BringToFront();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            tenchucnang.Text = "Thêm User và Phân quyền";
            pictureBox9.BorderStyle = BorderStyle.FixedSingle;
            pictureBox9.BackColor = Color.DodgerBlue;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox4.BackColor = Color.Black;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox5.BackColor = Color.Black;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox6.BackColor = Color.Black;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox7.BackColor = Color.Black;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox2.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox13.BackColor = Color.Black;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox14.BackColor = Color.Black;
            pictureBox11.BorderStyle = BorderStyle.None;
            pictureBox11.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox15.BorderStyle = BorderStyle.None;
            pictureBox15.BackColor = Color.Black;
            pictureBox16.BorderStyle = BorderStyle.None;
            pictureBox16.BackColor = Color.Black;
            pictureBox17.BorderStyle = BorderStyle.None;
            pictureBox17.BackColor = Color.Black;
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox8.BackColor = Color.Black;
            if (!Instance.PanelContainer.Controls.ContainsKey("PhanQuyen"))
            {
                PhanQuyen hd = new PhanQuyen();
                hd.Dock = DockStyle.Fill;
                Instance.PanelContainer.Controls.Add(hd);
            }
            Instance.PanelContainer.Controls["PhanQuyen"].BringToFront();

        }

        private void pContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            tenchucnang.Text = "Quản Lí Phòng Ban";
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox2.BackColor = Color.Black;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox4.BackColor = Color.Black;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox5.BackColor = Color.Black;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox6.BackColor = Color.Black;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox7.BackColor = Color.Black;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox2.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox13.BackColor = Color.Black;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox14.BackColor = Color.Black;
            pictureBox15.BorderStyle = BorderStyle.FixedSingle;
            pictureBox15.BackColor = Color.DodgerBlue;
            pictureBox11.BorderStyle = BorderStyle.None;
            pictureBox11.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox16.BorderStyle = BorderStyle.None;
            pictureBox16.BackColor = Color.Black;
            pictureBox17.BorderStyle = BorderStyle.None;
            pictureBox17.BackColor = Color.Black;
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox8.BackColor = Color.Black; 
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox9.BackColor = Color.Black;

            if (!Instance.PanelContainer.Controls.ContainsKey("PhongBan"))
            {
                PhongBan hd = new PhongBan();
                hd.Dock = DockStyle.Fill;
                Instance.PanelContainer.Controls.Add(hd);
            }
            Instance.PanelContainer.Controls["PhongBan"].BringToFront();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            tenchucnang.Text = "Hướng Dẫn Sử Dụng";
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox2.BackColor = Color.Black;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox4.BackColor = Color.Black;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox5.BackColor = Color.Black;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox6.BackColor = Color.Black;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox7.BackColor = Color.Black;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox2.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox13.BackColor = Color.Black;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox14.BackColor = Color.Black;
            pictureBox8.BorderStyle = BorderStyle.FixedSingle;
            pictureBox8.BackColor = Color.DodgerBlue;
            pictureBox11.BorderStyle = BorderStyle.None;
            pictureBox11.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox16.BorderStyle = BorderStyle.None;
            pictureBox16.BackColor = Color.Black;
            pictureBox17.BorderStyle = BorderStyle.None;
            pictureBox17.BackColor = Color.Black;
            pictureBox15.BorderStyle = BorderStyle.None;
            pictureBox15.BackColor = Color.Black;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox9.BackColor = Color.Black;
            if (!Instance.PanelContainer.Controls.ContainsKey("HDSD"))
            {
                HDSD hd = new HDSD();
                hd.Dock = DockStyle.Fill;
                Instance.PanelContainer.Controls.Add(hd);
            }
            Instance.PanelContainer.Controls["HDSD"].BringToFront();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            tenchucnang.Text = "Quản Lí Thông tin User";
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox2.BackColor = Color.Black;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox4.BackColor = Color.Black;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox5.BackColor = Color.Black;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox6.BackColor = Color.Black;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox7.BackColor = Color.Black;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox2.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox13.BackColor = Color.Black;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox14.BackColor = Color.Black;
            pictureBox11.BorderStyle = BorderStyle.FixedSingle;
            pictureBox11.BackColor = Color.DodgerBlue;
            pictureBox15.BorderStyle = BorderStyle.None;
            pictureBox15.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox16.BorderStyle = BorderStyle.None;
            pictureBox16.BackColor = Color.Black;
            pictureBox17.BorderStyle = BorderStyle.None;
            pictureBox17.BackColor = Color.Black;
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox8.BackColor = Color.Black;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox9.BackColor = Color.Black;
            if (!Instance.PanelContainer.Controls.ContainsKey("UserInfo"))
            {
               UserInfo hd = new UserInfo();
                hd.Dock = DockStyle.Fill;
                Instance.PanelContainer.Controls.Add(hd);
            }
            Instance.PanelContainer.Controls["UserInfo"].BringToFront();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            tenchucnang.Text = "Quản Lí Chức Vụ";
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox2.BackColor = Color.Black;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox4.BackColor = Color.Black;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox5.BackColor = Color.Black;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox6.BackColor = Color.Black;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox7.BackColor = Color.Black;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox2.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox13.BackColor = Color.Black;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox14.BackColor = Color.Black;
            pictureBox17.BorderStyle = BorderStyle.FixedSingle;
            pictureBox17.BackColor = Color.DodgerBlue;
            pictureBox11.BorderStyle = BorderStyle.None;
            pictureBox11.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox16.BorderStyle = BorderStyle.None;
            pictureBox16.BackColor = Color.Black;
            pictureBox15.BorderStyle = BorderStyle.None;
            pictureBox15.BackColor = Color.Black;
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox8.BackColor = Color.Black;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox9.BackColor = Color.Black;
            if (!Instance.PanelContainer.Controls.ContainsKey("ChucVu"))
            {
                ChucVu hd = new ChucVu();
                hd.Dock = DockStyle.Fill;
                Instance.PanelContainer.Controls.Add(hd);
            }
            Instance.PanelContainer.Controls["ChucVu"].BringToFront();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            tenchucnang.Text = "Lập Báo Cáo";
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox2.BackColor = Color.Black;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox4.BackColor = Color.Black;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox5.BackColor = Color.Black;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox6.BackColor = Color.Black;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox7.BackColor = Color.Black;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox2.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox13.BackColor = Color.Black;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox14.BackColor = Color.Black;
            pictureBox16.BorderStyle = BorderStyle.FixedSingle;
            pictureBox16.BackColor = Color.DodgerBlue;
            pictureBox11.BorderStyle = BorderStyle.None;
            pictureBox11.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox15.BorderStyle = BorderStyle.None;
            pictureBox15.BackColor = Color.Black;
            pictureBox17.BorderStyle = BorderStyle.None;
            pictureBox17.BackColor = Color.Black;
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox8.BackColor = Color.Black;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox9.BackColor = Color.Black;
            if (!Instance.PanelContainer.Controls.ContainsKey("Report"))
            {
                Report hd = new Report();
                hd.Dock = DockStyle.Fill;
                Instance.PanelContainer.Controls.Add(hd);
            }
            Instance.PanelContainer.Controls["Report"].BringToFront();
        }
    }
}
