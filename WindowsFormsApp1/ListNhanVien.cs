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
    public partial class ListNhanVien : UserControl
    {
        public ListNhanVien()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            home.Instance.LabelFunc.Text = "Thêm nhân viên";
            if (!home.Instance.PanelContainer.Controls.ContainsKey("AddNV"))
            {
                AddNV anv = new AddNV();
                anv.Dock = DockStyle.Fill;
                home.Instance.PanelContainer.Controls.Add(anv);
            }
            home.Instance.PanelContainer.Controls["AddNV"].BringToFront();
        }

        private void ListNhanVien_Load(object sender, EventArgs e)
        {
            DataConnection dc = new DataConnection();
            SqlConnection connect = dc.getConnect();
            connect.Open();

            string sql = "select * from NhanVien";


            SqlDataAdapter sqlad = new SqlDataAdapter(sql, connect);

            DataTable dt = new DataTable();
            sqlad.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["MaNV"].Value.ToString() !="")
                {
                    if (!home.Instance.PanelContainer.Controls.ContainsKey("UcNVdetail"))
                    {
                        string str = dataGridView1.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                        UcNVdetail ucnv = new UcNVdetail(str);
                        ucnv.Dock = DockStyle.Fill;
                        home.Instance.PanelContainer.Controls.Add(ucnv);
                    }
                    home.Instance.PanelContainer.Controls["UcNVdetail"].BringToFront();
                }
                else
                {
                    MessageBox.Show("Cần chọn hàng có thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
           


            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataConnection dc = new DataConnection();
            SqlConnection connect = dc.getConnect();
            connect.Open();

            string sql = "select * from NhanVien";


            SqlDataAdapter sqlad = new SqlDataAdapter(sql, connect);

            DataTable dt = new DataTable();
            sqlad.Fill(dt);
            Console.WriteLine(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sort.SelectedIndex==0)
            {
                DataConnection dc = new DataConnection();
                SqlConnection connect = dc.getConnect();
                connect.Open();

                string sql = "select * from NhanVien order by TenNV";


                SqlDataAdapter sqlad = new SqlDataAdapter(sql, connect);

                DataTable dt = new DataTable();
                sqlad.Fill(dt);
                Console.WriteLine(dt);
                dataGridView1.DataSource = dt;
                connect.Close();
            }
            else if (sort.SelectedIndex == 1)
            {
                DataConnection dc = new DataConnection();
                SqlConnection connect = dc.getConnect();
                connect.Open();

                string sql = "select * from NhanVien order by NgaySinh";


                SqlDataAdapter sqlad = new SqlDataAdapter(sql, connect);

                DataTable dt = new DataTable();
                sqlad.Fill(dt);
                Console.WriteLine(dt);
                dataGridView1.DataSource = dt;
                connect.Close();
            }
            else
            {
                MessageBox.Show("Hãy chọn Loại sắp xếp ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
