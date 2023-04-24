using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsbBai1_Click(object sender, EventArgs e)
        {
            var btn = new frmBai1();
            btn.ShowDialog();
        }

        private void tsbBai2_Click(object sender, EventArgs e)
        {
            var btn = new frmBai2();
            btn.ShowDialog();
        }

        private void tsbBai3_Click(object sender, EventArgs e)
        {
            var btn = new frmBai3();
            btn.ShowDialog();
        }
    }
}
