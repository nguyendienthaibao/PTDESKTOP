namespace BaiTapLyThuyetBuoi2
{
    partial class frm52
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
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.lbDanhSach = new System.Windows.Forms.ListBox();
            this.LbDanhSachChon = new System.Windows.Forms.ListBox();
            this.lblDanhSachChon = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Location = new System.Drawing.Point(24, 77);
            this.lblDanhSach.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(242, 25);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "Danh sách sinh viên lớp";
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.FormattingEnabled = true;
            this.lbDanhSach.ItemHeight = 25;
            this.lbDanhSach.Items.AddRange(new object[] {
            "Nguyen Van A",
            "Le Van C",
            "Mai Thanh B",
            "Do Van F"});
            this.lbDanhSach.Location = new System.Drawing.Point(36, 131);
            this.lbDanhSach.Margin = new System.Windows.Forms.Padding(6);
            this.lbDanhSach.MultiColumn = true;
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.Size = new System.Drawing.Size(316, 379);
            this.lbDanhSach.TabIndex = 1;
            // 
            // LbDanhSachChon
            // 
            this.LbDanhSachChon.FormattingEnabled = true;
            this.LbDanhSachChon.ItemHeight = 25;
            this.LbDanhSachChon.Location = new System.Drawing.Point(492, 131);
            this.LbDanhSachChon.Margin = new System.Windows.Forms.Padding(6);
            this.LbDanhSachChon.MultiColumn = true;
            this.LbDanhSachChon.Name = "LbDanhSachChon";
            this.LbDanhSachChon.Size = new System.Drawing.Size(370, 379);
            this.LbDanhSachChon.TabIndex = 1;
            // 
            // lblDanhSachChon
            // 
            this.lblDanhSachChon.AutoSize = true;
            this.lblDanhSachChon.Location = new System.Drawing.Point(432, 77);
            this.lblDanhSachChon.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDanhSachChon.Name = "lblDanhSachChon";
            this.lblDanhSachChon.Size = new System.Drawing.Size(295, 25);
            this.lblDanhSachChon.TabIndex = 0;
            this.lblDanhSachChon.Text = "Danh sách sinh viên tham gia";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(368, 250);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 40);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(368, 327);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frm52
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.LbDanhSachChon);
            this.Controls.Add(this.lbDanhSach);
            this.Controls.Add(this.lblDanhSachChon);
            this.Controls.Add(this.lblDanhSach);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm52";
            this.Text = "frm52";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.ListBox lbDanhSach;
        private System.Windows.Forms.ListBox LbDanhSachChon;
        private System.Windows.Forms.Label lblDanhSachChon;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnXoa;
    }
}