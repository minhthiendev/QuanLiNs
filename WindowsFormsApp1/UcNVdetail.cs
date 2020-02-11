using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class UcNVdetail : UserControl
    {
        static UcNVdetail _obj;
        public static UcNVdetail Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UcNVdetail();
                }
                return _obj;
            }
        }

        public Panel PanelContainer
        {
            get { return pContainer1; }
            set { pContainer1 = value; }
        }

       
        public UcNVdetail()
        {
            InitializeComponent();
        }
        string manv;
        public UcNVdetail(string str) : this()
        {
            this.manv = str;
        }
       



        private void UcNVdetail_Load(object sender, EventArgs e)
        {
            _obj = this;
            hoso.BackColor = Color.Azure;
            
            Profile pr = new Profile(this.manv);
            pr.Dock = DockStyle.Fill;
            pContainer1.Controls.Add(pr);
         

        }

        private void hoso_Click(object sender, EventArgs e)
        {
            hoso.BackColor = Color.Azure;

            if (!Instance.PanelContainer.Controls.ContainsKey("Profile"))
            {
                Profile pr = new Profile();
                pr.Dock = DockStyle.Fill;
                Instance.PanelContainer.Controls.Add(pr);
            }
            Instance.PanelContainer.Controls["Profile"].BringToFront();
        }

        private void nhânThânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Instance.PanelContainer.Controls.ContainsKey("CTHopDong"))
            {
                CTHopDong cthd = new CTHopDong();
                cthd.Dock = DockStyle.Fill;
                Instance.PanelContainer.Controls.Add(cthd);
            }
           Instance.PanelContainer.Controls["CTHopDong"].BringToFront();

        }

        private void nhânThânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Instance.PanelContainer.Controls.ContainsKey("ThanNhan"))
            {
                ThanNhan tn = new ThanNhan();
                tn.Dock = DockStyle.Fill;
                Instance.PanelContainer.Controls.Add(tn);
            }
            Instance.PanelContainer.Controls["ThanNhan"].BringToFront();
        }

        private void thưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Instance.PanelContainer.Controls.ContainsKey("ThuongOfNV"))
            {
                ThuongOfNV tonv = new ThuongOfNV();
                tonv.Dock = DockStyle.Fill;
                Instance.PanelContainer.Controls.Add(tonv);
            }
            Instance.PanelContainer.Controls["ThuongOfNV"].BringToFront();
        }

        private void kĩLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Instance.PanelContainer.Controls.ContainsKey("KLofNV"))
            {
                KLofNV tonv = new KLofNV();
                tonv.Dock = DockStyle.Fill;
                Instance.PanelContainer.Controls.Add(tonv);
            }
            Instance.PanelContainer.Controls["KLofNV"].BringToFront();
        }

        private void thaiSảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
