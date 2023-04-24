using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm2
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            if(rdbCong.Checked)
            {
                lblKetQua.Text = (double.Parse(txtSoThuNhat.Text) + double.Parse(txtSoThuHai.Text)).ToString();
            }
            else if(rdbTru.Checked)
            {
                lblKetQua.Text = (double.Parse(txtSoThuNhat.Text) - double.Parse(txtSoThuHai.Text)).ToString();
            }
            else if (rdbNhan.Checked)
            {
                lblKetQua.Text = (double.Parse(txtSoThuNhat.Text) * double.Parse(txtSoThuHai.Text)).ToString();
            }
            else
            {
                lblKetQua.Text = (double.Parse(txtSoThuNhat.Text) / double.Parse(txtSoThuHai.Text)).ToString();
            }
        }
    }
}
