namespace QLBH
{
	partial class ThemLoai
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
			this.btnThemLoai = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTenLoai = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnThemLoai
			// 
			this.btnThemLoai.Location = new System.Drawing.Point(276, 69);
			this.btnThemLoai.Name = "btnThemLoai";
			this.btnThemLoai.Size = new System.Drawing.Size(75, 23);
			this.btnThemLoai.TabIndex = 11;
			this.btnThemLoai.Text = "Thêm";
			this.btnThemLoai.UseVisualStyleBackColor = true;
			this.btnThemLoai.Click += new System.EventHandler(this.btnThemLoai_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(43, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Tên loại";
			// 
			// txtTenLoai
			// 
			this.txtTenLoai.Location = new System.Drawing.Point(112, 71);
			this.txtTenLoai.Name = "txtTenLoai";
			this.txtTenLoai.Size = new System.Drawing.Size(141, 20);
			this.txtTenLoai.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(153, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Thêm loại mặt hàng";
			// 
			// ThemLoai
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 187);
			this.Controls.Add(this.btnThemLoai);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTenLoai);
			this.Controls.Add(this.label1);
			this.Name = "ThemLoai";
			this.Text = "ThemLoai";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnThemLoai;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTenLoai;
		private System.Windows.Forms.Label label1;
	}
}