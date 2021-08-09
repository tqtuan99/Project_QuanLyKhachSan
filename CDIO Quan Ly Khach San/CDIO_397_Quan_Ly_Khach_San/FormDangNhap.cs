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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();

        }
        KetNoiCSDL ketnoi = new KetNoiCSDL();
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string sql = "Select * from QuanLyTaiKhoan where TaiKhoan = @TaiKhoan and MatKhau = @MatKhau ";

            DataSet ds = ketnoi.GetDataSet(sql, new object[] { "@TaiKhoan", "@MatKhau" }, new object[] { txtdangnhap.Text, txtmatkhau.Text });
            if (txtdangnhap.Text == "" || txtmatkhau.Text == "")
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            if (txtdangnhap.Text=="admin" && txtmatkhau.Text == "admin")
            {
                //ok
                MessageBox.Show("Đăng nhập thành công với quyền Admin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormQuanLy ql = new FormQuanLy();
                ql.Show();
            }
            else if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                //ok
                MessageBox.Show("Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormNhanVien nv = new FormNhanVien();
                nv.MaNV = txtdangnhap.Text;
                nv.Show();
                   
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Wheat;
            this.BackColor = Color.Wheat;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }
    }
}
