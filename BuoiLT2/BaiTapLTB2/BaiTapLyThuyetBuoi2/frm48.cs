﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLyThuyetBuoi2
{
    public partial class frm48 : Form
    {
        public frm48()
        {
            InitializeComponent();
        }

        private void Form48_Load(object sender, EventArgs e)
        {
            string[] datas = {"Tiếng Anh","Tiếng Thái","Tiếng Trung","Tiếng Việt"};
           this.cboNgoaiNgu.DataSource = datas;
        }

        private void cboNgoaiNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.cboNgoaiNgu.SelectedItem.ToString());
        }
    }
}
