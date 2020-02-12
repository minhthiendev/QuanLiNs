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
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox9.BackColor = Color.Black;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox12.BackColor = Color.Black;
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox13.BackColor = Color.Black;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox14.BackColor = Color.Black;

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
            tenchucnang.Text = "Phân quyền";
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

        }
    }
}
