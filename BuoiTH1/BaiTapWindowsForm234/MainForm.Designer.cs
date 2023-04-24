namespace BaiTapWindowsForm2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bàiKiểmTraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbBai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bàiKiểmTraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bàiKiểmTraToolStripMenuItem
            // 
            this.bàiKiểmTraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBai1,
            this.tsbBai2,
            this.tsbBai3});
            this.bàiKiểmTraToolStripMenuItem.Name = "bàiKiểmTraToolStripMenuItem";
            this.bàiKiểmTraToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.bàiKiểmTraToolStripMenuItem.Text = "Bài kiểm tra";
            // 
            // tsbBai1
            // 
            this.tsbBai1.Image = ((System.Drawing.Image)(resources.GetObject("tsbBai1.Image")));
            this.tsbBai1.Name = "tsbBai1";
            this.tsbBai1.Size = new System.Drawing.Size(224, 26);
            this.tsbBai1.Text = "Bài số 1";
            this.tsbBai1.Click += new System.EventHandler(this.tsbBai1_Click);
            // 
            // tsbBai2
            // 
            this.tsbBai2.Image = ((System.Drawing.Image)(resources.GetObject("tsbBai2.Image")));
            this.tsbBai2.Name = "tsbBai2";
            this.tsbBai2.Size = new System.Drawing.Size(224, 26);
            this.tsbBai2.Text = "Bài số 2";
            this.tsbBai2.Click += new System.EventHandler(this.tsbBai2_Click);
            // 
            // tsbBai3
            // 
            this.tsbBai3.Image = ((System.Drawing.Image)(resources.GetObject("tsbBai3.Image")));
            this.tsbBai3.Name = "tsbBai3";
            this.tsbBai3.Size = new System.Drawing.Size(224, 26);
            this.tsbBai3.Text = "Bài số 3";
            this.tsbBai3.Click += new System.EventHandler(this.tsbBai3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Chương trình chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bàiKiểmTraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsbBai1;
        private System.Windows.Forms.ToolStripMenuItem tsbBai2;
        private System.Windows.Forms.ToolStripMenuItem tsbBai3;
    }
}

