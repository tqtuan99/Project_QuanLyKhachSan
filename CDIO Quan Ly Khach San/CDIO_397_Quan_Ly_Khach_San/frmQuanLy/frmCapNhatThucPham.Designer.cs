namespace CDIO_397_Quan_Ly_Khach_San.frmQuanLy
{
    partial class frmCapNhatThucPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btndong = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthemmoi = new System.Windows.Forms.Button();
            this.dataGridViewcapnhatthucpham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsoluonghienco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttenthucpham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmathucpham = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlammoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcapnhatthucpham)).BeginInit();
            this.SuspendLayout();
            // 
            // btndong
            // 
            this.btndong.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btndong.BackgroundImage = global::CDIO_397_Quan_Ly_Khach_San.Properties.Resources.Return;
            this.btndong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Location = new System.Drawing.Point(987, 544);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(82, 70);
            this.btndong.TabIndex = 12;
            this.btndong.UseVisualStyleBackColor = false;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackgroundImage = global::CDIO_397_Quan_Ly_Khach_San.Properties.Resources.frmchildQuanLy;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(396, 562);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(105, 42);
            this.btnxoa.TabIndex = 11;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackgroundImage = global::CDIO_397_Quan_Ly_Khach_San.Properties.Resources.frmchildQuanLy;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(207, 562);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(105, 42);
            this.btnsua.TabIndex = 10;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthemmoi
            // 
            this.btnthemmoi.BackgroundImage = global::CDIO_397_Quan_Ly_Khach_San.Properties.Resources.frmchildQuanLy;
            this.btnthemmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemmoi.Location = new System.Drawing.Point(31, 562);
            this.btnthemmoi.Name = "btnthemmoi";
            this.btnthemmoi.Size = new System.Drawing.Size(105, 42);
            this.btnthemmoi.TabIndex = 9;
            this.btnthemmoi.Text = "Thêm mới";
            this.btnthemmoi.UseVisualStyleBackColor = true;
            this.btnthemmoi.Click += new System.EventHandler(this.btnthemmoi_Click);
            // 
            // dataGridViewcapnhatthucpham
            // 
            this.dataGridViewcapnhatthucpham.AllowUserToAddRows = false;
            this.dataGridViewcapnhatthucpham.AllowUserToDeleteRows = false;
            this.dataGridViewcapnhatthucpham.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewcapnhatthucpham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewcapnhatthucpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcapnhatthucpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewcapnhatthucpham.Location = new System.Drawing.Point(0, 143);
            this.dataGridViewcapnhatthucpham.Name = "dataGridViewcapnhatthucpham";
            this.dataGridViewcapnhatthucpham.RowHeadersWidth = 51;
            this.dataGridViewcapnhatthucpham.RowTemplate.Height = 24;
            this.dataGridViewcapnhatthucpham.Size = new System.Drawing.Size(1081, 376);
            this.dataGridViewcapnhatthucpham.TabIndex = 13;
            this.dataGridViewcapnhatthucpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewcapnhatthucpham_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaTP";
            this.Column1.HeaderText = "Mã thực phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenTP";
            this.Column2.HeaderText = "Tên Thực phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuongCo";
            this.Column3.HeaderText = "Số lượng hiện có";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DonGia";
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "GhiChu";
            this.Column5.HeaderText = "Ghi chú";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(885, 24);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(184, 22);
            this.txtghichu.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(792, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 57;
            this.label8.Text = "Ghi chú";
            // 
            // txtsoluonghienco
            // 
            this.txtsoluonghienco.Location = new System.Drawing.Point(560, 82);
            this.txtsoluonghienco.Name = "txtsoluonghienco";
            this.txtsoluonghienco.Size = new System.Drawing.Size(160, 22);
            this.txtsoluonghienco.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "Số lượng hiện có";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(560, 27);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(160, 22);
            this.txtdongia.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Đơn giá";
            // 
            // txttenthucpham
            // 
            this.txttenthucpham.Location = new System.Drawing.Point(148, 79);
            this.txttenthucpham.Name = "txttenthucpham";
            this.txttenthucpham.Size = new System.Drawing.Size(181, 22);
            this.txttenthucpham.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Tên thực phẩm";
            // 
            // txtmathucpham
            // 
            this.txtmathucpham.Location = new System.Drawing.Point(148, 24);
            this.txtmathucpham.Name = "txtmathucpham";
            this.txtmathucpham.Size = new System.Drawing.Size(181, 22);
            this.txtmathucpham.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Mã thực phẩm";
            // 
            // btnlammoi
            // 
            this.btnlammoi.BackgroundImage = global::CDIO_397_Quan_Ly_Khach_San.Properties.Resources.frmchildQuanLy;
            this.btnlammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoi.Location = new System.Drawing.Point(581, 562);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(105, 42);
            this.btnlammoi.TabIndex = 59;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // frmCapNhatThucPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CDIO_397_Quan_Ly_Khach_San.Properties.Resources.frmchildQuanLy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1081, 626);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtsoluonghienco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttenthucpham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmathucpham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewcapnhatthucpham);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthemmoi);
            this.Name = "frmCapNhatThucPham";
            this.Text = "Cập nhật thực phẩm";
            this.Load += new System.EventHandler(this.frmCapNhatThucPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcapnhatthucpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthemmoi;
        private System.Windows.Forms.DataGridView dataGridViewcapnhatthucpham;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsoluonghienco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttenthucpham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmathucpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}