using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO_397_Quan_Ly_Khach_San
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
        }

        private void btnqltaikhoan_Click(object sender, EventArgs e)
        {
            frmQuanLy.frmQuanLyTaiKhoanNhanVien ql = new frmQuanLy.frmQuanLyTaiKhoanNhanVien();
            ql.Show();
        }

        private void btncapnhatthucpham_Click(object sender, EventArgs e)
        {
            frmQuanLy.frmCapNhatThucPham tp = new frmQuanLy.frmCapNhatThucPham();
            tp.Show();
        }

        private void btncapnhatphong_Click(object sender, EventArgs e)
        {
            frmQuanLy.frmCapNhatPhong ph = new frmQuanLy.frmCapNhatPhong();
            ph.Show();
        }

        private void btncapnhatdichvu_Click(object sender, EventArgs e)
        {
            frmQuanLy.frmCapNhatDichVu dv = new frmQuanLy.frmCapNhatDichVu();
            dv.Show();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
