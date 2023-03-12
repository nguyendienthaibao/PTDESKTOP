namespace BaiTapLyThuyetBuoi2
{
    partial class frm60
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
            this.clbMonHoc = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // clbMonHoc
            // 
            this.clbMonHoc.FormattingEnabled = true;
            this.clbMonHoc.Items.AddRange(new object[] {
            "Tiếng Anh Chuyên Ngành",
            "Quản Trị Mạng ",
            "Đồ Họa",
            "OOP",
            "Nhập Môn CNTT",
            "Thiết Kế Web",
            "Bảo Trì Máy Tính ",
            "Mạng Máy Tính",
            "CSDL"});
            this.clbMonHoc.Location = new System.Drawing.Point(2, 23);
            this.clbMonHoc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clbMonHoc.MultiColumn = true;
            this.clbMonHoc.Name = "clbMonHoc";
            this.clbMonHoc.Size = new System.Drawing.Size(382, 368);
            this.clbMonHoc.TabIndex = 1;
            this.clbMonHoc.SelectedIndexChanged += new System.EventHandler(this.clbMonHoc_SelectedIndexChanged);
            // 
            // frm60
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.clbMonHoc);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frm60";
            this.Text = "Demo CheckListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbMonHoc;
    }
}