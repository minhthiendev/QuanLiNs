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
    public partial class QuaTrinhCongTac : UserControl
    {
        public QuaTrinhCongTac()
        {
            InitializeComponent();
        }
        string mnv;
        public QuaTrinhCongTac(string mnv) : this()
        {
            this.mnv = mnv;
        }
    }
}
