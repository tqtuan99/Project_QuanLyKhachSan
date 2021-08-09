using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO_397_Quan_Ly_Khach_San.frmNhanVien
{
    public partial class frmQuanLyKhachHang : Form
    {
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            Form f = new frmThongKe();
            f.Show();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
