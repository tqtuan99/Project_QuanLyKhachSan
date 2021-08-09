namespace CDIO_397_Quan_Ly_Khach_San
{
    partial class FormNhanVien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtshowmanv = new System.Windows.Forms.Label();
            this.btndatphong = new System.Windows.Forms.Button();
            this.btndatdichvu = new System.Windows.Forms.Button();
            this.btndatthucpham = new System.Windows.Forms.Button();
            this.btndangxuat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txtshowmanv
            // 
            this.txtshowmanv.AutoSize = true;
            this.txtshowmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtshowmanv.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtshowmanv.Location = new System.Drawing.Point(1, 0);
            this.txtshowmanv.Name = "txtshowmanv";
            this.txtshowmanv.Size = new System.Drawing.Size(149, 25);
            this.txtshowmanv.TabIndex = 1;
            this.txtshowmanv.Text = "SHOW MANV";
            // 
            // btndatphong
            // 
            this.btndatphong.BackColor = System.Drawing.Color.Lime;
            this.btndatphong.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btndatphong.Location = new System.Drawing.Point(632, 167);
            this.btndatphong.Name = "btndatphong";
            this.btndatphong.Size = new System.Drawing.Size(328, 127);
            this.btndatphong.TabIndex = 3;
            this.btndatphong.Text = "Đặt phòng";
            this.btndatphong.UseVisualStyleBackColor = false;
            this.btndatphong.Click += new System.EventHandler(this.btndatphong_Click);
            // 
            // btndatdichvu
            // 
            this.btndatdichvu.BackColor = System.Drawing.Color.Lime;
            this.btndatdichvu.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btndatdichvu.Location = new System.Drawing.Point(65, 349);
            this.btndatdichvu.Name = "btndatdichvu";
            this.btndatdichvu.Size = new System.Drawing.Size(328, 127);
            this.btndatdichvu.TabIndex = 4;
            this.btndatdichvu.Text = "Đặt dịch vụ";
            this.btndatdichvu.UseVisualStyleBackColor = false;
            this.btndatdichvu.Click += new System.EventHandler(this.btndatdichvu_Click);
            // 
            // btndatthucpham
            // 
            this.btndatthucpham.BackColor = System.Drawing.Color.Lime;
            this.btndatthucpham.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btndatthucpham.Location = new System.Drawing.Point(632, 349);
            this.btndatthucpham.Name = "btndatthucpham";
            this.btndatthucpham.Size = new System.Drawing.Size(328, 127);
            this.btndatthucpham.TabIndex = 5;
            this.btndatthucpham.Text = "Đặt thực phẩm";
            this.btndatthucpham.UseVisualStyleBackColor = false;
            this.btndatthucpham.Click += new System.EventHandler(this.btndatthucpham_Click);
            // 
            // btndangxuat
            // 
            this.btndangxuat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btndangxuat.BackgroundImage = global::CDIO_397_Quan_Ly_Khach_San.Properties.Resources.Exit;
            this.btndangxuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangxuat.ForeColor = System.Drawing.Color.Cornsilk;
            this.btndangxuat.Location = new System.Drawing.Point(919, 549);
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(81, 62);
            this.btndangxuat.TabIndex = 7;
            this.btndangxuat.UseVisualStyleBackColor = false;
            this.btndangxuat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(65, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 127);
            this.button1.TabIndex = 8;
            this.button1.Text = "Quản lý khách hàng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CDIO_397_Quan_Ly_Khach_San.Properties.Resources.bgrNhanVien;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 623);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btndangxuat);
            this.Controls.Add(this.btndatthucpham);
            this.Controls.Add(this.btndatdichvu);
            this.Controls.Add(this.btndatphong);
            this.Controls.Add(this.txtshowmanv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormNhanVien";
            this.Text = "NHÂN VIÊN";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label txtshowmanv;
        private System.Windows.Forms.Button btndatphong;
        private System.Windows.Forms.Button btndatdichvu;
        private System.Windows.Forms.Button btndatthucpham;
        private System.Windows.Forms.Button btndangxuat;
        private System.Windows.Forms.Button button1;
    }
}