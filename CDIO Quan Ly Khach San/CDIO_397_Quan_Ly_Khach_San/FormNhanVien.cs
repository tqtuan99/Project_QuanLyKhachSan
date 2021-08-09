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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        KetNoiCSDL con = new KetNoiCSDL();

        public object MaNV { get; set; }

        void showMaNV(object MANV)
        {
            txtshowmanv.Text = MANV + "";
        }

        

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            showMaNV(MaNV);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btndatphong_Click(object sender, EventArgs e)
        {
            frmNhanVien.frmDatPhong dp = new frmNhanVien.frmDatPhong();
            dp.Show();
        }

        private void btndatdichvu_Click(object sender, EventArgs e)
        {
            frmNhanVien.frmDatDichVu ddv = new frmNhanVien.frmDatDichVu();
            ddv.Show();
        }

        private void btndatthucpham_Click(object sender, EventArgs e)
        {
            frmNhanVien.frmDatThucPham dtp = new frmNhanVien.frmDatThucPham();
            dtp.Show();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            frmNhanVien.frmThongKe tk = new frmNhanVien.frmThongKe();
            tk.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNhanVien.frmQuanLyKhachHang kh = new frmNhanVien.frmQuanLyKhachHang();
            kh.Show();
        }
    }
}
