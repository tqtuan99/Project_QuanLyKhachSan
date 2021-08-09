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
    public partial class frmCapNhatPhong : Form
    {
        public frmCapNhatPhong()
        {
            InitializeComponent();
        }

        KetNoiCSDL connect = new KetNoiCSDL();

        void loadData()
        {
            DataSet ds = connect.GetDataSet("Select * from Phong", null, null);//lấy tất cả
            dataGridViewcapnhapphong.DataSource = ds.Tables[0];
        }
        private void frmCapNhatPhong_Load(object sender, EventArgs e)
        {
            dataGridViewcapnhapphong.AutoGenerateColumns = false;
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool tt;
            if (cbtinhtrang.Checked) { tt = true; } else tt = false;

            if (txtmaphong.Text == "")
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataSet ds = connect.GetDataSet("Select * from Phong where MaPhong= @MP", new object[] { "@MP" }, new object[] { txtmaphong.Text });
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Mã phòng đã tồn tại. Vui lòng chọn mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connect.execNonQuery("insert into Phong values (@MaP, @LoaiP, @ViTri, @GiaThue, @TT, @ChucNang, @GhiChu)",
                new object[] { "@MaP", "@LoaiP", "@ViTri", "@GiaThue", "@TT", "@ChucNang", "@GhiChu" },
                new object[] { txtmaphong.Text, txtloaiphong.Text,txtvitri.Text, txtgiathue.Text, tt, txtchucnang.Text,txtghichu.Text });
            MessageBox.Show("Thêm mới thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmaphong.Text == "") MessageBox.Show("Bạn cần nhập mã phòng để xóa.", "TB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                connect.GetDataSet("delete from Phong where MaPhong =@MAP", new object[] { "@MAP" }, new object[] { txtmaphong.Text });
                MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnlammoi_Click(sender, e);
                loadData();
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmaphong.ResetText();
            txtloaiphong.ResetText();    
            txtgiathue.ResetText();
            txtvitri.ResetText();
            txtchucnang.ResetText();
            cbtinhtrang.Checked = false;
            txtghichu.ResetText();
        }

        private void dataGridViewcapnhapphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtmaphong.Text = dataGridViewcapnhapphong.Rows[e.RowIndex].Cells[0].Value + "";
            txtloaiphong.Text = dataGridViewcapnhapphong.Rows[e.RowIndex].Cells[1].Value + "";
            txtvitri.Text = dataGridViewcapnhapphong.Rows[e.RowIndex].Cells[2].Value + "";
            txtgiathue.Text = dataGridViewcapnhapphong.Rows[e.RowIndex].Cells[3].Value + "";
            cbtinhtrang.Checked = (bool)dataGridViewcapnhapphong.Rows[e.RowIndex].Cells[4].Value;
            txtchucnang.Text = dataGridViewcapnhapphong.Rows[e.RowIndex].Cells[5].Value + "";
            txtghichu.Text = dataGridViewcapnhapphong.Rows[e.RowIndex].Cells[6].Value + "";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            bool tt;
            if (cbtinhtrang.Checked) { tt = true; } else tt = false;

            if (txtloaiphong.Text == "" || txtgiathue.Text == "" || txtchucnang.Text == "" || txtvitri.Text == "")
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataSet ds = connect.GetDataSet("Select * from Phong where MaPhong= @MP", new object[] { "@MP" }, new object[] { txtmaphong.Text });
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                connect.execNonQuery("update Phong set LoaiPhong=@LoaiP, ViTri=@ViTri, GiaThue=@GiaThue,TinhTrang= @TT, ChucNang=@ChucNang,GhiChu= @GhiChu where MaPhong = @MaP",
               new object[] { "@MaP", "@LoaiP", "@ViTri", "@GiaThue", "@TT", "@ChucNang", "@GhiChu" },
               new object[] { txtmaphong.Text, txtloaiphong.Text, txtvitri.Text, txtgiathue.Text, tt, txtchucnang.Text, txtghichu.Text });
                MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Mã phòng không tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
