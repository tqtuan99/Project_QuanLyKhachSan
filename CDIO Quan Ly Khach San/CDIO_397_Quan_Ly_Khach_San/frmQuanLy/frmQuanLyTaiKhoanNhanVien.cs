using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO_397_Quan_Ly_Khach_San.frmQuanLy
{
    public partial class frmQuanLyTaiKhoanNhanVien : Form
    {
        public frmQuanLyTaiKhoanNhanVien()
        {
            InitializeComponent();
        }

        KetNoiCSDL connect = new KetNoiCSDL();
        void loadData()
        {
            DataSet ds = connect.GetDataSet("Select * from NhanVien,QuanLyTaiKhoan Where NhanVien.MaNV = QuanLyTaiKhoan.MaNV", null, null);
            dataGridViewquanlytaikhoannhanvien.DataSource = ds.Tables[0];
        }
        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            dataGridViewquanlytaikhoannhanvien.AutoGenerateColumns = false;
            loadData();
        }    

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewquanlytaikhoannhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool gt;
            if (cbgioitinh.Checked) { gt = true; } else gt = false;

            if (txtmanhanvien.Text == "")
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataSet ds = connect.GetDataSet("Select * from NhanVien where MaNV= @MNV", new object[] { "@MNV" }, new object[] { txtmanhanvien.Text });
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng chọn mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connect.execNonQuery("insert into NhanVien values (@MaNV, @HoTen, @GioiTinh, @CCCD, @NgaySinh, @DiaChi, @SoDT)",
                new object[] { "@MaNV", "@HoTen", "@GioiTinh", "@CCCD", "@NgaySinh", "@DiaChi", "@SoDT" },
                new object[] {txtmanhanvien.Text,txttennhanvien.Text,gt,txtcccd.Text,dtngaysinh.Value, txtdiachi.Text, txtsodienthoai.Text});
            connect.execNonQuery("insert into QuanLyTaiKhoan values (@TaiKhoan, @MatKhau, @MaNV)", new object[] { "@TaiKhoan", "@MatKhau", "@MaNV" }, new object[] { txtmanhanvien.Text, "1", txtmanhanvien.Text});
            MessageBox.Show("Thêm mới thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();
        }

        private void dataGridViewquanlytaikhoannhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                if (e.RowIndex < 0) return;
                txtmanhanvien.Text = dataGridViewquanlytaikhoannhanvien.Rows[e.RowIndex].Cells[0].Value + "";
                txttennhanvien.Text = dataGridViewquanlytaikhoannhanvien.Rows[e.RowIndex].Cells[1].Value + "";
                cbgioitinh.Checked = (bool)dataGridViewquanlytaikhoannhanvien.Rows[e.RowIndex].Cells[2].Value;
                txtcccd.Text = dataGridViewquanlytaikhoannhanvien.Rows[e.RowIndex].Cells[3].Value + "";
                dtngaysinh.Value = Convert.ToDateTime(dataGridViewquanlytaikhoannhanvien.Rows[e.RowIndex].Cells[4].Value);
                txtdiachi.Text = dataGridViewquanlytaikhoannhanvien.Rows[e.RowIndex].Cells[5].Value + "";
                txtsodienthoai.Text = dataGridViewquanlytaikhoannhanvien.Rows[e.RowIndex].Cells[6].Value + "";
           
                             
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmanhanvien.Text == "") MessageBox.Show("Bạn cần nhập mã nhân viên để xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (MessageBox.Show("Bạn có muốn xóa không?", "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                connect.GetDataSet("delete from NhanVien where MaNV =@MANV", new object[] { "@MANV" }, new object[] { txtmanhanvien.Text });
                connect.GetDataSet("delete from QuanLyTaiKhoan where MaNV =@MANV", new object[] { "@MANV" }, new object[] { txtmanhanvien.Text });
                MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnlammoi_Click(sender, e);
                loadData();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            bool gt;
            if (cbgioitinh.Checked) { gt = true; } else gt = false;

            if (txtmanhanvien.Text == ""||txttennhanvien.Text==""||txtsodienthoai.Text==""||txtdiachi.Text==""||txtcccd.Text==""||dtngaysinh.Text=="")
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataSet ds = connect.GetDataSet("Select * from NhanVien where MaNV= @MNV", new object[] { "@MNV" }, new object[] { txtmanhanvien.Text });
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                connect.execNonQuery("update NhanVien set HoTen= @HoTen,GioiTinh= @GioiTinh,CCCD= @CCCD,NgaySinh= @NgaySinh, DiaChi=@DiaChi,SoDienThoai= @SoDT where  MaNV =@MaNV",
               new object[] { "@MaNV", "@HoTen", "@GioiTinh", "@CCCD", "@NgaySinh", "@DiaChi", "@SoDT" },
               new object[] { txtmanhanvien.Text, txttennhanvien.Text, gt, txtcccd.Text, dtngaysinh.Value, txtdiachi.Text, txtsodienthoai.Text });
                MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Mã nhân viên không tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmanhanvien.ResetText();
            txttennhanvien.ResetText();
            txtsodienthoai.ResetText();
            txtdiachi.ResetText();
            txtcccd.ResetText();
            dtngaysinh.ResetText();
            cbgioitinh.Checked = false;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
