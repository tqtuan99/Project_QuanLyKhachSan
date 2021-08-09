namespace CDIO_397_Quan_Ly_Khach_San
{
    partial class FormQuanLy
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
            this.btnqltaikhoan = new System.Windows.Forms.Button();
            this.btncapnhatthucpham = new System.Windows.Forms.Button();
            this.btncapnhatphong = new System.Windows.Forms.Button();
            this.btncapnhatdichvu = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnqltaikhoan
            // 
            this.btnqltaikhoan.BackColor = System.Drawing.SystemColors.Info;
            this.btnqltaikhoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnqltaikhoan.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqltaikhoan.Location = new System.Drawing.Point(112, 88);
            this.btnqltaikhoan.Name = "btnqltaikhoan";
            this.btnqltaikhoan.Size = new System.Drawing.Size(328, 127);
            this.btnqltaikhoan.TabIndex = 0;
            this.btnqltaikhoan.Text = "Quản lý tài khoản";
            this.btnqltaikhoan.UseVisualStyleBackColor = false;
            this.btnqltaikhoan.Click += new System.EventHandler(this.btnqltaikhoan_Click);
            // 
            // btncapnhatthucpham
            // 
            this.btncapnhatthucpham.BackColor = System.Drawing.SystemColors.Info;
            this.btncapnhatthucpham.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btncapnhatthucpham.Location = new System.Drawing.Point(632, 88);
            this.btncapnhatthucpham.Name = "btncapnhatthucpham";
            this.btncapnhatthucpham.Size = new System.Drawing.Size(329, 127);
            this.btncapnhatthucpham.TabIndex = 1;
            this.btncapnhatthucpham.Text = "Cập nhật thực phẩm";
            this.btncapnhatthucpham.UseVisualStyleBackColor = false;
            this.btncapnhatthucpham.Click += new System.EventHandler(this.btncapnhatthucpham_Click);
            // 
            // btncapnhatphong
            // 
            this.btncapnhatphong.BackColor = System.Drawing.SystemColors.Info;
            this.btncapnhatphong.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btncapnhatphong.Location = new System.Drawing.Point(112, 334);
            this.btncapnhatphong.Name = "btncapnhatphong";
            this.btncapnhatphong.Size = new System.Drawing.Size(328, 127);
            this.btncapnhatphong.TabIndex = 2;
            this.btncapnhatphong.Text = "Cập nhật phòng";
            this.btncapnhatphong.UseVisualStyleBackColor = false;
            this.btncapnhatphong.Click += new System.EventHandler(this.btncapnhatphong_Click);
            // 
            // btncapnhatdichvu
            // 
            this.btncapnhatdichvu.BackColor = System.Drawing.SystemColors.Info;
            this.btncapnhatdichvu.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btncapnhatdichvu.Location = new System.Drawing.Point(632, 334);
            this.btncapnhatdichvu.Name = "btncapnhatdichvu";
            this.btncapnhatdichvu.Size = new System.Drawing.Size(329, 127);
            this.btncapnhatdichvu.TabIndex = 3;
            this.btncapnhatdichvu.Text = "Cập nhật dịch vụ";
            this.btncapnhatdichvu.UseVisualStyleBackColor = false;
            this.btncapnhatdichvu.Click += new System.EventHandler(this.btncapnhatdichvu_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.Info;
            this.btnthoat.BackgroundImage = global::CDIO_397_Quan_Ly_Khach_San.Properties.Resources.Exit;
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(971, 549);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(81, 62);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // FormQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CDIO_397_Quan_Ly_Khach_San.Properties.Resources.bgquanly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 623);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btncapnhatdichvu);
            this.Controls.Add(this.btncapnhatphong);
            this.Controls.Add(this.btncapnhatthucpham);
            this.Controls.Add(this.btnqltaikhoan);
            this.Name = "FormQuanLy";
            this.Text = "QUẢN LÝ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnqltaikhoan;
        private System.Windows.Forms.Button btncapnhatthucpham;
        private System.Windows.Forms.Button btncapnhatphong;
        private System.Windows.Forms.Button btncapnhatdichvu;
        private System.Windows.Forms.Button btnthoat;
    }
}