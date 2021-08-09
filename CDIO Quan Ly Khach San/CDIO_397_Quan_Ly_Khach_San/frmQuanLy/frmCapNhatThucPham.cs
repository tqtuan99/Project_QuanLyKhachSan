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
    public partial class frmCapNhatThucPham : Form
    {
        public frmCapNhatThucPham()
        {
            InitializeComponent();
        }

        KetNoiCSDL connect = new KetNoiCSDL();

        void loadData()
        {
            DataSet ds = connect.GetDataSet("Select * from ThucPham", null, null);
            dataGridViewcapnhatthucpham.DataSource = ds.Tables[0];
        }

        private void frmCapNhatThucPham_Load(object sender, EventArgs e)
        {
            dataGridViewcapnhatthucpham.AutoGenerateColumns = false;
            loadData();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmathucpham.ResetText();
            txttenthucpham.ResetText();
            txtdongia.ResetText();
            txtsoluonghienco.ResetText();
            txtghichu.ResetText();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (txtmathucpham.Text == "") MessageBox.Show("Bạn cần nhập mã thực phẩm để xóa.", "TB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                connect.GetDataSet("delete from ThucPham where MaTP =@MATP", new object[] { "@MATP" }, new object[] { txtmathucpham.Text });
                MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnlammoi_Click(sender, e);
                loadData();
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            if (txtmathucpham.Text == "" || txttenthucpham.Text == "" || txtdongia.Text == "" || txtsoluonghienco.Text == "")
            {
                MessageBox.Show("Phải nhập (Mã, Tên, Giá, số lượng hiện có) đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataSet ds = connect.GetDataSet("Select * from ThucPham where MaTP= @MTP", new object[] { "@MTP" }, new object[] { txtmathucpham.Text });
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Mã thực phẩm đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connect.execNonQuery("insert into ThucPham values (@MaTP,@TenTP, @SLC, @DG, @GhiChu)",
                 new object[] { "@MaTP", "@TenTP", "@SLC", "@DG", "@GhiChu" },
                 new object[] { txtmathucpham.Text, txttenthucpham.Text, txtsoluonghienco.Text, txtdongia.Text, txtghichu.Text });
            MessageBox.Show("Thêm mới thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmathucpham.Text == "" || txttenthucpham.Text == ""||txtdongia.Text==""||txtsoluonghienco.Text=="")
            {
                MessageBox.Show("Phải nhập (Mã, Tên, Giá, số lượng hiện có) đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataSet ds = connect.GetDataSet("Select * from ThucPham where MaTP= @MTP", new object[] { "@MTP" }, new object[] { txtmathucpham.Text });
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                connect.execNonQuery("update ThucPham set TenTP =@TenTP, SoLuongCo=@SLC, DonGia=@DG,GhiChu= @GhiChu where MaTP =@MaTP",
                 new object[] { "@MaTP", "@TenTP", "@SLC", "@DG", "@GhiChu" },
                 new object[] { txtmathucpham.Text, txttenthucpham.Text, txtsoluonghienco.Text, txtdongia.Text, txtghichu.Text });
                MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Mã dịch vụ không tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewcapnhatthucpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmathucpham.Text = dataGridViewcapnhatthucpham.Rows[e.RowIndex].Cells[0].Value + "";
            txttenthucpham.Text = dataGridViewcapnhatthucpham.Rows[e.RowIndex].Cells[1].Value + "";
            txtdongia.Text = dataGridViewcapnhatthucpham.Rows[e.RowIndex].Cells[3].Value + "";
            txtsoluonghienco.Text = dataGridViewcapnhatthucpham.Rows[e.RowIndex].Cells[2].Value + "";
            txtghichu.Text = dataGridViewcapnhatthucpham.Rows[e.RowIndex].Cells[4].Value + "";
        }
    }
}
