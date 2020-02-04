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
    public partial class Luong : UserControl
    {
        public Luong()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!home.Instance.PanelContainer.Controls.ContainsKey("BangLuong"))
            {
                BangLuong bl = new BangLuong();
                bl.Dock = DockStyle.Fill;
                home.Instance.PanelContainer.Controls.Add(bl);
            }
            home.Instance.PanelContainer.Controls["BangLuong"].BringToFront();
        }
    }
}
