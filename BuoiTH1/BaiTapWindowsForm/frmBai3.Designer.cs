namespace BaiTapWindowsForm
{
    partial class frmBai3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.rdbTongHaiSo = new System.Windows.Forms.RadioButton();
            this.txtTongDaySo = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả là: ";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(290, 371);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(46, 16);
            this.lblKetQua.TabIndex = 0;
            this.lblKetQua.Text = "testing";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTongDaySo);
            this.groupBox1.Controls.Add(this.rdbTongHaiSo);
            this.groupBox1.Location = new System.Drawing.Point(217, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn bài toán";
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(241, 313);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(143, 46);
            this.btnKetQua.TabIndex = 2;
            this.btnKetQua.Text = "Xem kết quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(217, 60);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 3;
            this.txtA.Text = "0";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(217, 103);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 3;
            this.txtB.Text = "0";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(217, 151);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 22);
            this.txtN.TabIndex = 3;
            this.txtN.Text = "0";
            // 
            // rdbTongHaiSo
            // 
            this.rdbTongHaiSo.AutoSize = true;
            this.rdbTongHaiSo.Checked = true;
            this.rdbTongHaiSo.Location = new System.Drawing.Point(48, 22);
            this.rdbTongHaiSo.Name = "rdbTongHaiSo";
            this.rdbTongHaiSo.Size = new System.Drawing.Size(105, 20);
            this.rdbTongHaiSo.TabIndex = 0;
            this.rdbTongHaiSo.TabStop = true;
            this.rdbTongHaiSo.Text = "Tính tổng a,b";
            this.rdbTongHaiSo.UseVisualStyleBackColor = true;
            // 
            // txtTongDaySo
            // 
            this.txtTongDaySo.AutoSize = true;
            this.txtTongDaySo.Location = new System.Drawing.Point(48, 61);
            this.txtTongDaySo.Name = "txtTongDaySo";
            this.txtTongDaySo.Size = new System.Drawing.Size(119, 20);
            this.txtTongDaySo.TabIndex = 0;
            this.txtTongDaySo.Text = "Tổng từ 1 đến n";
            this.txtTongDaySo.UseVisualStyleBackColor = true;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton txtTongDaySo;
        private System.Windows.Forms.RadioButton rdbTongHaiSo;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtN;
    }
}