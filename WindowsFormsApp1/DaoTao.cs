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
    public partial class DaoTao : UserControl
    {
        public DaoTao()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void DaoTao_Load(object sender, EventArgs e)
        {
            DataConnection dc = new DataConnection();
            SqlConnection connect = dc.getConnect();
            connect.Open();

            string sql = "select * from BangKeHoachDaoTao";


            SqlDataAdapter sqlad = new SqlDataAdapter(sql, connect);

            DataTable dt = new DataTable();
            sqlad.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!home.Instance.PanelContainer.Controls.ContainsKey("BaoDaoTaoNhanVien"))
            {
               BaoDaoTaoNhanVien dskl = new BaoDaoTaoNhanVien();
                dskl.Dock = DockStyle.Fill;
                home.Instance.PanelContainer.Controls.Add(dskl);
            }
            home.Instance.PanelContainer.Controls["BaoDaoTaoNhanVien"].BringToFront();
        }
    }
}
