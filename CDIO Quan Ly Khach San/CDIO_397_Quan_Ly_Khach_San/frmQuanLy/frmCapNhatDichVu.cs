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
    public partial class frmCapNhatDichVu : Form
    {
        public frmCapNhatDichVu()
        {
            InitializeComponent();
        }
        KetNoiCSDL connect = new KetNoiCSDL();

        void loadData()
        {
            DataSet ds = connect.GetDataSet("select * from DichVu", null, null);
            dataGridViewcapnhatdichvu.DataSource = ds.Tables[0];
        }

        private void frmCapNhatDichVu_Load(object sender, EventArgs e)
        {
            dataGridViewcapnhatdichvu.AutoGenerateColumns = false;
            loadData();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (txtmadichvu.Text == "") MessageBox.Show("Bạn cần nhập mã dịch vụ để xóa.", "TB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                connect.GetDataSet("delete from DichVu where MaDV =@MADV", new object[] { "@MADV" }, new object[] { txtmadichvu.Text });
                MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnlammoi_Click(sender, e);
                loadData();
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmadichvu.ResetText();
            txttendichvu.ResetText();
            txtgiadichvu.ResetText();
            txtghichu.ResetText();
            txtdiadiem.ResetText();
        }

        private void dataGridViewcapnhatdichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtmadichvu.Text = dataGridViewcapnhatdichvu.Rows[e.RowIndex].Cells[0].Value + "";
            txttendichvu.Text = dataGridViewcapnhatdichvu.Rows[e.RowIndex].Cells[1].Value + "";
            txtgiadichvu.Text = dataGridViewcapnhatdichvu.Rows[e.RowIndex].Cells[2].Value + "";
            txtdiadiem.Text = dataGridViewcapnhatdichvu.Rows[e.RowIndex].Cells[3].Value + "";
            txtghichu.Text = dataGridViewcapnhatdichvu.Rows[e.RowIndex].Cells[4].Value + "";
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            if (txtmadichvu.Text == ""||txttendichvu.Text==""||txtgiadichvu.Text=="")
            {
                MessageBox.Show("Phải nhập (Mã, Tên, Giá) đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataSet ds = connect.GetDataSet("Select * from DichVu where MaDV= @MDV", new object[] { "@MDV" }, new object[] { txtmadichvu.Text });
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Mã dịch vụ đã tồn tại. Vui lòng chọn mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connect.execNonQuery("insert into DichVu values (@MaDV, @TenDV, @GiaDV, @Diadiem, @GhiChu)",
                new object[] { "@MaDV", "@TenDV", "@GiaDV", "@DiaDiem", "@GhiChu" },
                new object[] { txtmadichvu.Text, txttendichvu.Text, txtgiadichvu.Text, txtdiadiem.Text, txtghichu.Text});
            MessageBox.Show("Thêm mới thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txttendichvu.Text == "" || txtgiadichvu.Text == "")
            {
                MessageBox.Show("Phải nhập (Mã, Tên, Giá) đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataSet ds = connect.GetDataSet("Select * from DichVu where MaDV= @MDV", new object[] { "@MDV" }, new object[] { txtmadichvu.Text });
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                connect.execNonQuery("update DichVu set TenDV =@TenDV, GiaDV=@GiaDV, DiaDiem=@Diadiem,GhiChu= @GhiChu where MaDV =@MaDV",
                 new object[] { "@MaDV", "@TenDV", "@GiaDV", "@Diadiem", "@GhiChu" },
                 new object[] { txtmadichvu.Text, txttendichvu.Text, txtgiadichvu.Text, txtdiadiem.Text, txtghichu.Text });               
                MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Mã dịch vụ không tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
